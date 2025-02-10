using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.CrudViaComplemento
{
    public class Ingresar
    {
        public class Ejecuta : IRequest<ViaComplementoDTO>
        {
            public string? Id { get; set; }
            public string? Nombre { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ViaComplementoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ViaComplementoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var viaComplemento = new Modelo.ViaComplementoModel();

                if (request is not null)
                {
                    viaComplemento.Id = Guid.Parse(request.Id);
                    viaComplemento.Nombre = request.Nombre;
                    _contexto.ViaComplemento.Add(viaComplemento);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.ViaComplementoModel, ViaComplementoDTO>(viaComplemento);
                    }
                }
                throw new Exception("Error al registrar la via complemento");
            }
        }
    }
}
