using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudIndicadorSatisfaccionManejoHerramienta
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Pregunta { get; set; }
            public string TipoPreguntasId { get; set; }
            public List<string> Opciones { get; set; }
            public string? Descripcion { get; set; }
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

                var info = new Modelo.IndicadorSatisfaccionManejoHerramienta();
                info.Pregunta = request.Pregunta;
                info.TipoPreguntasId = Convert.ToInt16(request.TipoPreguntasId);
                info.Descripcion = request.Descripcion;
                info.Opciones = request.Opciones != null && request.Opciones.Any() ? String.Join("", request.Opciones.Select(o => $"[{o}]")) : "";

                _contexto.IndicadorSatisfaccionManejoHerramienta.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.IndicadorSatisfaccionManejoHerramienta, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el indicador de satisfacción en el manejo de la herramienta");
            }
        }
    }
}
