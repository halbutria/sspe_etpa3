using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosOferta
{
    public class Borrado
    {
        public class Ejecuta : IRequest
        {
            public Guid Id { get; set; }
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
                var info = await _contexto.CiudadanoServiciosOferta.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    _contexto.CiudadanoServiciosOferta.Remove(info);
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