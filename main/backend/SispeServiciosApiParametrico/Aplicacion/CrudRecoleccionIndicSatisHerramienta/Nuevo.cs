using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudRecoleccionIndicSatisHerramienta
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Usuario { get; set; }
            public List<RecoleccionEncuestas> Respuestas { get; set; }
            public string? Observaciones { get; set; }
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
                var info = new RecoleccionIndicSatisHerramienta();
                info.Usuario = request.Usuario;
                info.Observaciones = request.Observaciones;
                info.Respuestas = request.Respuestas.Select(p => new RespuestasSatisfaccionHerramienta
                {
                    IdPregunta = p.IdPregunta,
                    Pregunta = p.Pregunta,
                    Respuesta = p.Respuesta != null && p.Respuesta.Any() ? String.Join("", p.Respuesta.Select(o => $"[{o}]")) : ""
                }).ToList();

                _contexto.RecoleccionIndicSatisHerramienta.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    var outPut = _mapper.Map<RecoleccionIndicSatisHerramienta, ParametricoDTO>(info);
                    return outPut;
                }
                throw new Exception("Error al guardar el la encuesta de satisfacción en el manejo de la herramienta");
            }
        }
    }
}
