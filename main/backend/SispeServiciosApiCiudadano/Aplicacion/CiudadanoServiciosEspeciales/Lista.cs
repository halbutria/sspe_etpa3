using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SispeServiciosApiCiudadano.DTOs;
using SispeServiciosApiCiudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoServiciosEspeciales
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<CiudadanoServiciosEspecialesDTO>>
        {
            public Guid CiudadanoId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<CiudadanoServiciosEspecialesDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<CiudadanoServiciosEspecialesDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var litaCiudadanoServiciosEspeciales = await _contexto.CiudadanoServiciosEspeciales.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();

                if (litaCiudadanoServiciosEspeciales is not null)
                {
                    return _mapper.Map<List<CiudadanoServiciosEspecialesModel>, List<CiudadanoServiciosEspecialesDTO>>(litaCiudadanoServiciosEspeciales);
                }
                throw new Exception("No existe Información.");
            }

        }
    }
}
