using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Direccion;
public class Lista
{
    public class Ejecuta : IRequest<List<DireccionDTO>>
    {
        public Guid CiudadanoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<DireccionDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<DireccionDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            //var info = await _contexto.CiudadanoDireccion.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();
            //if (info.Count() > 0)
            //{
            //    return _mapper.Map<List<CiudadanoDireccionModel>, List<DireccionDTO>>(info);
            //}
            throw new Exception("No existe Informacion.");
        }
    }
}

