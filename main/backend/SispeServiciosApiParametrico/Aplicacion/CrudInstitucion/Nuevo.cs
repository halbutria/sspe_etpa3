using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudInstitucion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Nombre { get; set; }
            public int NivelEducativoId { get; set; } // Se recibe para la primera asociación

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
                var info = new Modelo.Institucion();
                var institucionNivelEducativo = new Modelo.InstitucionNivelEducativo();
                //_mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.Institucion));
                //var info = _mapper.Map<Ejecuta, Modelo.Institucion>(request);
                info.Nombre = request.Nombre;

                _contexto.institucion.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                institucionNivelEducativo.InstitucionId = info.Id;
                institucionNivelEducativo.NivelEducativoId = request.NivelEducativoId;

                _contexto.institucionNivelEducativo.Add(institucionNivelEducativo);

                await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.Institucion, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el Experiencia");
            }
        }
    }
}
