using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.EducacionNoFormal
{
    public class Edicion
    {
        public class Ejecuta : IRequest
        {
            public Guid Id { get; set; }
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
                var info = await _contexto.CiudadanoEducacionNoFormal.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    var infoAntes = Cloner.DeepClone(info);
                    info.TipoCertificadoCapacitacionId = request.TipoCertificadoCapacitacionId;
                    info.NombrePrograma = request.NombrePrograma;
                    info.Institucion = request.Institucion;
                    info.PaisId = (int)request.PaisId;
                    info.EstadoId = request.EstadoId;
                    info.Duracion = request.Duracion;
                    info.FechaCertificacion = request.FechaCertificacion;
                    var respuesta = await _contexto.SaveChangesAsync();
                    //if (respuesta > 0)
                    //{
                    RaiseEventItIsSuccess(info, infoAntes);
                    return Unit.Value;//_mapper.Map<CiudadanoEducacionNoFormalModel, EducacionNoFormalDTO>(info);
                    //}
                    //throw new Exception("Sin cambio.");
                }
                throw new Exception("No existe Informacion a editar.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoEducacionNoFormalModel ciudadano, CiudadanoEducacionNoFormalModel infoAntes)
            {
                bool hayDiferencias = ciudadano.TipoCertificadoCapacitacionId != infoAntes.TipoCertificadoCapacitacionId
                          || ciudadano.NombrePrograma != infoAntes.NombrePrograma
                          || ciudadano.Institucion != infoAntes.Institucion
                          || ciudadano.PaisId != infoAntes.PaisId
                          || ciudadano.EstadoId != infoAntes.EstadoId
                          || ciudadano.Duracion != infoAntes.Duracion
                          || ciudadano.FechaCertificacion != infoAntes.FechaCertificacion;

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
                            Tabla = "CiudadanoEducacionNoFormal",
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
