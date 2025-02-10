using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ocelot.Responses;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteModel;
using System.Collections.Generic;
using System.Reflection;

namespace SispeServicios.Api.Gateway.MessageHandler
{
    public class InformacionLaboralHandler : DelegatingHandler
    {
        private IParametricoService _parametricoService;
        private readonly ILogger<InformacionLaboralHandler> _logger;

        public InformacionLaboralHandler(IParametricoService parametricoService, ILogger<InformacionLaboralHandler> logger)
        {
            _parametricoService = parametricoService;
            _logger = logger;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {

            var response = await base.SendAsync(request, cancellationToken);

            if (response.IsSuccessStatusCode && response.RequestMessage.Method.ToString() != "DELETE")
            {
                var contenido = await response.Content.ReadAsStringAsync();
                var resultadoStr = contenido;
                var token = JToken.Parse(contenido);
                if (token is not JArray)
                {
                    var responseInput = JsonConvert.DeserializeObject<InformacionLaboraInputRemote>(contenido);
                    responseInput = await ProcesarRespuestaAsync(responseInput);
                    resultadoStr = JsonConvert.SerializeObject(responseInput);
                }
                else
                {
                    var responseInputList = JsonConvert.DeserializeObject<List<InformacionLaboraInputRemote>>(contenido);
                    var responseInput = new List<InformacionLaboraInputRemote>();
                    foreach (var item in responseInputList)
                    {
                        responseInput.Add(await ProcesarRespuestaAsync(item));
                    }
                    resultadoStr = JsonConvert.SerializeObject(responseInput);
                }                
                response.Content = new StringContent(resultadoStr, System.Text.Encoding.UTF8, "application/json");
            }

            return response;
        }

        private async Task<InformacionLaboraInputRemote> ProcesarRespuestaAsync(InformacionLaboraInputRemote responseInput)
        {
            var input = new ParametricoConsultaInputRemote
            {
                PaisId = responseInput?.Pais?.Id,
                TipoExperienciaId = responseInput?.TipoExperiencia?.Id,
                SectorId = responseInput?.Sector?.Id,
                CargoEquivalenteId = responseInput?.CargoEquivalente?.Id,
                OcupacionEquivalenteId = responseInput?.OcupacionEquivalente?.Id,
                ConocimientoId = responseInput?.Conocimiento?.Id,
                HabilidadId = responseInput?.Habilidad?.Id
            };
            var responseParametrico = await _parametricoService.ConsultarParametrico(input);
            if (responseParametrico.resultado)
            {
                responseInput.Pais.Nombre = responseParametrico.parametrico?.Pais?.Nombre;
                responseInput.TipoExperiencia.Nombre = responseParametrico.parametrico?.TipoExperiencia?.Nombre;
                responseInput.Sector.Nombre = responseParametrico.parametrico?.Sector?.Nombre;
                responseInput.CargoEquivalente.Nombre = responseParametrico.parametrico?.CargoEquivalente?.Nombre;
                responseInput.OcupacionEquivalente.Nombre = responseParametrico.parametrico?.OcupacionEquivalente?.Nombre;
                responseInput.Conocimiento.Nombre = responseParametrico.parametrico?.Conocimiento?.Nombre;
                responseInput.Habilidad.Nombre = responseParametrico.parametrico?.Habilidad?.Nombre;

            }
            else
            {
                _logger.LogError(responseParametrico.errorMesaje);
            }
            return responseInput;
        }
    }
}
