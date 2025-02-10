using AutoMapper;
using MediatR;
using SispeServicios.Api.Prestador.DTOs;
using SispeServicios.Api.Prestador.Modelo;
using SispeServicios.Api.Prestador.Persistencia;

namespace SispeServicios.Api.Prestador.Aplicacion.Prestador
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<PrestadorDTO>
        {
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public int DepartamentoId { get; set; }
            public bool CoberturaNacional { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, PrestadorDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<PrestadorDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var prestador = _mapper.Map<Ejecuta, PrestadorModel>(request);
                _contexto.Prestador.Add(prestador);
                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<PrestadorModel, PrestadorDTO>(prestador);
                }
                throw new Exception("Error al gurdar el Prestador");
            }
        }

    }
}
