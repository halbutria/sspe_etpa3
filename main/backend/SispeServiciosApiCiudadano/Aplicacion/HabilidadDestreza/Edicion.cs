using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.HabilidadDestreza
{
    public class Edicion
    {

        public class Ejecuta : IRequest<HabilidadDestrezaDTO>
        {
            public Guid Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public string? HabilidadId { get; set; }
            public string? Nombre { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecuta, HabilidadDestrezaDTO>
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

            public async Task<HabilidadDestrezaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CiudadanoHabilidadDestrezaModel info = new CiudadanoHabilidadDestrezaModel();
                int respuesta = new int();

                // Validacion por habilidadId
                if (request.HabilidadId != "" && request.HabilidadId is not null)
                {
                    var infoHabilidad = _contexto.CiudadanoHabilidadDestreza
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.HabilidadId == request.HabilidadId && x.Id != request.Id)
                       .FirstOrDefault();

                    if (infoHabilidad is null)
                    {
                        info = await _contexto.CiudadanoHabilidadDestreza.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                        if (info is not null)
                        {
                            var infoAntes = Cloner.DeepClone(info);
                            info.CiudadanoId = request.CiudadanoId;
                            info.HabilidadId = request.HabilidadId;
                            info.Nombre = request.Nombre;

                            respuesta = await _contexto.SaveChangesAsync();
                            if (respuesta > 0)
                            {
                                RaiseEventItIsSuccess(info, infoAntes);
                                return _mapper.Map<CiudadanoHabilidadDestrezaModel, HabilidadDestrezaDTO>(info);
                            }

                            throw new Exception("Error al editar");
                        }
                        throw new Exception("No existe Informacion.");
                    }
                    throw new Exception("Habilidad o Destreza ya registrada para el ciudadano.");

                }
                // Validacion por nombre
                if (request.Nombre != "" && request.Nombre is not null)
                {
                    var infoHabilidad = _contexto.CiudadanoHabilidadDestreza
                       .Where(x => x.CiudadanoId == request.CiudadanoId && x.Nombre == request.Nombre && x.Id != request.Id)
                       .FirstOrDefault();

                    if (infoHabilidad is null)
                    {
                        info = await _contexto.CiudadanoHabilidadDestreza.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                        if (info is not null)
                        {
                            var infoAntes = Cloner.DeepClone(info);
                            info.CiudadanoId = request.CiudadanoId;
                            info.HabilidadId = request.HabilidadId;
                            info.Nombre = request.Nombre;

                            respuesta = await _contexto.SaveChangesAsync();
                            if (respuesta > 0)
                            {
                                RaiseEventItIsSuccess(info, infoAntes);
                                return _mapper.Map<CiudadanoHabilidadDestrezaModel, HabilidadDestrezaDTO>(info);
                            }

                            throw new Exception("Error al editar");
                        }
                        throw new Exception("No existe Informacion.");
                    }
                    throw new Exception("Habilidad o Destreza ya registrada para el ciudadano.");

                }
                // resultado normal

                info = await _contexto.CiudadanoHabilidadDestreza.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    var infoAntes = Cloner.DeepClone(info);
                    var ciudadanoAntes = Cloner.DeepClone(info);
                    info.CiudadanoId = request.CiudadanoId;
                    info.HabilidadId = request.HabilidadId;
                    info.Nombre = request.Nombre;

                    respuesta = await _contexto.SaveChangesAsync();
                    RaiseEventItIsSuccess(info, infoAntes);
                    //if (respuesta > 0)
                    //{
                    return _mapper.Map<CiudadanoHabilidadDestrezaModel, HabilidadDestrezaDTO>(info);
                    //}

                    //throw new Exception("Error al editar");
                }
                throw new Exception("No existe Informacion.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoHabilidadDestrezaModel ciudadano, CiudadanoHabilidadDestrezaModel infoHabilidad)
            {
                bool hayDiferencias = ciudadano.HabilidadId != infoHabilidad.HabilidadId ||
                      ciudadano.Nombre != infoHabilidad.Nombre;

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
                            Tabla = "CiudadanoHabilidadDestreza",
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
