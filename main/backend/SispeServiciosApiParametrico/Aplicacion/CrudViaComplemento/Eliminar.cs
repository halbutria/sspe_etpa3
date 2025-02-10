using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServiciosApiParametrico.Aplicacion.CrudViaComplemento
{
    public class Eliminar
    {
        public class Ejecuta : IRequest
        {
            public string Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var viaComplemento = await _contexto.ViaComplemento.FindAsync(Guid.Parse(request.Id));
                if (viaComplemento is not null)
                {
                    _contexto.ViaComplemento.Remove(viaComplemento);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("Error al deshabilitar la via complemento");
                }
                throw new Exception("No existe Informacion para eliminar.");
            }
        }
    }
}
