using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CursoFortalecimiento;

public class Lista
{
    public class Ejecuta : IRequest<List<CiudadanoCursoFortalecimientoRespDTO>>
    {
        public Guid CiudadanoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<CiudadanoCursoFortalecimientoRespDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<CiudadanoCursoFortalecimientoRespDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.CiudadanoCursoFortalecimiento.Where(x => x.CiudadanoId == request.CiudadanoId)
                //.Include(c => c.CursoFortalecimiento)
                .ToListAsync();
            if (info.Count() > 0)
            {
                return _mapper.Map<List<CiudadanoCursoFortalecimiento>, List<CiudadanoCursoFortalecimientoRespDTO>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

