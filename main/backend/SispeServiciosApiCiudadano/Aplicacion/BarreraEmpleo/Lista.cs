using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.BarreraEmpleo
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<BarreraEmpleoDTO>>
        {
            public Guid CiudadanoId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<BarreraEmpleoDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<BarreraEmpleoDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var listaBarrerasEmpleo = await _contexto.BarreraEmpleo.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();
                if (listaBarrerasEmpleo is not null)
                {
                    return _mapper.Map<List<BarreraEmpleoModel>, List<BarreraEmpleoDTO>>(listaBarrerasEmpleo);
                }
                throw new Exception("No existe Información.");
            }

        }
    }
}
