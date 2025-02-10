using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosBasicos
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ServiciosBasicosDTO>
        {
            public Guid CiudadanoId { get; set; }
            public int ServiciosBasicosId { get; set; }
            public string CodigoServiciosBasicos { get; set; } = string.Empty;
            public string NombreServiciosBasicos { get; set; } = string.Empty;
            public int BrechaServiciosBasicosId { get; set; }
            public string CodigoBrechaServiciosBasicos { get; set; } = string.Empty;
            public string NombreBrechaServiciosBasicos { get; set; } = string.Empty;
            public DateTime? FechaInicio { get; set; }
            public DateTime? FechaFin { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ServiciosBasicosDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ServiciosBasicosDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoServiciosBasicosBrecha
                    .Where(x =>
                        x.CiudadanoId == request.CiudadanoId &&
                        x.ServiciosBasicosId == request.ServiciosBasicosId &&
                        x.BrechaServiciosBasicosId == request.BrechaServiciosBasicosId
                    ).FirstOrDefaultAsync();
                if (info is null)
                {
                    var red = _mapper.Map<Ejecuta, CiudadanoServiciosBasicosBrechaModel>(request);
                    _contexto.CiudadanoServiciosBasicosBrecha.Add(red);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<CiudadanoServiciosBasicosBrechaModel, ServiciosBasicosDTO>(red);
                    }
                    throw new Exception("Error al gurdar el servicio basico del ciudadano.");
                }
                throw new Exception("Servicio basico ya registrada para el ciudadano.");
            }
        }

    }
}
