using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudInstitucionNivelEducativo
{
    public class ObtenerNivelesEducativosPorInstitucion
    {
        public class Ejecuta : IRequest<List<ParametricoDTO>>
        {
            public string? InstitucionId { get; set; }
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
                // Obtener los Niveles Educativos para el InstitucionId especificado
                var nivelesEducativos = await _contexto.institucionNivelEducativo
                    .Where(x => x.InstitucionId == Int32.Parse(request.InstitucionId))
                    .Select(x => x.NivelEducativo)
                    .ToListAsync();

                var nivelesEducativosDTO = _mapper.Map<List<Modelo.NivelEducativo>, List<ParametricoDTO>>(nivelesEducativos);

                return nivelesEducativosDTO;
            }
        }
    }
}
