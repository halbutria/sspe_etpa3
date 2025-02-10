using AutoMapper;
using MediatR;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ConocimientoCompetencia
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ConocimientoCompetenciaDTO>
        {
            public Guid CiudadanoId { get; set; }
            public string? Nombre { get; set; }
            public string? ConocimientoId { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, ConocimientoCompetenciaDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;
            private readonly IDomainEventHub<SendQueueEvent> SendQueueEventHub;

            public Manejador(Contexto contexto, IMapper mapper, IDomainEventHub<SendQueueEvent> sendQueueEventHub)
            {
                _contexto = contexto;
                _mapper = mapper;
                SendQueueEventHub = sendQueueEventHub;
            }
            public async Task<ConocimientoCompetenciaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CiudadanoConocimientoCompetenciaModel conocimiento = new CiudadanoConocimientoCompetenciaModel();
                int respuesta = new int();

                // Validacion por conocimientoId
                if (request.ConocimientoId != "" && request.ConocimientoId is not null)
                {
                    var info = _contexto.CiudadanoConocimientoCompetencia
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.ConocimientoId == request.ConocimientoId)
                       .FirstOrDefault();

                    if (info is null)
                    {
                        conocimiento = _mapper.Map<Ejecuta, CiudadanoConocimientoCompetenciaModel>(request);
                        _contexto.CiudadanoConocimientoCompetencia.Add(conocimiento);
                        respuesta = await _contexto.SaveChangesAsync();

                        if (respuesta > 0)
                        {
                            RaiseEventItIsSuccess(conocimiento);
                            return _mapper.Map<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>(conocimiento);
                        }
                        throw new Exception("Error al gurdar el Conocimiento o Competencia");
                    }
                    throw new Exception("Conocimiento ya registrado para el ciudadano");

                }
                // Validacion por nombre
                if (request.Nombre != "" && request.Nombre is not null)
                {
                    var info = _contexto.CiudadanoConocimientoCompetencia
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.Nombre == request.Nombre)
                       .FirstOrDefault();

                    if (info is null)
                    {
                        conocimiento = _mapper.Map<Ejecuta, CiudadanoConocimientoCompetenciaModel>(request);
                        _contexto.CiudadanoConocimientoCompetencia.Add(conocimiento);
                        respuesta = await _contexto.SaveChangesAsync();

                        if (respuesta > 0)
                        {
                            RaiseEventItIsSuccess(conocimiento);
                            return _mapper.Map<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>(conocimiento);
                        }
                        throw new Exception("Error al gurdar el Conocimiento o Competencia");
                    }
                    throw new Exception("Conocimiento ya registrado para el ciudadano.");

                }
                // resultado normal
                conocimiento = _mapper.Map<Ejecuta, CiudadanoConocimientoCompetenciaModel>(request);
                _contexto.CiudadanoConocimientoCompetencia.Add(conocimiento);
                respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    RaiseEventItIsSuccess(conocimiento);
                    return _mapper.Map<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>(conocimiento);
                }
                throw new Exception("Error al gurdar el Conocimiento o Competencia");

            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoConocimientoCompetenciaModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoConocimientoCompetencia",
                            Registro = new RegistroDto
                            {
                                Id = ciudadano.Id.ToString(),
                                Proceso = "Creacion"
                            }
                        }
                    }
                };
                SendQueueEventHub.Raise(message);
            }
        }

    }
}
