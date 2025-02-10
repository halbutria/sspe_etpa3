using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCursoFortalecimiento
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public int? TipoCurso { get; set; }
            public string? Duracion { get; set; }
            public DateTime? FechaInicio { get; set; }
            public DateTime? FechaFinalizacion { get; set; }
            public string? Nombre { get; set; }
            public string? Descripcion { get; set; }
            public string? DescripcionComplementaria { get; set; }
            public bool? Estado { get; set; }

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
                var info = await _contexto.CursoFortalecimiento.FindAsync(Int32.Parse(request.Id));
                if (info is not null)
                {
                    return _mapper.Map<Modelo.CursoFortalecimiento, ParametricoDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
