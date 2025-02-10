using AutoMapper;
using MediatR;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.HabilidadDestreza
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<HabilidadDestrezaDTO>
        {
            public Guid CiudadanoId { get; set; }
            public string? HabilidadId { get; set; }
            public string? Nombre { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, HabilidadDestrezaDTO>
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
            public async Task<HabilidadDestrezaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CiudadanoHabilidadDestrezaModel conocimiento = new CiudadanoHabilidadDestrezaModel();
                int respuesta = new int();

                // Validacion por habilidadId
                if (request.HabilidadId != "" && request.HabilidadId is not null)
                {
                    var info = _contexto.CiudadanoHabilidadDestreza
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.HabilidadId == request.HabilidadId)
                       .FirstOrDefault();

                    if (info is null)
                    {
                        conocimiento = _mapper.Map<Ejecuta, CiudadanoHabilidadDestrezaModel>(request);
                        _contexto.CiudadanoHabilidadDestreza.Add(conocimiento);
                        respuesta = await _contexto.SaveChangesAsync();

                        if (respuesta > 0)
                        {
                            RaiseEventItIsSuccess(conocimiento);
                            return _mapper.Map<CiudadanoHabilidadDestrezaModel, HabilidadDestrezaDTO>(conocimiento);
                        }
                        throw new Exception("Error al gurdar el Habilidad o Destreza");
                    }
                    throw new Exception("Habilidad o Destreza ya registrada para el ciudadano.");

                }
                // Validacion por nombre
                if (request.Nombre != "" && request.Nombre is not null)
                {
                    var info = _contexto.CiudadanoHabilidadDestreza
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.Nombre == request.Nombre)
                       .FirstOrDefault();

                    if (info is null)
                    {
                        conocimiento = _mapper.Map<Ejecuta, CiudadanoHabilidadDestrezaModel>(request);
                        _contexto.CiudadanoHabilidadDestreza.Add(conocimiento);
                        respuesta = await _contexto.SaveChangesAsync();

                        if (respuesta > 0)
                        {
                            RaiseEventItIsSuccess(conocimiento);
                            return _mapper.Map<CiudadanoHabilidadDestrezaModel, HabilidadDestrezaDTO>(conocimiento);
                        }
                        throw new Exception("Error al gurdar el Habilidad o Destreza");
                    }
                    throw new Exception("Habilidad o Destreza ya registrada para el ciudadano.");

                }
                // resultado normal
                conocimiento = _mapper.Map<Ejecuta, CiudadanoHabilidadDestrezaModel>(request);
                _contexto.CiudadanoHabilidadDestreza.Add(conocimiento);
                respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    RaiseEventItIsSuccess(conocimiento);
                    return _mapper.Map<CiudadanoHabilidadDestrezaModel, HabilidadDestrezaDTO>(conocimiento);
                }
                throw new Exception("Error al gurdar el Habilidad o Destreza");
            }

            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoHabilidadDestrezaModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoHabilidadDestreza",
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
