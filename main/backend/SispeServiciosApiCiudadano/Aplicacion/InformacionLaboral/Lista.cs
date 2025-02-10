using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.InformacionLaboral
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<InformacionLaboralDTO>>
        {
            public Guid CiudadanoId { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, List<InformacionLaboralDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<InformacionLaboralDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoInformacionLaboral
                    .Include(i => i.ConocimientoCompetenciaInformacionLaboral)
                    .Include(i => i.HabilidadDestrezaInformacionLaboral)
                    .Where(x => x.CiudadanoId == request.CiudadanoId)
                    .ToListAsync();

                if (info.Count()> 0)
                {
                    return _mapper.Map<List<CiudadanoInformacionLaboralModel>, List<InformacionLaboralDTO>>(info);
                }
                throw new Exception("No existe Informacion.");
            }
        }
    }
}

