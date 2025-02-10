using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.Rol
{
    public class Consulta
    {
        public class Ejecuta : IRequest<RolDTO>
        {
            public string? Id { get; set; }
            public string? Descripcion { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, RolDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<RolDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                if (request is not null)
                {
                    var modulo = await _contexto.Rol.FindAsync(Guid.Parse(request.Id));
                    if (modulo is not null)
                    {
                        return _mapper.Map<Modelo.RolModel, RolDTO>(modulo);
                    }
                }

                throw new Exception("No existe Información.");
            }
        }
    }
}
