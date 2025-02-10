using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Idioma
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<IdiomaDTO>
        {
            public Guid CiudadanoId { get; set; }
            public int IdiomaId { get; set; }
            public string NivelEscrito { get; set; }
            public string NivelHablado { get; set; }
            public string NivelEscucha { get; set; }
            public string NivelLectura { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, IdiomaDTO>
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
            public async Task<IdiomaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var info = await _contexto.CiudadanoIdioma
                    .Where(x => x.CiudadanoId == request.CiudadanoId && x.IdiomaId == request.IdiomaId)
                    .FirstOrDefaultAsync();

                if (info is null)
                {
                    var idioma = _mapper.Map<Ejecuta, CiudadanoIdiomaModel>(request);
                    _contexto.CiudadanoIdioma.Add(idioma);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        RaiseEventItIsSuccess(idioma);
                        return _mapper.Map<CiudadanoIdiomaModel, IdiomaDTO>(idioma);
                    }
                    throw new Exception("Error al gurdar el Idioma.");
                }
                throw new Exception("Idioma ya registrado para el ciudadano.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoIdiomaModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoIdioma",
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
