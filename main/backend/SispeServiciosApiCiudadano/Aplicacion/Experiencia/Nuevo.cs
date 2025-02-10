using AutoMapper;
using MediatR;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Experiencia
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ExperienciaDTO>
        {
            public Guid CiudadanoId { get; set; }
            public Guid CiudadanoEducacionFormalId { get; set; }
            public string? Nombre { get; set; }
            public string? Telefono { get; set; }
            public int TipoExperienciaId { get; set; }
            public string OcupacionId { get; set; }
            public string? LugarExperiencia { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaRetiro { get; set; }
            public string[]? ConocimientoCompetenciaExperienciaPrevia { get; set; }
            public string[]? HabilidadDestrezaExperienciaPrevia { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ExperienciaDTO>
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
            public async Task<ExperienciaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var experiencia = _mapper.Map<Ejecuta, CiudadanoExperienciaModel>(request);
                List<CiudadanoEducacionFormalExperienciaModel> experienciaInformacionLaboral = new List<CiudadanoEducacionFormalExperienciaModel>();
                /* var informacionLaboral = _contexto.CiudadanoInformacionLaboral
                     .Include(x => x.info)(i => i.Id = request.CiudadanoInformacionLaboralId)
                     .Where(i=> );*/

                List<ConocimientoCompetenciaExperienciaPreviaModel> conocimientoexpprevia = new List<ConocimientoCompetenciaExperienciaPreviaModel>();
                List<HabilidadDestrezaExperienciaPreviaModel> habilidadexpprevia = new List<HabilidadDestrezaExperienciaPreviaModel>();

                foreach (var coninflab in request.ConocimientoCompetenciaExperienciaPrevia)
                    conocimientoexpprevia.Add(new ConocimientoCompetenciaExperienciaPreviaModel { ConocimientoId = coninflab });

                foreach (var habinflab in request.HabilidadDestrezaExperienciaPrevia)
                    habilidadexpprevia.Add(new HabilidadDestrezaExperienciaPreviaModel { HabilidadId = habinflab });

                experienciaInformacionLaboral.Add(new CiudadanoEducacionFormalExperienciaModel { CiudadanoEducacionFormalId = request.CiudadanoEducacionFormalId });
                experiencia.CiudadanoEducacionFormalExperiencia = experienciaInformacionLaboral;

                //experiencia.ConocimientoCompetenciaExperienciaPrevia = conocimientoexpprevia;
                //experiencia.HabilidadDestrezaExperienciaPrevia = habilidadexpprevia;
                //ciudadado.InformacionLaboral.Add(experiencia);

                experiencia.ConocimientoCompetenciaExperienciaPrevia = conocimientoexpprevia;
                experiencia.HabilidadDestrezaExperienciaPrevia = habilidadexpprevia;

                _contexto.CiudadanoExperiencia.Update(experiencia);
                _contexto.CiudadanoExperiencia.Add(experiencia);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    RaiseEventItIsSuccess(experiencia);
                    var resp = _mapper.Map<CiudadanoExperienciaModel, ExperienciaDTO>(experiencia);
                    resp.CiudadanoEducacionFormalId = request.CiudadanoEducacionFormalId;
                    return resp;
                }
                throw new Exception("Error al gurdar el Experiencia");
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
                                Proceso = "Creacion"
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
                                Proceso = "Creacion"
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
