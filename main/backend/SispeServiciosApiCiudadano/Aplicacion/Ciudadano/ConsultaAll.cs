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
using SispeServicios.Paginacion;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class ConsultaAll
    {
        public class Ejecuta : PaginacionDTO, IRequest<(string encabezado, List<CiudadanoInfoDTO> registros)>
        {
           
            public string? NumeroDocumento { get; set; }
            public int?    TipoDocumentoId { get; set; }
            public string? PrimerNombre { get; set; }
            public string? SegundoNombre { get; set; }
            public string? PrimerApellido { get; set; }
            public string? SegundoApellido { get; set; }
            public List<Guid>? Ids { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, (string encabezado ,List<CiudadanoInfoDTO> registros)>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<(string encabezado, List<CiudadanoInfoDTO> registros)> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var query = _contexto.Ciudadano.AsQueryable();
                if(request.Ids is not null)
                {

                  

                    query = query.Where(x => request.Ids.Contains(x.Id));

                    request.RegistrosPorPagina = request.Ids.Count();
                }
                if(request.PrimerNombre is not null)
                {
                    query=query.Where(x => x.PrimerNombre.Contains(request.PrimerNombre));
                }
                if (request.SegundoNombre is not null)
                {
                    query = query.Where(x => x.SegundoNombre.Contains(request.SegundoNombre));
                }
                if (request.PrimerApellido is not null)
                {
                    query = query.Where(x => x.PrimerApellido.Contains(request.PrimerApellido));
                }
                if (request.SegundoApellido is not null)
                {
                    query = query.Where(x => x.SegundoApellido.Contains(request.SegundoApellido));
                }
                if (request.TipoDocumentoId is not null)
                {
                    query = query.Where(x => x.TipoDocumentoId == request.TipoDocumentoId);
                }
                if (request.NumeroDocumento is not null)
                {
                    query = query.Where(x => x.NumeroDocumento == request.NumeroDocumento);
                }
                //query= query.OrderBy(x => x.TipoDocumentoId).ThenByDescending(x => x.FechaCreacion);
                var ciudadano = await ListaPaginada<CiudadanoModel>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);


                List<string> ciudadoIds = ciudadano.Select(x => x.Id.ToString()).ToList();
                List<string> prestadorIds = ciudadano.Select(x => x.PrestadorPreferenciaId.ToString().ToLower()).ToList();

                var Ids = ciudadoIds.Union(prestadorIds).ToArray();

                var personainfo = _contexto.CiudadanoPersona
                .Where(p => Ids.Contains(p.Id))
                .ToList();

                ciudadano.ForEach(x =>
                {
                    var persona = personainfo.Where(p => p.Id.ToLower() == x.Id.ToString()).First();
                    complementarInfoAsync(persona, x);
                });
                var data = _mapper.Map<List<CiudadanoModel>, List<CiudadanoInfoDTO>>(ciudadano);

                

                data.Where(x=>x.PrestadorPreferenciaId != null ).ToList().ForEach(x => {
                    var prestador = personainfo.Where(p => p.Id == x.PrestadorPreferenciaId).FirstOrDefault();
                    x.PrestadorPreferenciaNombre = prestador?.RazonSocial;
                });

                return (ciudadano.GetMetadata(), data);

            }

            private void complementarInfoAsync(CiudadanoPersonaViewModel? persona, CiudadanoModel buscador)
            {
                buscador.NumeroDocumento = persona.NumeroDocumento;
                buscador.CorreoElectronico = persona.CorreoElectronico;
                buscador.PrimerNombre = persona.PrimerNombre;
                buscador.SegundoNombre = persona.SegundoNombre;
                buscador.PrimerApellido = persona.PrimerApellido;
                buscador.SegundoApellido = persona.SegundoApellido;
                buscador.FechaNacimiento = persona.FechaNacimiento.Value;
                buscador.SexoId = persona.SexoId.Value;
                buscador.Telefono = persona.Telefono;
                buscador.DireccionResidencia = persona.DireccionResidencia;
                buscador.PaisResidenciaId = (persona.PaisResidenciaId == null)?0: persona.PaisResidenciaId.Value;
                buscador.DepartamentoResidenciaId = persona.DepartamentoResidenciaId;
                buscador.MunicipioResidenciaId = persona.MunicipioResidenciaId;
                buscador.PrestadorPreferenciaId = persona.PrestadorPreferenciaId;
                buscador.PuntoAtencionId = persona.PuntoAtencionId;
                //buscador.PreguntaSeguridadId = persona.PreguntaSeguridadId;
                //buscador.PreguntaSeguridadRespuesta = persona.PreguntaSeguridadRespuesta;
                buscador.LocalidadComunaId = persona.LocalidadComunaId;
                buscador.PreguntaLibre = persona.PreguntaLibre;
                //buscador.Activo = persona.Activo;
                buscador.BarrioResidencia = persona.BarrioResidencia;
                buscador.PerteneceARural = persona.PerteneceARural;
                buscador.OtroTelefono = persona.OtroTelefono;

            }

        }
    }
}
