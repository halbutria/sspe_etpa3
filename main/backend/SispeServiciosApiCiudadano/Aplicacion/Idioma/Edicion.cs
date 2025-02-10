using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.Helpers;
using SispeServiciosEventos.Queue.v1;
using Xphera.Library.Common.Entities.Interfaces.Events;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Idioma
{
    public class Edicion
    {

        public class Ejecuta : IRequest<IdiomaDTO>
        {
            public Guid Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public int IdiomaId { get; set; }
            public string NivelEscrito { get; set; }
            public string NivelHablado { get; set; }
            public string NivelEscucha { get; set; }
            public string NivelLectura { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecuta, IdiomaDTO>
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

            public async Task<IdiomaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoIdioma.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                var infoCiuIdio = await _contexto.CiudadanoIdioma
                    .Where(x => x.CiudadanoId == request.CiudadanoId && x.IdiomaId == request.IdiomaId && x.Id != request.Id)
                    .FirstOrDefaultAsync();

                if (infoCiuIdio is null)
                {

                    if (info is not null)
                    {
                        var infoAntes = Cloner.DeepClone(info);
                        info.CiudadanoId = request.CiudadanoId;
                        info.IdiomaId = request.IdiomaId;
                        info.NivelEscrito = request.NivelEscrito;
                        info.NivelHablado = request.NivelHablado;
                        info.NivelEscucha = request.NivelEscucha;
                        info.NivelLectura = request.NivelLectura;

                        var respuesta = await _contexto.SaveChangesAsync();
                        //if (respuesta > 0)
                        //{
                        RaiseEventItIsSuccess(info, infoAntes);
                        return _mapper.Map<CiudadanoIdiomaModel, IdiomaDTO>(info);
                        //}

                        //throw new Exception("Error al editar");
                    }
                    throw new Exception("No existe Informacion a editar.");
                }
                throw new Exception("Idioma ya registrado para el ciudadano.");
            }
            /// <summary>
            /// Raises the event it is success.
            /// </summary>
            /// <param name="contact">The contact.</param>
            private void RaiseEventItIsSuccess(CiudadanoIdiomaModel ciudadano, CiudadanoIdiomaModel infoAntes)
            {
                bool hayDiferencias = ciudadano.IdiomaId != infoAntes.IdiomaId
                        || ciudadano.NivelEscrito != infoAntes.NivelEscrito
                        || ciudadano.NivelHablado != infoAntes.NivelHablado
                        || ciudadano.NivelEscucha != infoAntes.NivelEscucha
                        || ciudadano.NivelLectura != infoAntes.NivelLectura;

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
                            Tabla = "CiudadanoIdioma",
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
