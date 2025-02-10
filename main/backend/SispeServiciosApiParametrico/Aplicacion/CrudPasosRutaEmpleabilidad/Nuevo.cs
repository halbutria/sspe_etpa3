using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudPasosRutaEmpleabilidad
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Nombre { get; set; }
            public string? Descripcion { get; set; }
            public List<string> Direccionamientos { get; set; }
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

                var encuesta = new PasosRutaEmpleabilidad
                {
                    Nombre = request.Nombre,
                    Descripcion = request.Descripcion,
                    Direccionamientos = request.Direccionamientos.Select(p => new Direccionamiento { Nombre = p }).ToList()
                };

                _contexto.PasosRutaEmpleabilidad.Add(encuesta);

                var respuesta = await _contexto.SaveChangesAsync(cancellationToken);

                if (respuesta > 0)
                {
                    return _mapper.Map<PasosRutaEmpleabilidad, ParametricoDTO>(encuesta);
                }
                throw new Exception("Error al guardar el paso de ruta de empleabilidad");
            }
        }
    }
}
