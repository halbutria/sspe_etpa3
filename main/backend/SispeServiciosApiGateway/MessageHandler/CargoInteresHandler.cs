using Newtonsoft.Json;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteModel;

namespace SispeServicios.Api.Gateway.MessageHandler
{
    public class CargoInteresHandler : DelegatingHandler
    {
        private IParametricoService _parametricoService;
        private readonly ILogger<CargoInteresHandler> _logger;

        public CargoInteresHandler(IParametricoService parametricoService, ILogger<CargoInteresHandler> logger)
        {
            _parametricoService = parametricoService;
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            var response = await base.SendAsync(request, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var contenido = await response.Content.ReadAsStringAsync();
                var resultadoStr = contenido;


                var responseInputList = JsonConvert.DeserializeObject<List<ParametricoIntRemote>>(contenido);
                var responseInput = new List<ParametricoIntRemote>();
                foreach (var item in responseInputList)
                {
                    responseInput.Add(await ProcesarRespuestaAsync(item));
                }
                resultadoStr = JsonConvert.SerializeObject(responseInput);

                response.Content = new StringContent(resultadoStr, System.Text.Encoding.UTF8, "application/json");
            }

            return response;
        }

        private async Task<ParametricoIntRemote> ProcesarRespuestaAsync(ParametricoIntRemote responseInput)
        {
            var input = new ParametricoConsultaInputRemote
            {
                CargiInteresId = responseInput.Id
            };
            var responseParametrico = await _parametricoService.ConsultarParametrico(input);
            if (responseParametrico.resultado)
            {
                responseInput.Nombre = responseParametrico.parametrico?.TipoNotificacion?.Nombre;
            }
            else
            {
                _logger.LogError(responseParametrico.errorMesaje);
            }
            return responseInput;
        }
    }
}
