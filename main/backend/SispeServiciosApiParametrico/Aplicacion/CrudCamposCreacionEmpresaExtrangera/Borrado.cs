using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCamposCreacionEmpresaExtrangera
{
    public class Borrado
    {
        public class Ejecuta : IRequest
        {
            public string Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly Contexto _contexto;

            public Manejador(Contexto contexto)
            {
                _contexto = contexto;
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CamposCreacionEmpresaExtrangera.FindAsync(Int32.Parse(request.Id));
                if (info is not null)
                {
                    _contexto.CamposCreacionEmpresaExtrangera.Remove(info);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("Error al deshabilitar");
                }
                throw new Exception("No existe Informacion.");
            }
        }
    }
}
