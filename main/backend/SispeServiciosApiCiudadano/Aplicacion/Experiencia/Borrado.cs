using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Experiencia
{
    public class Borrado
    {
        public class Ejecuta : IRequest
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
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

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoExperiencia.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    _contexto.CiudadanoExperiencia.Remove(info);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        RaiseEventItIsSuccess(info);
                        return Unit.Value;
                    }
                    throw new Exception("Error al deshabilitar");
                }
                throw new Exception("No existe Informacion.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoExperienciaModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoExperiencia",
                            Registro = new RegistroDto
                            {
                                Id = ciudadano.Id.ToString(),
                                Proceso = "Eliminacion"
                            }
                        }
                    }
                };

                if (ciudadano.ConocimientoCompetenciaExperienciaPrevia.Any())
                {
                    foreach (var item in ciudadano.ConocimientoCompetenciaExperienciaPrevia)
                    {
                        message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoConocimientoCompetenciaExperienciaPrevia",
                            Registro = new RegistroDto
                            {
                                Id = item.Id.ToString(),
                                Proceso = "Eliminacion"
                            }
                        });
                    }
                }

                if (ciudadano.HabilidadDestrezaExperienciaPrevia.Any())
                {
                    foreach (var item in ciudadano.HabilidadDestrezaExperienciaPrevia)
                    {
                        message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoHabilidadDestrezaExperienciaPrevia",
                            Registro = new RegistroDto
                            {
                                Id = item.Id.ToString(),
                                Proceso = "Eliminacion"
                            }
                        });
                    }
                }
                SendQueueEventHub.Raise(message);
            }
        }
    }
}