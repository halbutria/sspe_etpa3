using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosAsociados
{
    public class Edicion
    {

        public class Ejecuta : IRequest<ServiciosAsociadosDTO>
        {
            public Guid Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public int ServiciosAsociadosId { get; set; }
            public string CodigoServiciosAsociados { get; set; } = string.Empty;
            public string NombreServiciosAsociados { get; set; } = string.Empty;
            public int BrechaServiciosAsociadosId { get; set; }
            public string CodigoBrechaServiciosAsociados { get; set; } = string.Empty;
            public string NombreBrechaServiciosAsociados { get; set; } = string.Empty;
            public string? Seguimiento { get; set; } = string.Empty;
            public string? Observacion { get; set; } = string.Empty;
        }
        public class Manejador : IRequestHandler<Ejecuta, ServiciosAsociadosDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ServiciosAsociadosDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoServiciosAsociados.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                var infoCiuRed = await _contexto.CiudadanoServiciosAsociados
                    .Where(x =>
                        x.CiudadanoId == request.CiudadanoId &&
                        x.ServiciosAsociadosId == request.ServiciosAsociadosId &&
                        x.BrechaServiciosAsociadosId == request.BrechaServiciosAsociadosId &&
                        x.Id != request.Id
                    ).FirstOrDefaultAsync();

                if (infoCiuRed is null)
                {
                    if (info is not null)
                    {
                        info.Seguimiento = request.Seguimiento;
                        info.Observacion = request.Observacion;
                        var respuesta = await _contexto.SaveChangesAsync();
                        //if (respuesta > 0)
                        //{
                        return _mapper.Map<CiudadanoServiciosAsociadosModel, ServiciosAsociadosDTO>(info);
                        //}

                        //throw new Exception("Error al editar");
                    }
                    throw new Exception("No existe Informacion a editar.");
                }
                throw new Exception("Servicio asociado ya registrada para el ciudadano.");
            }
        }

    }
}
