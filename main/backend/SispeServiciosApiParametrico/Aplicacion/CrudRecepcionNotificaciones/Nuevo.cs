using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;
using System.Linq.Expressions;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudRecepcionNotificaciones
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Nombre { get; set; }
            public string? Descripcion { get; set; }
            public List<NotificacionesDTO> Notificaciones { get; set; }
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

                //var info = new Modelo.RecepcionNotificaciones();
                //info.Nombre = request.Nombre;
                //info.Descripcion = request.Descripcion;
                //info.Notificaciones = request.Notificaciones;

                var info = new Modelo.RecepcionNotificaciones
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    Notificaciones = _mapper.Map<List<Notificaciones>>(request.Notificaciones) 
                };
                try
                {

                    _contexto.RecepcionNotificaciones.Add(info);

                    var respuesta = await _contexto.SaveChangesAsync(cancellationToken);
                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.RecepcionNotificaciones, ParametricoDTO>(info);
                    }
                    throw new Exception("Error al guardar recepción de notificación");
                }
                catch (DbUpdateException ex)
                {

                    var innerException = ex.InnerException?.Message ?? ex.Message;
                    throw new Exception($"Ocurrió un error al guardar los cambios en la entidad: {innerException}", ex);
                }
                

                
            }
        }
    }
}
