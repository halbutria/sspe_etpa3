using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Aplicacion.Utils;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;


namespace SispeServicios.Api.Ciudadano.Aplicacion.InformacionLaboral
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public Guid? Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public int TipoExperienciaId { get; set; }
            public string NombreEmpresa { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime? FechaRetiro { get; set; }
            public bool TrabajoActual { get; set; }
            public int SectorId { get; set; }
            public string? TelefonoEmpresa { get; set; }
            public int PaisId { get; set; }
            public string Cargo { get; set; }
            public string? Funciones { get; set; }
            public string OcupacionEquivalenteId { get; set; }
            public string? ProductoServicioProduceComercializa { get; set; }
            public int? CuantasPresonasTrabajanConUsted { get; set; }
            public string[]? ConocimientoCompetenciaInformacionLaboral { get; set; }
            public string[]? HabilidadDestrezaInformacionLaboral { get; set; }

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
                var informacionLaboral = _mapper.Map<Ejecuta, CiudadanoInformacionLaboralModel>(request);
                var ciudadado = await _contexto.Ciudadano.Include(x => x.InformacionLaboral).FirstOrDefaultAsync(x => x.Id == request.CiudadanoId);
                if (ciudadado is not null)
                {
                    var avance = await CalculoAvanceHojaVida.procesarAsync(_contexto, ciudadado, "Experiencia laboral");

                    ciudadado.PorcentajeInfoLaboral = avance.Avance;
                    ciudadado.PorcentajeHv = avance.AvanceTotal;
                    ciudadado.HojaVidaCompleta = avance.HojaVidaCompleta;

                    List<ConocimientoCompetenciaInformacionLaboralModel> conocimientoinfoLaboral = new List<ConocimientoCompetenciaInformacionLaboralModel>();
                    List<HabilidadDestrezaInformacionLaboralModel> habilidadinfoLaboral = new List<HabilidadDestrezaInformacionLaboralModel>();

                    foreach (var coninflab in request.ConocimientoCompetenciaInformacionLaboral)
                        conocimientoinfoLaboral.Add(new ConocimientoCompetenciaInformacionLaboralModel { ConocimientoId = coninflab });

                    foreach (var habinflab in request.HabilidadDestrezaInformacionLaboral)
                        habilidadinfoLaboral.Add(new HabilidadDestrezaInformacionLaboralModel { HabilidadId = habinflab });

                    informacionLaboral.ConocimientoCompetenciaInformacionLaboral = conocimientoinfoLaboral;
                    informacionLaboral.HabilidadDestrezaInformacionLaboral = habilidadinfoLaboral;

                    ciudadado.InformacionLaboral.Add(informacionLaboral);
                    try
                    {

                        var respuesta = await _contexto.SaveChangesAsync();
                        if (respuesta > 0)
                        {
                            RaiseEventItIsSuccess(informacionLaboral);
                            RaiseEventItIsSuccess(informacionLaboral);
                            return Unit.Value;//_mapper.Map<CiudadanoInformacionLaboralModel, InformacionLaboralDTO>(informacionLaboral);
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }

                    throw new Exception("Error al gurdar Informacion laboral");
                }
                throw new Exception("no existe ciudadano.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoInformacionLaboralModel ciudadano)
            {
                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid(),
                    ExternalRequestBodyDto = new List<ExternalRequestBodyDto>
                    {
                        new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoInformacionLaboral",
                            Registro = new RegistroDto
                            {
                                Id = ciudadano.Id.ToString(),
                                Proceso = "Creacion"
                            }
                        }
                    }
                };

                if (ciudadano.ConocimientoCompetenciaInformacionLaboral.Any())
                {
                    foreach (var item in ciudadano.ConocimientoCompetenciaInformacionLaboral)
                    {
                        message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoConocimientoCompetenciaInformacionLaboral",
                            Registro = new RegistroDto
                            {
                                Id = item.Id.ToString(),
                                Proceso = "Creacion"
                            }
                        });
                    }
                }

                if (ciudadano.HabilidadDestrezaInformacionLaboral.Any())
                {
                    foreach (var item in ciudadano.HabilidadDestrezaInformacionLaboral)
                    {
                        message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                        {
                            Tabla = "CiudadanoHabilidadDestrezaInformacionLaboral",
                            Registro = new RegistroDto
                            {
                                Id = item.Id.ToString(),
                                Proceso = "Creacion"
                            }
                        });
                    }
                }

                SendQueueEventHub.Raise(message);
            }
        }

    }
}
