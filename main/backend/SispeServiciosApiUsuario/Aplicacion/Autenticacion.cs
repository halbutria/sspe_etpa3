using MediatR;
using Microsoft.AspNetCore.Identity;
using SispeServicios.Api.Usuario.Aplicacion.Token;
using SispeServicios.Api.Usuario.DTOs;

namespace SispeServicios.Api.Usuario.Aplicacion
{
    public class Autenticacion
    {
        public class Ejecuta : IRequest<RespuestaAuntenticacion>
        {
            public string usuario { get; set; }
            public string password { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, RespuestaAuntenticacion>
        {
            private readonly UserManager<IdentityUser> _userManager;
            private readonly SignInManager<IdentityUser> _signInManager;
            private readonly IToken _token;

            public Manejador(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager, IToken token)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _token = token;
            }

            public async Task<RespuestaAuntenticacion> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var resultado = await _signInManager.PasswordSignInAsync(request.usuario, request.password, isPersistent: false, lockoutOnFailure:false) ;
                if(resultado.Succeeded)
                {
                    return _token.CrearToken(request.usuario);
                }

                throw new Exception("Usuario o Contraseña Incorrecto");


            }
        }
    }
}
