using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.InformacionLaboral
{
    public class Edicion
    {

        public class Ejecuta : IRequest
        {

            public Guid Id { get; set; }
            public int TipoExperienciaId { get; set; }
            public string NombreEmpresa { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime? FechaRetiro { get; set; }
            public bool TrabajoActual { get; set; }
            public int SectorId { get; set; }
            public string? TelefonoEmpresa { get; set; }
            public int PaisId { get; set; }
            public string? Funciones { get; set; }
            public string Cargo { get; set; }
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
                var info = await _contexto.CiudadanoInformacionLaboral
                    .Include(i => i.ConocimientoCompetenciaInformacionLaboral)
                    .Include(i => i.HabilidadDestrezaInformacionLaboral)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    var infoAntes = Cloner.DeepClone(info);
                    var conocimientoinfoLaboralAnterior = info.ConocimientoCompetenciaInformacionLaboral?.ToList();
                    var habilidadinfoLaboralAnterior = info.HabilidadDestrezaInformacionLaboral?.ToList();

                    ICollection<ConocimientoCompetenciaInformacionLaboralModel> conocimientoinfoLaboral = new List<ConocimientoCompetenciaInformacionLaboralModel>();
                    ICollection<HabilidadDestrezaInformacionLaboralModel> habilidadinfoLaboral = new List<HabilidadDestrezaInformacionLaboralModel>();

                    foreach (var id in request.ConocimientoCompetenciaInformacionLaboral)
                        conocimientoinfoLaboral.Add(new ConocimientoCompetenciaInformacionLaboralModel { ConocimientoId = id });

                    foreach (var id in request.HabilidadDestrezaInformacionLaboral)
                        habilidadinfoLaboral.Add(new HabilidadDestrezaInformacionLaboralModel { HabilidadId = id });

                    info.TipoExperienciaId = request.TipoExperienciaId;
                    info.NombreEmpresa = request.NombreEmpresa;
                    info.FechaIngreso = request.FechaIngreso;
                    info.FechaRetiro = request.FechaRetiro;
                    info.TrabajoActual = request.TrabajoActual;
                    info.SectorId = request.SectorId;
                    info.TelefonoEmpresa = request.TelefonoEmpresa;
                    info.PaisId = request.PaisId;
                    info.Cargo = request.Cargo;
                    info.Funciones = request.Funciones;
                    info.OcupacionEquivalenteId = request.OcupacionEquivalenteId;
                    info.ProductoServicioProduceComercializa = request.ProductoServicioProduceComercializa;
                    info.CuantasPresonasTrabajanConUsted = request.CuantasPresonasTrabajanConUsted;
                    info.ConocimientoCompetenciaInformacionLaboral = conocimientoinfoLaboral;
                    info.HabilidadDestrezaInformacionLaboral = habilidadinfoLaboral;

                    _contexto.CiudadanoInformacionLaboral.Update(info);

                    _contexto.RemoveRange(conocimientoinfoLaboralAnterior);
                    _contexto.RemoveRange(habilidadinfoLaboralAnterior);

                    var respuesta = await _contexto.SaveChangesAsync();
                    //if (respuesta > 0)
                    //{
                    RaiseEventItIsSuccess(info, infoAntes);
                    return Unit.Value;// _mapper.Map<CiudadanoInformacionLaboralModel, InformacionLaboralDTO>(info);
                    //}

                    //throw new Exception("Error al editar");
                }
                throw new Exception("No existe Informacion a editar.");
            }
            private void RaiseEventItIsSuccess(CiudadanoInformacionLaboralModel ciudadano, CiudadanoInformacionLaboralModel infoAntes)
            {
                bool hayDiferencias = ciudadano.TipoExperienciaId != infoAntes.TipoExperienciaId
                    || ciudadano.NombreEmpresa != infoAntes.NombreEmpresa
                    || ciudadano.FechaIngreso != infoAntes.FechaIngreso
                    || ciudadano.FechaRetiro != infoAntes.FechaRetiro
                    || ciudadano.TrabajoActual != infoAntes.TrabajoActual
                    || ciudadano.SectorId != infoAntes.SectorId
                    || ciudadano.TelefonoEmpresa != infoAntes.TelefonoEmpresa
                    || ciudadano.PaisId != infoAntes.PaisId
                    || ciudadano.Funciones != infoAntes.Funciones
                    || ciudadano.Cargo != infoAntes.Cargo
                    || ciudadano.OcupacionEquivalenteId != infoAntes.OcupacionEquivalenteId
                    || ciudadano.ProductoServicioProduceComercializa != infoAntes.ProductoServicioProduceComercializa
                    || ciudadano.CuantasPresonasTrabajanConUsted != infoAntes.CuantasPresonasTrabajanConUsted;


                SendQueueEvent message = new()
                {
                    IdCiudadano = ciudadano.CiudadanoId.ToString(),
                    IdEjecucion = Guid.NewGuid()
                };

                if (hayDiferencias)
                {
                    message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                    {
                        Tabla = "CiudadanoInformacionLaboral",
                        Registro = new RegistroDto
                        {
                            Id = ciudadano.Id.ToString(),
                            Proceso = "Actualizacion"
                        }
                    });

                }

                if (ciudadano.ConocimientoCompetenciaInformacionLaboral.Any() && infoAntes.ConocimientoCompetenciaInformacionLaboral.Any())
                {
                    foreach (var item in ciudadano.ConocimientoCompetenciaInformacionLaboral)
                    {
                        var existeEnInfoAntes = infoAntes.ConocimientoCompetenciaInformacionLaboral
                            .Any(x => x.ConocimientoId == item.ConocimientoId);

                        if (!existeEnInfoAntes)
                        {
                            message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                            {
                                Tabla = "CiudadanoConocimientoCompetenciaInformacionLaboral",
                                Registro = new RegistroDto
                                {
                                    Id = item.Id.ToString(),
                                    Proceso = "Actualizacion"
                                }
                            });
                        }
                    }
                }

                if (ciudadano.HabilidadDestrezaInformacionLaboral.Any() && infoAntes.HabilidadDestrezaInformacionLaboral.Any())
                {
                    foreach (var item in ciudadano.HabilidadDestrezaInformacionLaboral)
                    {
                        var existeEnInfoAntes = infoAntes.HabilidadDestrezaInformacionLaboral
                            .Any(x => x.HabilidadId == item.HabilidadId);

                        if (!existeEnInfoAntes)
                        {
                            message.ExternalRequestBodyDto.Add(new ExternalRequestBodyDto
                            {
                                Tabla = "CiudadanoHabilidadDestrezaInformacionLaboral",
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
