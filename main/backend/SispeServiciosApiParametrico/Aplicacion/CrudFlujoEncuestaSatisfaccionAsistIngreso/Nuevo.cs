using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudFlujoEncuestaSatisfaccionAsistIngreso
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Pregunta { get; set; }
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
                
                var info = new Modelo.FlujoEncuestaSatisfaccionAsistIngreso();
                info.Pregunta = request.Pregunta;
                info.Descripcion = request.Descripcion;

                _contexto.FlujoEncuestaSatisfaccionAsistIngresos.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.FlujoEncuestaSatisfaccionAsistIngreso, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el flujo de encuesta de satisfacción de aistencia de ingreso");
            }
        }
    }
}
