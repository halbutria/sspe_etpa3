using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRol
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
                var moduloRol = await _contexto.ModuloRol.FindAsync(Guid.Parse(request.Id));
                if (moduloRol is not null)
                {
                    _contexto.ModuloRol.Remove(moduloRol);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("Error al deshabilitar el modulo por rol");
                }
                throw new Exception("No existe Informacion para eliminar.");
            }
        }
    }
}
