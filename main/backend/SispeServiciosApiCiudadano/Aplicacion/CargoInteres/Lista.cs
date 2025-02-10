using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CargoInteres
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<ParametricoIntDTO>>
        {
            public Guid CiudadanoId { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, List<ParametricoIntDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<ParametricoIntDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.Ciudadano.Include(i=>i.CargoInteres).Where(x => x.Id == request.CiudadanoId).FirstOrDefaultAsync();
                if (info is not null)
                {          
                    return _mapper.Map<List<CiudadanoCargoInteresModel>, List<ParametricoIntDTO>>(info?.CargoInteres?.ToList());
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
