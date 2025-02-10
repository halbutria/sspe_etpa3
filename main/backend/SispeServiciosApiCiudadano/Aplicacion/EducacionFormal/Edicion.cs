using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.EducacionFormal
{
    public class Edicion
    {

        public class Ejecuta : IRequest
        {

            public Guid Id { get; set; }
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
            public bool? PracticaEmpresarial { get; set; }

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
                var info = await _contexto.CiudadanoEducacionFormal.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    var infoAntes = Cloner.DeepClone(info);

                    info.NucleoConocimientoId = request.NucleoConocimientoId;
                    info.NivelEducativoId = request.NivelEducativoId;
                    info.AreaConocimientoId = request.AreaConocimientoId;
                    info.TituloObtenido = request.TituloObtenido;
                    info.TituloHomologadoId = request.TituloHomologadoId;
                    info.Institucion = request.Institucion;
                    info.InstitucionId = request.InstitucionId;
                    info.PaisId = request.PaisId;
                    info.EstadoId = request.EstadoId;
                    info.FechaFinalizacion = request.FechaFinalizacion;
                    info.TarjetaProfesional = request.TarjetaProfesional;
                    info.NumeroTarjetaProfesional = request.NumeroTarjetaProfesional;
                    info.FechaExpedicionTarjetaProfesional = request.FechaExpedicionTarjetaProfesional;
                    info.Observacion = request.Observacion;
                    info.PracticaEmpresarial = (bool)request.PracticaEmpresarial;

                    var respuesta = await _contexto.SaveChangesAsync();
                    RaiseEventItIsSuccess(info, infoAntes);
                    //if (respuesta > 0)
                    //{
                    return Unit.Value;//_mapper.Map<CiudadanoEducacionFormal, EducacionFormalDTO>(info);
                    //}

                    //throw new Exception("Error al editar");
                }
                throw new Exception("No existe Informacion a editar.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoEducacionFormalModel ciudadano, CiudadanoEducacionFormalModel infoAntes)
            {
                bool hayDiferencias = ciudadano.NucleoConocimientoId != infoAntes.NucleoConocimientoId
                          || ciudadano.NivelEducativoId != infoAntes.NivelEducativoId
                          || ciudadano.AreaConocimientoId != infoAntes.AreaConocimientoId
                          || ciudadano.TituloObtenido != infoAntes.TituloObtenido
                          || ciudadano.TituloHomologadoId != infoAntes.TituloHomologadoId
                          || ciudadano.Institucion != infoAntes.Institucion
                          || ciudadano.InstitucionId != infoAntes.InstitucionId
                          || ciudadano.PaisId != infoAntes.PaisId
                          || ciudadano.EstadoId != infoAntes.EstadoId
                          || ciudadano.FechaFinalizacion != infoAntes.FechaFinalizacion
                          || ciudadano.TarjetaProfesional != infoAntes.TarjetaProfesional
                          || ciudadano.NumeroTarjetaProfesional != infoAntes.NumeroTarjetaProfesional
                          || ciudadano.FechaExpedicionTarjetaProfesional != infoAntes.FechaExpedicionTarjetaProfesional
                          || ciudadano.Observacion != infoAntes.Observacion
                          || ciudadano.PracticaEmpresarial != infoAntes.PracticaEmpresarial;

                if (hayDiferencias)
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
                                Proceso = "Actualizacion"
                            }
                        }
                    }
                    };
                    SendQueueEventHub.Raise(message);
                }
            }
        }

    }
}
