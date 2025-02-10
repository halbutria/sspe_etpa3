using SispeServicios.Api.Usuario.DTOs;

namespace SispeServicios.Api.Usuario.Aplicacion.Token
{
    public interface IToken
    {
       RespuestaAuntenticacion CrearToken(string usuario);
    }
}
