using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudPasosRutaEmpleabilidad
{
    public class Borrado
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
                var info = await _contexto.PasosRutaEmpleabilidad
                        .Include(e => e.Direccionamientos)
                        .FirstOrDefaultAsync(e => e.Id == Int32.Parse(request.Id), cancellationToken);
                if (info is not null)
                {
                    _contexto.PasosRutaEmpleabilidad.Remove(info);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("Error al eliminar");
                }
                throw new Exception("No existe Informacion.");
            }
        }
    }
}
