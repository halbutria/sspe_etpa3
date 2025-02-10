using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteModel;
using SispeServiciosApiCiudadano.Aplicacion.Utils;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class Consulta
    {
        public class Ejecuta : IRequest<CiudadanoInfoDTO>
        {
            public Guid? Id { get; set; }
            public string? NumeroDocumento { get; set; }
            public int? TipoDocumentoId { get; set; }
        }

        //public class EjecutaValidacion : AbstractValidator<Ejecuta>
        //{
        //    public EjecutaValidacion()
        //    {
        //        RuleFor(x => x.CiudadanoId).NotEmpty();
        //    }
        //}

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoInfoDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;
            private readonly ConvertirCiudadanoAPersona _aPersona;

            public Manejador(Contexto contexto, IMapper mapper, ConvertirCiudadanoAPersona aPersona)
            {
                _contexto = contexto;
                _mapper = mapper;
                _aPersona = aPersona;
            }

            public async Task<CiudadanoInfoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var query = _contexto.Ciudadano.Include(i => i.CargoInteres);
                var ciudadano = new CiudadanoModel();
                List<string> cargoIneteres = new List<string>();
                List<int> condicionDiscapacidad = new List<int>();
                List<int> condicionSaludMental = new List<int>();
                List<int> tipoPoblacion = new List<int>();
                List<int> grupoEtnico = new List<int>();

                try
                {
                    if (request.Id is not null)
                    {
                        ciudadano = await query
                            .Include("Direcciones.DireccionComplemento")
                            .Include(i => i.Discapacidad)
                            .Include(i => i.CondicionMental)
                            .Include(i => i.TipoPoblacion)
                            .Include(i => i.CargoInteres)
                            .Include(i => i.GrupoEtnico)
                            .Where(x => x.Id == request.Id)
                            .FirstOrDefaultAsync();
                    }
                    else if (request.TipoDocumentoId is not null && request.NumeroDocumento is not null)
                    {
                        ciudadano = await query
                            .Include(x=> x.Direcciones)
                            //.Include("Direcciones.DireccionComplemento")
                            .Include(i => i.Discapacidad)
                            .Include(i => i.CondicionMental)
                            .Include(i => i.TipoPoblacion)
                            .Include(i => i.CargoInteres)
                            .Include(i => i.GrupoEtnico)
                            .Where(x => x.TipoDocumentoId == request.TipoDocumentoId && x.NumeroDocumento == request.NumeroDocumento && x.Activo == true)
                            .FirstOrDefaultAsync();
                    }

                    if (ciudadano is not null)
                    {
                        var mapp = _mapper.Map<CiudadanoModel, CiudadanoInfoDTO>(ciudadano);

                        foreach (var tp in ciudadano.CargoInteres.Where(x=> x.CargoInteresId != null).ToList())
                            cargoIneteres.Add(tp.CargoInteresId);

                        foreach (var tp in ciudadano.Discapacidad)
                            condicionDiscapacidad.Add(tp.DisacapacidaId);

                        foreach (var tp in ciudadano.CondicionMental)
                            condicionSaludMental.Add(tp.CondicionMentalId);

                        foreach (var tp in ciudadano.TipoPoblacion)
                            tipoPoblacion.Add(tp.TipoPoblacionId);

                        foreach (var ge in ciudadano.GrupoEtnico)
                            grupoEtnico.Add(ge.GrupoEtnicoId);


                        mapp.CargoIneteres = cargoIneteres;
                        mapp.CondicionDiscapacidad = condicionDiscapacidad;
                        mapp.CondicionSaludMental = condicionSaludMental;
                        mapp.TipoPoblacion = tipoPoblacion;
                        mapp.GrupoEtnico = grupoEtnico;
                        
                        await _aPersona.ComplementarInfoAsync(mapp);

                        return mapp;
                    }

                    throw new Exception("Ciudadano no encontrado");
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }

            }

            

        }
    }
}
