using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;
using SispeServicios.Archivo.S3;
using SispeServicios.DbContextBase.Modelo;
using SispeServiciosApiIntermediacion.Aplicacion.Utils;
using SispeServiciosApiIntermediacion.Aplicacion.Validadciones;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Intermediacion.Aplicacion.Vacante
{
    public class Nuevo
    {
       public class Ejecuta: VacanteBaseDTO , IRequest<VacanteNuevoSalidaDTO>
        {
            public int SedeId { get; set; }
        }


        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion(Contexto contexto)
            {
                RuleFor(x => x.CodigoInternoVacante).Must(m => HidrocarburosValidator.CodigoInternoVacanteUnicoAsync(m,contexto).Result).WithMessage(IntermediacionErrors.codigoInternoVacanteUnico);

            }
        }




        public class Manejador : IRequestHandler<Ejecuta, VacanteNuevoSalidaDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;
            private readonly IStorageService _storageService;
            private readonly IConfiguration _config;

            public Manejador(Contexto contexto, IMapper mapper,IStorageService storageService, IConfiguration config)
            {
                _contexto = contexto;
                _mapper = mapper;
                _storageService = storageService;
                _config = config;
            }

            public async Task<VacanteNuevoSalidaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var model = _mapper.Map<Ejecuta, VacanteModel>(request);

                var numero = await _contexto.Vacantes.Where(x => x.SedeId == request.SedeId).CountAsync();
                model.Numero = (numero+1).ToString("D6");
                model.Identificador = $"{model.SedeId}-{model.Numero}-{model.PuestosRequeridos??0}";                
                model.SolicitudAutorizacionExcepcionalidad = "SolicitudAutorizacionExcepcionalidad";
                _contexto.Vacantes?.Add(model);

                if (request.SolicitudAutorizacionExcepcionalidadFile is not null)
                {
                    var config = new ConfigStorage()
                    {
                        Repository = _config["ConfigStorage:Repository"],
                        SecretKey = _config["ConfigStorage:SecretKey"],
                        AccessKey = _config["ConfigStorage:AccessKey"],
                        File = request.SolicitudAutorizacionExcepcionalidadFile,
                        FileName = $"{model.SedeId}-{model.Numero}"
                    };
                    var respuestaArchivo = await _storageService.UploadFileAsync(config);                    
                    model.Archivos = new List<VacanteArchivoModel>();
                    model.Archivos.Add(new VacanteArchivoModel()
                    {
                        TipoArchivo = "SolicitudAutorizacionExcepcionalidad",
                        NombreArchivo = respuestaArchivo.FileName,
                        NombreArchivoRepositorio = respuestaArchivo.FileNameRespository,
                    });
                }

                //EsHidrocarburos
                model.EsHidrocarburos = EsHidrocarburos.validar(model);

                model.CambioEstados = new List<VacanteCambioEstadoModel>()
                    {
                    new VacanteCambioEstadoModel() {
                        EstadoId = model.EstadoId,
                     }
                    };

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return new VacanteNuevoSalidaDTO() { Id = model.Id,Identificador = model.Identificador };
                }
                throw new Exception("Error al gurdar.");
            }
        }

    }
}
