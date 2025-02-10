using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ConocimientoCompetencia
{
    public class Edicion
    {

        public class Ejecuta : IRequest<ConocimientoCompetenciaDTO>
        {
            public Guid Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public string? Nombre { get; set; }
            public string? ConocimientoId { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecuta, ConocimientoCompetenciaDTO>
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

            public async Task<ConocimientoCompetenciaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CiudadanoConocimientoCompetenciaModel info = new CiudadanoConocimientoCompetenciaModel();
                int respuesta = new int();

                // Validacion por conocimientoId
                if (request.ConocimientoId != "" && request.ConocimientoId is not null)
                {
                    var infoConocimiento = _contexto.CiudadanoConocimientoCompetencia
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.ConocimientoId == request.ConocimientoId && x.Id != request.Id)
                       .FirstOrDefault();

                    if (infoConocimiento is null)
                    {
                        info = await _contexto.CiudadanoConocimientoCompetencia.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                        if (info is not null)
                        {
                            var infoAntes = Cloner.DeepClone(info);
                            info.CiudadanoId = request.CiudadanoId;
                            info.ConocimientoId = request.ConocimientoId;
                            info.Nombre = request.Nombre;
                            respuesta = await _contexto.SaveChangesAsync();

                            if (respuesta > 0)
                            {
                                RaiseEventItIsSuccess(info, infoAntes);
                                return _mapper.Map<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>(info);
                            }
                            throw new Exception("Error al editar");
                        }
                        throw new Exception("No existe Informacion a editar.");

                    }
                    throw new Exception("Conocimiento ya registrado para el ciudadano.");

                }
                // Validacion por nombre
                if (request.Nombre != "" && request.Nombre is not null)
                {
                    var infoConocimiento = _contexto.CiudadanoConocimientoCompetencia
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.Nombre == request.Nombre && x.Id != request.Id)
                       .FirstOrDefault();

                    if (infoConocimiento is null)
                    {
                        info = await _contexto.CiudadanoConocimientoCompetencia.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                        if (info is not null)
                        {
                            var infoAntes = Cloner.DeepClone(info);
                            info.CiudadanoId = request.CiudadanoId;
                            info.ConocimientoId = request.ConocimientoId;
                            info.Nombre = request.Nombre;
                            respuesta = await _contexto.SaveChangesAsync();

                            //if (respuesta > 0)
                            //{
                            RaiseEventItIsSuccess(info, infoAntes);
                            return _mapper.Map<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>(info);
                            //}
                            //throw new Exception("Error al editar");
                        }
                        throw new Exception("No existe Informacion a editar.");
                    }
                    throw new Exception("Conocimiento ya registrado para el ciudadano.");

                }

                info = await _contexto.CiudadanoConocimientoCompetencia.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    var infoAntes = Cloner.DeepClone(info);
                    info.CiudadanoId = request.CiudadanoId;
                    info.ConocimientoId = request.ConocimientoId;
                    info.Nombre = request.Nombre;

                    respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        RaiseEventItIsSuccess(info, infoAntes);
                        return _mapper.Map<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>(info);
                    }

                    throw new Exception("Error al editar");
                }
                throw new Exception("No existe Informacion a editar.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoConocimientoCompetenciaModel ciudadano, CiudadanoConocimientoCompetenciaModel infoAntes)
            {
                bool hayDiferencias = ciudadano.CiudadanoId != infoAntes.CiudadanoId
                        || ciudadano.Nombre != infoAntes.Nombre
                        || ciudadano.ConocimientoId != infoAntes.ConocimientoId;

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
                            Tabla = "CiudadanoConocimientoCompetencia",
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
