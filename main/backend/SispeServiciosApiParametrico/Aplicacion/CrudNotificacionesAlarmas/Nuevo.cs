using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudNotificacionesAlarmas
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int Grupo { get; set; }
            public string Nombre { get; set; }
            public int Tamanio { get; set; }
            public string? Descripcion { get; set; }
            public int EstadoNotificacion { get; set; }

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
                
                var info = new Modelo.NotificacionesAlarmas();
                info.Grupo = request.Grupo;
                info.Nombre = request.Nombre;
                info.Tamanio = request.Tamanio;
                info.Descripcion = request.Descripcion;
                info.EstadoNotificacion = request.EstadoNotificacion;

                _contexto.NotificacionesAlarmas.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.NotificacionesAlarmas, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar la notificaión y alarma");
            }
        }
    }
}
