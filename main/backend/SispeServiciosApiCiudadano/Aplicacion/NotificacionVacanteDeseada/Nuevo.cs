using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteService;

namespace SispeServicios.Api.Ciudadano.Aplicacion.NotificacionVacanteDeseada
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<CiudadanoNotificacionVacanteDeseadaDto>
        {
            public Guid CiudadanoId { get; set; }
            public List<CiudadanoCriteriosNotificacionesPostDto> Criterios { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoNotificacionVacanteDeseadaDto>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<CiudadanoNotificacionVacanteDeseadaDto> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var idioma = _mapper.Map<Ejecuta, CiudadanoNotificacionVacanteDeseada>(request);
                _contexto.CiudadanoNotificacionVacanteDeseada.Add(idioma);
                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<CiudadanoNotificacionVacanteDeseada, CiudadanoNotificacionVacanteDeseadaDto>(idioma);
                }
                throw new Exception("Error al guardar la notificación de la vacante deseada.");
            }
        }

    }
}
