using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SispeServiciosApiCiudadano.DTOs;
using SispeServiciosApiCiudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoServiciosBasicos
{
    public class Lista
    {

        public class Ejecuta : IRequest<List<CiudadanoServiciosBasicosDTO>>
        {
            public Guid CiudadanoId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<CiudadanoServiciosBasicosDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<CiudadanoServiciosBasicosDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var litaCiudadanoServiciosBasicos = await _contexto.CiudadanoServiciosBasicos.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();

                if (litaCiudadanoServiciosBasicos is not null)
                {
                    return _mapper.Map<List<CiudadanoServiciosBasicosModel>, List<CiudadanoServiciosBasicosDTO>>(litaCiudadanoServiciosBasicos);
                }
                throw new Exception("No existe Información.");
            }

        }
    }
}
