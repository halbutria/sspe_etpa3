using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Experiencia
{
    public class Edicion
    {

        public class Ejecuta : IRequest<ExperienciaDTO>
        {
            public Guid Id { get; set; }
            public Guid CiudadanoEducacionFormalId { get; set; }
            public Guid CiudadanoId { get; set; }
            public string? Nombre { get; set; }
            public string? Telefono { get; set; }
            public int TipoExperienciaId { get; set; }
            public string OcupacionId { get; set; }
            //public bool ConExperiencia { get; set; }
            public string? LugarExperiencia { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaRetiro { get; set; }
            //public bool Actual { get; set; }
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
                var info = await _contexto.CiudadanoExperiencia
                    .Include(i => i.ConocimientoCompetenciaExperienciaPrevia)
                    .Include(i => i.HabilidadDestrezaExperienciaPrevia)
                    .Include(i => i.CiudadanoEducacionFormalExperiencia)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                if (info is not null)
                {
                    var infoAntes = Cloner.DeepClone(info);
                    var conocimientoexppreviaAnterior = info.ConocimientoCompetenciaExperienciaPrevia?.ToList();
                    var habilidadexppreviaAnterior = info.HabilidadDestrezaExperienciaPrevia?.ToList();
                    var infoLaboralAnterior = info.CiudadanoEducacionFormalExperiencia?.ToList();

                    ICollection<ConocimientoCompetenciaExperienciaPreviaModel> conocimientoexpprevia = new List<ConocimientoCompetenciaExperienciaPreviaModel>();
                    ICollection<HabilidadDestrezaExperienciaPreviaModel> habilidadexpprevia = new List<HabilidadDestrezaExperienciaPreviaModel>();
                    List<CiudadanoEducacionFormalExperienciaModel> experienciaInformacionLaboral = new List<CiudadanoEducacionFormalExperienciaModel>();

                    foreach (var id in request.ConocimientoCompetenciaExperienciaPrevia)
                        conocimientoexpprevia.Add(new ConocimientoCompetenciaExperienciaPreviaModel { ConocimientoId = id });

                    foreach (var id in request.HabilidadDestrezaExperienciaPrevia)
                        habilidadexpprevia.Add(new HabilidadDestrezaExperienciaPreviaModel { HabilidadId = id });

                    info.CiudadanoId = request.CiudadanoId;
                    info.Nombre = request.Nombre;
                    info.Telefono = request.Telefono;
                    info.OcupacionId = request.OcupacionId;
                    info.LugarExperiencia = request.LugarExperiencia;
                    info.FechaIngreso = request.FechaIngreso;
                    info.FechaRetiro = request.FechaRetiro;


                    /*List<ConocimientoCompetenciaExperienciaPreviaModel> conocimientoexpprevia = new List<ConocimientoCompetenciaExperienciaPreviaModel>();
                    List<HabilidadDestrezaExperienciaPreviaModel> habilidadexpprevia = new List<HabilidadDestrezaExperienciaPreviaModel>();

                    foreach (var coninflab in request.ConocimientoCompetenciaExperienciaPrevia)
                    {
                        conocimientoexpprevia.Add(
                            new ConocimientoCompetenciaExperienciaPreviaModel
                            {
                                ExperienciaPreviaId = request.Id,
                                ConocimientoId = coninflab.ConocimientoId,
                                Nombre = coninflab.Nombre,
                                RutaCertificado = coninflab.RutaCertificado
                            }
                        );
                    }

                    foreach (var habinflab in request.HabilidadDestrezaExperienciaPrevia)
                    {
                        habilidadexpprevia.Add(
                            new HabilidadDestrezaExperienciaPreviaModel
                            {
                                ExperienciapreviaId = request.Id,
                                HabilidadId = habinflab.HabilidadId,
                                Nombre = habinflab.Nombre,
                                RutaCertificado = habinflab.RutaCertificado
                            }
                        );
                    }*/

                    info.ConocimientoCompetenciaExperienciaPrevia = conocimientoexpprevia;
                    info.HabilidadDestrezaExperienciaPrevia = habilidadexpprevia;

                    experienciaInformacionLaboral.Add(new CiudadanoEducacionFormalExperienciaModel { CiudadanoEducacionFormalId = request.CiudadanoEducacionFormalId });
                    info.CiudadanoEducacionFormalExperiencia = experienciaInformacionLaboral;

                    _contexto.CiudadanoExperiencia.Update(info);

                    _contexto.RemoveRange(conocimientoexppreviaAnterior);
                    _contexto.RemoveRange(habilidadexppreviaAnterior);
                    _contexto.RemoveRange(infoLaboralAnterior);

                    var respuesta = await _contexto.SaveChangesAsync();

                    //if (respuesta > 0)
                    //{
                    RaiseEventItIsSuccess(info, infoAntes);
                    var resp = _mapper.Map<CiudadanoExperienciaModel, ExperienciaDTO>(info);
                    resp.CiudadanoEducacionFormalId = request.CiudadanoEducacionFormalId;
                    return resp;

                    //}

                    //throw new Exception("Error al editar");
                }
                throw new Exception("No existe Informacion a editar.");
            }
            private void RaiseEventItIsSuccess(CiudadanoExperienciaModel ciudadano, CiudadanoExperienciaModel infoAntes)
            {
                bool hayDiferencias = ciudadano.CiudadanoId != infoAntes.CiudadanoId
                    || ciudadano.Nombre != infoAntes.Nombre
                    || ciudadano.Telefono != infoAntes.Telefono
                    || ciudadano.TipoExperienciaId != infoAntes.TipoExperienciaId
                    || ciudadano.OcupacionId != infoAntes.OcupacionId
                    || ciudadano.LugarExperiencia != infoAntes.LugarExperiencia
                    || ciudadano.FechaIngreso != infoAntes.FechaIngreso
                    || ciudadano.FechaRetiro != infoAntes.FechaRetiro;



                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid()
                };

                if (hayDiferencias)
                {
                    message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                    {
                        Tabla = "CiudadanoExperiencia",
                        Registro = new RegistroDto
                        {
                            Id = ciudadano.Id.ToString(),
                            Proceso = "Actualizacion"
                        }
                    });

                }

                if (ciudadano.ConocimientoCompetenciaExperienciaPrevia.Any() && infoAntes.ConocimientoCompetenciaExperienciaPrevia.Any())
                {
                    foreach (var item in ciudadano.ConocimientoCompetenciaExperienciaPrevia)
                    {
                        var existeEnInfoAntes = infoAntes.ConocimientoCompetenciaExperienciaPrevia
                            .Any(x => x.ConocimientoId == item.ConocimientoId);

                        if (!existeEnInfoAntes)
                        {
                            message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                            {
                                Tabla = "CiudadanoConocimientoCompetenciaExperienciaPrevia",
                                Registro = new RegistroDto
                                {
                                    Id = item.Id.ToString(),
                                    Proceso = "Actualizacion"
                                }
                            });
                        }
                    }
                }


                if (ciudadano.HabilidadDestrezaExperienciaPrevia.Any() && infoAntes.HabilidadDestrezaExperienciaPrevia.Any())
                {
                    foreach (var item in ciudadano.HabilidadDestrezaExperienciaPrevia)
                    {
                        var existeEnInfoAntes = infoAntes.HabilidadDestrezaExperienciaPrevia
                            .Any(x => x.HabilidadId == item.HabilidadId);

                        if (!existeEnInfoAntes)
                        {
                            message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                            {
                                Tabla = "CiudadanoHabilidadDestrezaExperienciaPrevia",
                                Registro = new RegistroDto
                                {
                                    Id = item.Id.ToString(),
                                    Proceso = "Actualizacion"
                                }
                            });
                        }
                    }
                }


                if (message.ExternalRequestBodyDto.Any())
                {
                    SendQueueEventHub.Raise(message);
                }
            }
        }

    }
}
