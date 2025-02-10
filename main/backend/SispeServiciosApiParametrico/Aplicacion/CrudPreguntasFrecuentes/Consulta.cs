using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudPreguntasFrecuentes
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public string? Pregunta { get; set; }
            public bool? Estado { get; set; }
            public string? Respuesta { get; set; }
            public string? Descripcion { get; set; }
            public ModuloModel? Modulos { get; set; }

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
                var info = await _contexto.PreguntasFrecuentes
                            .Include(m => m.Modulo)
                            .FirstOrDefaultAsync(e => e.Id == Int32.Parse(request.Id), cancellationToken);
                if (info is not null)
                {
                    return _mapper.Map<Modelo.PreguntasFrecuentes, ParametricoDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
