using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudRangoSalarial
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Nombre { get; set; }
            public int? ValorInicial { get; set; }
            public int? ValorFinal { get; set; }

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
                
                var info = new Modelo.RangoSalarial();
                //_mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.RangoSalarial));
                //var info = _mapper.Map<Ejecuta, Modelo.RangoSalarial>(request);
                info.Nombre = request.Nombre;
                info.ValorInicial = request.ValorInicial;
                info.ValorFinal = request.ValorFinal;

                _contexto.rangoSalarial.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.RangoSalarial, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el Experiencia");
            }
        }
    }
}
