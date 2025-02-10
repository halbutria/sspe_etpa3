using Newtonsoft.Json;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteModel;
using System.Text;

namespace SispeServicios.Api.Ciudadano.RemoteService
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly ILogger<UsuarioService> _logger;

        public UsuarioService(IHttpClientFactory httpClient, ILogger<UsuarioService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<(bool resultado, UsuarioRemoteOutput? usuario, string? errorMesaje)> ActualizarUsuario(UsuarioRemote usuario)
        {
            try
            {
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(usuario), Encoding.UTF8, "application/json");
                var cliente = _httpClient.CreateClient("Usuarios");
                var response = await cliente.PutAsync("/security/Person/v1?Id=" + usuario.Id.ToString(), httpContent);
                var contenido = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    //var resultado = JsonConvert.DeserializeObject<UsuarioRemoteOutput>(contenido);
                    var resultado = (contenido == "true") ? true : false;
                    return (resultado, new UsuarioRemoteOutput(), null);
                }
                var resultadoError = JsonConvert.DeserializeObject<Error>(contenido);
                return (false, null, resultadoError.error);
            }
            catch (Exception e)
            {
                _logger?.LogError(e.ToString());
                return (false, null, e.Message);
            }
        }

        public async Task<(bool resultado, UsuarioRemoteOutput? usuario, string? errorMesaje)> CrearUsuario(UsuarioRemote usuario)
        {
            try
            {
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(usuario), Encoding.UTF8, "application/json");
                var cliente = _httpClient.CreateClient("Usuarios");
                var response = await cliente.PostAsync("/security/Person/v1", httpContent);
                var contenido = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var resultado = JsonConvert.DeserializeObject<UsuarioRemoteOutput>(contenido);
                    return (true, resultado, null);
                }
                var resultadoError = JsonConvert.DeserializeObject<Error>(contenido);
                return (false, null, resultadoError.error);
            }
            catch (Exception e)
            {
                _logger?.LogError(e.ToString());
                return (false, null, e.Message);
            }
        }
    }
}