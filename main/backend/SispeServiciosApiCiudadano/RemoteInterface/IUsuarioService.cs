using SispeServicios.Api.Ciudadano.RemoteModel;

namespace SispeServicios.Api.Ciudadano.RemoteInterface
{
    public interface IUsuarioService
    {
      Task<(bool resultado, UsuarioRemoteOutput? usuario, string? errorMesaje)>  CrearUsuario(UsuarioRemote usuario);
      Task<(bool resultado, UsuarioRemoteOutput? usuario, string? errorMesaje)>  ActualizarUsuario(UsuarioRemote usuario);
    }
}
