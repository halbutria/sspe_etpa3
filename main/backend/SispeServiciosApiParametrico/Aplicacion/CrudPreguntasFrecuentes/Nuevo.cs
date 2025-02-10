using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudPreguntasFrecuentes
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Pregunta { get; set; }
            public bool Estado { get; set; }
            public string Respuesta { get; set; }
            public string? Descripcion { get; set; }
            public Guid ModuloId { get; set; }

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

                var info = new Modelo.PreguntasFrecuentes();
                info.Pregunta = request.Pregunta;
                info.Estado = request.Estado;
                info.Respuesta = request.Respuesta;
                info.ModuloId = request.ModuloId;
                info.Descripcion = request.Descripcion;

                _contexto.PreguntasFrecuentes.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    var outPut = await _contexto.PreguntasFrecuentes
                            .Include(m => m.Modulo)
                            .FirstOrDefaultAsync(e => e.Id == info.Id, cancellationToken);
                    var dto = _mapper.Map<Modelo.PreguntasFrecuentes, ParametricoDTO>(outPut);
                    return dto;
                }
                throw new Exception("Error al guardar pregunta frecuente");
            }
        }
    }
}
