using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.EducacionFormal;

public class Lista
{
    public class Ejecuta : IRequest<List<EducacionFormalDTO>>
    {
        public Guid CiudadanoId { get; set; }
        public bool? Graduado { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<EducacionFormalDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<EducacionFormalDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            List<CiudadanoEducacionFormalModel> info = new List<CiudadanoEducacionFormalModel>();

            if (request?.Graduado == true) info = await _contexto.CiudadanoEducacionFormal.Where(x => x.CiudadanoId == request.CiudadanoId && x.EstadoId == 3 ).ToListAsync();
            else info = await _contexto.CiudadanoEducacionFormal.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();

            if (info.Count() > 0)
            {
                return _mapper.Map<List<CiudadanoEducacionFormalModel>, List<EducacionFormalDTO>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

