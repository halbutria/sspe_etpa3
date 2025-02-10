using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRolFuncionalidad
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
                var moduloRolFuncionalidad = await _contexto.ModuloRolFuncionalidad.FindAsync(Guid.Parse(request.Id));
                if (moduloRolFuncionalidad is not null)
                {
                    _contexto.ModuloRolFuncionalidad.Remove(moduloRolFuncionalidad);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("Error al deshabilitar el modulo por rol y funcionalidad");
                }
                throw new Exception("No existe Informacion para eliminar.");
            }
        }
    }
}
