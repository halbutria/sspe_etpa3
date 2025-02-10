using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Aplicacion.Utils;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.EducacionFormal
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public Guid CiudadanoId { get; set; }
            public int? NucleoConocimientoId { get; set; }
            public int NivelEducativoId { get; set; }
            public int? AreaConocimientoId { get; set; }
            public string? TituloObtenido { get; set; }
            public int? TituloHomologadoId { get; set; }
            public string? Institucion { get; set; }
            public int? InstitucionId { get; set; }
            public int? PaisId { get; set; }
            public int EstadoId { get; set; }
            public DateTime? FechaFinalizacion { get; set; }
            public bool? TarjetaProfesional { get; set; }
            public string? NumeroTarjetaProfesional { get; set; }
            public DateTime? FechaExpedicionTarjetaProfesional { get; set; }
            public string? Observacion { get; set; }
            public bool PracticaEmpresarial { get; set; }
            //public List<CiudadanoEducacionFormalExperienciaModel>? CiudadanoEducacionFormalExperiencia { get; set; }

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
                var educacionFormal = _mapper.Map<Ejecuta, CiudadanoEducacionFormalModel>(request);
                var ciudadado = await _contexto.Ciudadano.Include(x => x.EducacionFormal).FirstOrDefaultAsync(x => x.Id == request.CiudadanoId);
                if (ciudadado is not null)
                {
                    var avance = await CalculoAvanceHojaVida.procesarAsync(_contexto, ciudadado, "Educación formal");
                    ciudadado.PorcentajeEduFormal = avance.Avance;
                    ciudadado.PorcentajeHv = avance.AvanceTotal;
                    ciudadado.HojaVidaCompleta = avance.HojaVidaCompleta;

                    ciudadado.EducacionFormal.Add(educacionFormal);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        RaiseEventItIsSuccess(educacionFormal);
                        return Unit.Value;// _mapper.Map<CiudadanoEducacionFormal, EducacionFormalDTO>(educacionFormal);
                    }
                    throw new Exception("Error al gurdar Educacion Formal");
                }
                throw new Exception("no existe ciudadano.");

            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoEducacionFormalModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoEducacionFormal",
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
