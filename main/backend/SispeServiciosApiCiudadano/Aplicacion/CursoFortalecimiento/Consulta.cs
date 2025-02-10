using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CursoFortalecimiento
{
    public class Consulta
    {
        public class Ejecuta : IRequest<CiudadanoCursoFortalecimientoRespDTO>
        {
            public int Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, CiudadanoCursoFortalecimientoRespDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<CiudadanoCursoFortalecimientoRespDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoCursoFortalecimiento.Where(x => x.Id == request.Id)
                    //.Include(c => c.CursoFortalecimiento)
                    .FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<CiudadanoCursoFortalecimiento
                        , CiudadanoCursoFortalecimientoRespDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
