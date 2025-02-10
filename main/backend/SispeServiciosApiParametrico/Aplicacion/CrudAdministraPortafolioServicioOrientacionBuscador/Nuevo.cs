using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudAdministraPortafolioServicioOrientacionBuscador
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Nombre { get; set; }
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
                
                var info = new Modelo.AdministraPortafolioServicioOrientacionBuscador();
                info.Nombre = request.Nombre;
                info.Descripcion = request.Descripcion;

                _contexto.AdministraPortafolioServicioOrientacionBuscador.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.AdministraPortafolioServicioOrientacionBuscador, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar la administración del portafolio de servicio de orientación ocupacional del buscador");
            }
        }
    }
}
