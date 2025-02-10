using MediatR;
using Microsoft.AspNetCore.Identity;
using SispeServicios.Api.Usuario.Aplicacion.Token;
using SispeServicios.Api.Usuario.DTOs;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Usuario.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<UsuarioInfo> {
            public string usuario { get; set; }
            public string password { get; set; }
            public string? email { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, UsuarioInfo>
        {
            private readonly UserManager<IdentityUser> _userManager;
            private readonly IToken _token;

            public Manejador(UserManager<IdentityUser> userManager, IToken token)
            {
                _userManager = userManager;
                _token = token;
            }
            public async Task<UsuarioInfo> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var usuario = new IdentityUser { UserName = request.usuario, Email = request.email };
                var password = request.password;
                var resultado = await _userManager.CreateAsync(usuario, password);
                if (resultado.Succeeded)
                {
                    var usuarioInfo = await _userManager.FindByNameAsync(request.usuario);

                    return new UsuarioInfo { 
                    Id = new Guid(usuarioInfo.Id),
                    Email = usuarioInfo.Email,
                    UserName = usuarioInfo.UserName,
                    };
                }


                var exceptions = new List<Exception>();

                foreach (IdentityError innerException in resultado.Errors)
                {
                    exceptions.Add(new ArgumentException(innerException.Description ));
                }
                throw new AggregateException(exceptions);
            }
        }
    }
}
