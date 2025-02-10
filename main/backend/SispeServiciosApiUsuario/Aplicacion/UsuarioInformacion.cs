using MediatR;
using Microsoft.AspNetCore.Identity;
using SispeServicios.Api.Usuario.Aplicacion.Token;
using SispeServicios.Api.Usuario.DTOs;

namespace SispeServicios.Api.Usuario.Aplicacion
{
    public class UsuarioInformacion
    {
        public class Ejecuta : IRequest<UsuarioInfo>
        {
            public string? usuarioId { get; set; }
            public string? nombre { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, UsuarioInfo>
        {
            private readonly UserManager<IdentityUser> _userManager;
            public Manejador(UserManager<IdentityUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<UsuarioInfo> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                IdentityUser usuarioInfo = null;
                if(request.usuarioId != null)
                {
                    usuarioInfo = await _userManager.FindByIdAsync(request.usuarioId);
                }
                if (request.nombre != null)
                {
                    usuarioInfo = await _userManager.FindByNameAsync(request.nombre);
                }


                if (usuarioInfo is not null)
                {
                    return new UsuarioInfo
                    {
                        Id = new Guid(usuarioInfo.Id),
                        Email = usuarioInfo.Email,
                        UserName = usuarioInfo.UserName,
                    };
                }
                throw new Exception("Usuario no encontrado");
            }
        }
    }
}
