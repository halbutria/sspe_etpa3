using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosAsociados
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ServiciosAsociadosDTO>
        {
            public Guid CiudadanoId { get; set; }
            public int ServiciosAsociadosId { get; set; }
            public string CodigoServiciosAsociados { get; set; } = string.Empty;
            public string NombreServiciosAsociados { get; set; } = string.Empty;
            public int BrechaServiciosAsociadosId { get; set; }
            public string CodigoBrechaServiciosAsociados { get; set; } = string.Empty;
            public string NombreBrechaServiciosAsociados { get; set; } = string.Empty;
            public DateTime? FechaInicio { get; set; }
            public DateTime? FechaFin { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ServiciosAsociadosDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ServiciosAsociadosDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoServiciosAsociados
                    .Where(x =>
                        x.CiudadanoId == request.CiudadanoId &&
                        x.ServiciosAsociadosId == request.ServiciosAsociadosId &&
                        x.BrechaServiciosAsociadosId == request.BrechaServiciosAsociadosId
                    ).FirstOrDefaultAsync();
                if (info is null)
                {
                    var red = _mapper.Map<Ejecuta, CiudadanoServiciosAsociadosModel>(request);
                    _contexto.CiudadanoServiciosAsociados.Add(red);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<CiudadanoServiciosAsociadosModel, ServiciosAsociadosDTO>(red);
                    }
                    throw new Exception("Error al gurdar el servicio asociado del ciudadano.");
                }
                throw new Exception("Servicio asociado ya registrada para el ciudadano.");
            }
        }

    }
}
