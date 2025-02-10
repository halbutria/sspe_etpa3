using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudRecepcionNotificaciones
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string? Descripcion { get; set; }
            public List<NotificacionesUpdDTO> Notificaciones { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var info = await _contexto.RecepcionNotificaciones.FindAsync(Int32.Parse(request.Id));
                var info = await _contexto.RecepcionNotificaciones
                            .Include(e => e.Notificaciones)
                            .FirstOrDefaultAsync(e => e.Id == Int32.Parse(request.Id), cancellationToken);

                if (info is not null)
                {
                    try
                    {
                        info.Nombre = request.Nombre;
                        info.Descripcion = request.Descripcion;

                        _contexto.RecepcionNotificaciones.Update(info);
                        var rmNotifications = info.Notificaciones.Where(e => !request.Notificaciones.Select(p => p.Id).Contains(e.Id)).ToList();
                        _contexto.Notificaciones.RemoveRange(rmNotifications);

                        var updNotifications = info.Notificaciones.Where(e => request.Notificaciones.Select(p => p.Id).Contains(e.Id)).ToList();
                        foreach (var notification in updNotifications) {
                            notification.Nombre = request.Notificaciones.FirstOrDefault(e => e.Id == notification.Id).Nombre;
                            notification.Estado = request.Notificaciones.FirstOrDefault(e => e.Id == notification.Id).Estado;
                        }
                        _contexto.Notificaciones.UpdateRange(updNotifications);

                        var newNotificationsDto = request.Notificaciones.Where(e => e.Id == 0).ToList();
                        var newNotifications = _mapper.Map<List<Notificaciones>>(newNotificationsDto);
                        foreach (var notification in newNotifications) {
                            notification.Id = 0;
                            notification.RecepcionNotificacionesId = info.Id;
                        }
                        _contexto.Notificaciones.AddRange(newNotifications);

                        await _contexto.SaveChangesAsync();

                        info.Notificaciones = info.Notificaciones.Where(e => e.Eliminado == false).ToList();
                        return _mapper.Map<Modelo.RecepcionNotificaciones, ParametricoDTO>(info);
                    }
                    catch (Exception ex)
                    {
                        var innerException = ex.InnerException?.Message ?? ex.Message;
                        throw new Exception($"Ocurrió un error al guardar los cambios en la entidad: {innerException}", ex);
                    }

                }
                throw new Exception("No existe Informacion a editar.");
            }
        }
    }
}
