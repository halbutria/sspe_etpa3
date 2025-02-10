using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteModel;

namespace SispeServicios.Api.Gateway.MessageHandler
{
    public class TipoNotificacionHandler : DelegatingHandler
    {
        private IParametricoService _parametricoService;
        private readonly ILogger<TipoNotificacionHandler> _logger;

        public TipoNotificacionHandler(IParametricoService parametricoService, ILogger<TipoNotificacionHandler> logger)
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


                var responseInputList = JsonConvert.DeserializeObject<List<TipoNotificacionInputRemote>>(contenido);
                var responseInput = new List<TipoNotificacionInputRemote>();
                foreach (var item in responseInputList)
                {
                    responseInput.Add(await ProcesarRespuestaAsync(item));
                }
                resultadoStr = JsonConvert.SerializeObject(responseInput);

                response.Content = new StringContent(resultadoStr, System.Text.Encoding.UTF8, "application/json");
            }

            return response;
        }

        private async Task<TipoNotificacionInputRemote> ProcesarRespuestaAsync(TipoNotificacionInputRemote responseInput)
        {
            var input = new ParametricoConsultaInputRemote
            {
               TipoNotificacionId = responseInput.tipoNotificacionId
            };
            var responseParametrico = await _parametricoService.ConsultarParametrico(input);
            if (responseParametrico.resultado)
            {
                responseInput.Notificacion = responseParametrico.parametrico?.TipoNotificacion?.Nombre;                
            }
            else
            {
                _logger.LogError(responseParametrico.errorMesaje);
            }
            return responseInput;
        }

    }
}
