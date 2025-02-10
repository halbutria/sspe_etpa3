using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudInstitucionNivelEducativo
{
    public class ObtenerInstitucionesPorNivelEducativo
    {
        public class Ejecuta : IRequest<List<ParametricoDTO>>
        {
            public string? NivelEducativoId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<ParametricoDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<ParametricoDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                // Obtener las instituciones para el NivelEducativoId especificado
                var instituciones = await _contexto.institucionNivelEducativo
                    .Where(x => x.NivelEducativoId == Int32.Parse(request.NivelEducativoId))
                    .Select(x => x.Institucion)
                    .ToListAsync();

                var institucionesDTO = _mapper.Map<List<Modelo.Institucion>, List<ParametricoDTO>>(instituciones);

                return institucionesDTO;
            }
        }
    }
}
