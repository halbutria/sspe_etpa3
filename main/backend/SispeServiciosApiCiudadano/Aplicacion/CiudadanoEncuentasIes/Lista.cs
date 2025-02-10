using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoEncuentasIes
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<CiudadanoEncuentasIesDTO>>
        {
            public Guid CiudadanoId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<CiudadanoEncuentasIesDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<CiudadanoEncuentasIesDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var litaCiudadanoEncuentasIes = await _contexto.CiudadanoEncuentasIes.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();
                
                if (litaCiudadanoEncuentasIes is not null)
                {
                    return _mapper.Map<List<CiudadanoEncuentasIesModel>, List<CiudadanoEncuentasIesDTO>>(litaCiudadanoEncuentasIes);
                }
                throw new Exception("No existe Información.");
            }

        }
    }
}
