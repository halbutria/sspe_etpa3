using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;
using System.Linq;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudInstitucionNivelEducativo
{
    public class AsociarInstitucionNivelEducativo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string InstitucionId { get; set; }
            public string NivelEducativoId { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                // Verificar si la asociación ya existe en la base de datos
                var existeAsociacion = await _contexto.institucionNivelEducativo
                    .AnyAsync(x => x.InstitucionId == Int32.Parse(request.InstitucionId) && x.NivelEducativoId == Int32.Parse(request.NivelEducativoId));

                if (existeAsociacion)
                {
                    throw new Exception("La asociación ya existe.");
                }

                // Si no existe, crea la asociación
                var info = new Modelo.InstitucionNivelEducativo
                {
                    InstitucionId = Int32.Parse(request.InstitucionId),
                    NivelEducativoId = Int32.Parse(request.NivelEducativoId)
                };

                _contexto.institucionNivelEducativo.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.InstitucionNivelEducativo, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el Experiencia");
            }
        }
    }
}
