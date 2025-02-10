using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServiciosApiParametrico.Aplicacion.Rol
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
                var rol = await _contexto.Rol.FindAsync(Guid.Parse(request.Id));
                if (rol is not null)
                {
                    _contexto.Rol.Remove(rol);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("Error al deshabilitar el rol");
                }
                throw new Exception("No existe Informacion para eliminar.");
            }
        }
    }
}
