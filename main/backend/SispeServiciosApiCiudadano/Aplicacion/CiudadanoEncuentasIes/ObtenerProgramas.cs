using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoEncuentasIes
{
    public class ObtenerProgramas
    {
        public class Ejecuta : IRequest<List<string>>
        {
        }

        public class Manejador : IRequestHandler<Ejecuta, List<string>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<string>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var listaProgramas = await _contexto.CiudadanoEncuentasIes.Where(x => !string.IsNullOrWhiteSpace(x.Programa)).Select(s => s.Programa).Distinct().ToListAsync();

                if (listaProgramas is not null)
                {
                    return listaProgramas;
                }
                throw new Exception("No existe Información.");
            }

        }
    }
}
