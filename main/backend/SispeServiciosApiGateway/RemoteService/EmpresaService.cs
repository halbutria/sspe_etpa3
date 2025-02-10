using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteModel;
using SispeServicios.Api.Gateway.RemoteModel.Empresa;

namespace SispeServicios.Api.Gateway.RemoteService
{
    public class EmpresaService: IEmpresaService
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly ILogger<EmpresaService> _logger;

        public EmpresaService(IHttpClientFactory httpClient, ILogger<EmpresaService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<(bool resultado, SedeRemote? sede, string? errorMesaje)> ConsultarSede(int? sedeId)
        {
            try
            {
                var cliente = _httpClient.CreateClient("Empresa");


                var response = await cliente.GetAsync($"/EmpresaSede/{sedeId}");

                var contenido = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var resultado = JsonConvert.DeserializeObject<SedeRemote>(contenido);
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
