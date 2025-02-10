using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteModel;
using System.Net.Http;
using System.Text;

namespace SispeServicios.Api.Gateway.RemoteService
{
    public class ParametricoService: IParametricoService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly ILogger<ParametricoService> _logger;

        public ParametricoService(IHttpClientFactory httpClient, ILogger<ParametricoService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<(bool resultado, ParametricoConsultaOutputRemote? parametrico, string? errorMesaje)> ConsultarParametrico(ParametricoConsultaInputRemote parametrico)
        {
            try
            {


              //var esNulo = parametrico.GetType()
              //   .GetProperties() //get all properties on object
              //   .Select(pi => pi.GetValue(parametrico)) //get value for the property
              //   .Any(value => value != null);



                var cliente = _httpClient.CreateClient("Parametrico");
                var json = JsonConvert.SerializeObject(parametrico);
                var dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                var uri = QueryHelpers.AddQueryString("/Parametrico/consulta", dictionary);

                var response = await cliente.GetAsync(uri);

                var contenido = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var resultado = JsonConvert.DeserializeObject<ParametricoConsultaOutputRemote>(contenido);
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
