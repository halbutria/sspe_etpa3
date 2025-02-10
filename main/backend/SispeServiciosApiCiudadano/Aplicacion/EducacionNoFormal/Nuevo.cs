using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Aplicacion.Utils;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.EducacionNoFormal
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public Guid CiudadanoId { get; set; }
            public int TipoCertificadoCapacitacionId { get; set; }
            public string NombrePrograma { get; set; }
            public string Institucion { get; set; }
            public int? PaisId { get; set; }
            public int EstadoId { get; set; }
            public int? Duracion { get; set; }
            public DateTime? FechaCertificacion { get; set; }
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
                var educacionNoFormal = _mapper.Map<Ejecuta, CiudadanoEducacionNoFormalModel>(request);
                var ciudadado = await _contexto.Ciudadano.Include(x => x.EducacionNoFormal).FirstOrDefaultAsync(x => x.Id == request.CiudadanoId);
                if (ciudadado is not null)
                {
                    var avance = await CalculoAvanceHojaVida.procesarAsync(_contexto, ciudadado, "Educación no formal");
                    ciudadado.PorcentajeEduNoFormal = avance.Avance;
                    ciudadado.PorcentajeHv = avance.AvanceTotal;
                    ciudadado.HojaVidaCompleta = avance.HojaVidaCompleta;

                    ciudadado.EducacionNoFormal.Add(educacionNoFormal);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        RaiseEventItIsSuccess(educacionNoFormal);
                        return Unit.Value; //_mapper.Map<CiudadanoEducacionNoFormalModel, EducacionNoFormalDTO>(educacionNoFormal);
                    }
                    throw new Exception("Error al gurdar.");
                }

                throw new Exception("no existe ciudadano.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoEducacionNoFormalModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoEducacionNoFormal",
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
