using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.Rol
{
    public class Modificar
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
                    var rol = await _contexto.Rol.FindAsync(Guid.Parse(request.Id));

                    if (rol is not null)
                    {
                        rol.Descripcion = request.Descripcion;
                        _contexto.Rol.Update(rol);
                        await _contexto.SaveChangesAsync();
                        return _mapper.Map<Modelo.RolModel, RolDTO>(rol);
                    }
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }
    }
}
