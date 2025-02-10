using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServiciosApiParametrico.Aplicacion.Modulo
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
                var modulo = await _contexto.Modulo.FindAsync(Guid.Parse(request.Id));
                if (modulo is not null)
                {
                    _contexto.Modulo.Remove(modulo);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("Error al deshabilitar el modulo");
                }
                throw new Exception("No existe Informacion para eliminar.");
            }
        }
    }
}
