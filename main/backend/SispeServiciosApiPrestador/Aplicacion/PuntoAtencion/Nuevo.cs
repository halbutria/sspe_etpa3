using AutoMapper;
using MediatR;
using SispeServicios.Api.Prestador.DTOs;
using SispeServicios.Api.Prestador.Modelo;
using SispeServicios.Api.Prestador.Persistencia;

namespace SispeServicios.Api.Prestador.Aplicacion.PuntoAtencion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<PuntoAtencionDTO>
        {
            public Guid PrestadorId { get; set; }
            public int DepartamentoId { get; set; }
            public int MunicipioId { get; set; }
            public int Numero { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public float Latitud { get; set; }
            public float Longitud { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, PuntoAtencionDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<PuntoAtencionDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var puntoAtencion = _mapper.Map<Ejecuta, PuntoAtencionModel>(request);
                _contexto.PuntoAtencion.Add(puntoAtencion);
                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<PuntoAtencionModel, PuntoAtencionDTO>(puntoAtencion);
                }
                throw new Exception("Error al gurdar el Punto de Atención");
            }
        }

    }
}
