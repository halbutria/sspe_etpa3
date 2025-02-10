using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudConfiguracionAvanceHojaVida
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Tipo { get; set; }
            public decimal Avance { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private ContextoCiudadano _contexto;
            private IMapper _mapper;

            public Manejador(ContextoCiudadano contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                
                var info = new Modelo.ConfiguracionAvanceHojaVida();
                //_mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.ConfiguracionAvanceHojaVida));
                //var info = _mapper.Map<Ejecuta, Modelo.ConfiguracionAvanceHojaVida>(request);
                info.Tipo = request.Tipo;
                info.Avance = request.Avance;

                _contexto.configuracionAvanceHojaVida.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.ConfiguracionAvanceHojaVida, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el Experiencia");
            }
        }
    }
}
