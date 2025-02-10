using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudInstitucionNivelEducativo
{
    public class EliminarAsociacionInstitucionNivelEducativo
    {
        public class Ejecuta : IRequest
        {
            public string? InstitucionId { get; set; }
            public string? NivelEducativoId { get; set; }
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
                var asociacion = await _contexto.institucionNivelEducativo
                    .FirstOrDefaultAsync(x => x.InstitucionId == Int32.Parse(request.InstitucionId) && x.NivelEducativoId == Int32.Parse(request.NivelEducativoId));

                if (asociacion == null)
                {
                    throw new Exception("No existe Información.");
                }

                _contexto.institucionNivelEducativo.Remove(asociacion);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("Error al eliminar la asociación");
            }
        }
    }
}