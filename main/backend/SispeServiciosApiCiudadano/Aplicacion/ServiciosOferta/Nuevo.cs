using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosOferta
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ServiciosOfertaDTO>
        {
            public Guid CiudadanoId { get; set; }
            public int ServiciosOfertaId { get; set; }
            public string CodigoServiciosOferta { get; set; } = string.Empty;
            public string NombreServiciosOferta { get; set; } = string.Empty;
            public int BrechaServiciosOfertaId { get; set; }
            public string CodigoBrechaServiciosOferta { get; set; } = string.Empty;
            public string NombreBrechaServiciosOferta { get; set; } = string.Empty;
            public DateTime? FechaInicio { get; set; }
            public DateTime? FechaFin { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ServiciosOfertaDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ServiciosOfertaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoServiciosOferta
                    .Where(x =>
                        x.CiudadanoId == request.CiudadanoId &&
                        x.ServiciosOfertaId == request.ServiciosOfertaId &&
                        x.BrechaServiciosOfertaId == request.BrechaServiciosOfertaId
                    ).FirstOrDefaultAsync();
                if (info is null)
                {
                    var red = _mapper.Map<Ejecuta, CiudadanoServiciosOfertaModel>(request);
                    _contexto.CiudadanoServiciosOferta.Add(red);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<CiudadanoServiciosOfertaModel, ServiciosOfertaDTO>(red);
                    }
                    throw new Exception("Error al gurdar el servicio oferta del ciudadano.");
                }
                throw new Exception("Servicio asociado ya registrada para el ciudadano.");
            }
        }

    }
}
