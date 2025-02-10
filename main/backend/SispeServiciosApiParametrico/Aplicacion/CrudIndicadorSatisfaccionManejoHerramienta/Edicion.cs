using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudIndicadorSatisfaccionManejoHerramienta
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
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
                var info = await _contexto.IndicadorSatisfaccionManejoHerramienta.FindAsync(Int32.Parse(request.Id));

                if (info is not null)
                {
                    info.Opciones = (request.Opciones != null && request.Opciones.Count > 0) ? string.Join("", request.Opciones.Select(o => $"[{o}]")) : "";
                    info.TipoPreguntasId = Convert.ToInt16(request.TipoPreguntasId);
                    info.Pregunta = request.Pregunta;
                    info.Descripcion = request.Descripcion;

                    _contexto.IndicadorSatisfaccionManejoHerramienta.Update(info);

                    await _contexto.SaveChangesAsync();

                    return _mapper.Map<IndicadorSatisfaccionManejoHerramienta, ParametricoDTO>(info);
           
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}
