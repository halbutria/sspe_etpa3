using Microsoft.IdentityModel.Tokens;
using SispeServicios.Api.Usuario.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SispeServicios.Api.Usuario.Aplicacion.Token
{
    public class Token: IToken
    {
        private readonly IConfiguration _configuration;

        public Token(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public RespuestaAuntenticacion CrearToken(string usuario)
        {
            var claims = new List<Claim>()
            {
                new Claim("usuario",usuario)
            };

            var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["llavejwt"]));
            var creds = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);
            var expiracion = DateTime.UtcNow.AddDays(1);
            var tokenSeguridad = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiracion, signingCredentials: creds);
            return new RespuestaAuntenticacion()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(tokenSeguridad),
                Expiracion = expiracion
            };
        }
    }
}