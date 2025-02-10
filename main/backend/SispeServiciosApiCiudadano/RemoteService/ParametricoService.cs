using Newtonsoft.Json;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteModel;

namespace SispeServicios.Api.Ciudadano.RemoteService
{
    public class ParametricoService : IParametricoService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly ILogger<UsuarioService> _logger;

        public ParametricoService(IHttpClientFactory httpClient, ILogger<UsuarioService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        public async Task<(bool resultado, ParametricoRemoteOutput? parametrico, string? errorMesaje)> ConsultaParametrico(ParametricoRemoteInput parametrico)
        {
            try
            {
                //https://localhost:8082/Parametrico/validar/Municipio?id=05002&departamentoId=05
                var url = $"Parametrico/validar/{parametrico.tipo}?id={parametrico.id}&departamentoId={parametrico.departamentoId}";
                var cliente = _httpClient.CreateClient("Parametricos");
                var response = await cliente.GetAsync(url);
                var contenido = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var resultado = JsonConvert.DeserializeObject<ParametricoRemoteOutput>(contenido);
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
