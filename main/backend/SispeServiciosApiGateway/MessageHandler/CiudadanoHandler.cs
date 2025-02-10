using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteModel;
using System.Security.Cryptography.Xml;

namespace SispeServicios.Api.Gateway.MessageHandler
{
    public class CiudadanoHandler : DelegatingHandler
    {
        private readonly IParametricoService _parametricoService;
        private readonly ILogger<CiudadanoHandler> _logger;

        public CiudadanoHandler(IParametricoService parametricoService, ILogger<CiudadanoHandler> logger)
        {
            _parametricoService = parametricoService;
            _logger = logger;
        }
        protected override async Task<HttpResponseMessage> SendAsync( HttpRequestMessage request, CancellationToken cancellationToken) {
        
            var response = await base.SendAsync(request, cancellationToken);
            
            if (response.IsSuccessStatusCode) {
                var contenido = await response.Content.ReadAsStringAsync();
                var responseCiudadanoInput = JsonConvert.DeserializeObject<CiudadanoInputRemote>(contenido);
                var input  = new ParametricoConsultaInputRemote{ 
                    TipoDocumentoId = responseCiudadanoInput?.TipoDocumento?.Id,
                    MunicipioId = responseCiudadanoInput?.Municipio?.Id,
                    DepartamentoId = responseCiudadanoInput?.Departamento?.Id,
                    PaisId = responseCiudadanoInput?.PaisResidencia?.Id,
                    GeneroId = responseCiudadanoInput?.Genero?.Id,
                    EstadoCivilId = responseCiudadanoInput?.EstadoCivil?.Id,
                    PaisNacimientoId = responseCiudadanoInput?.PaisNacimiento?.Id,
                    DepartamentoNacimientoId = responseCiudadanoInput?.DepartamentoNacimiento?.Id,
                    MunicipioNacimientoId = responseCiudadanoInput?.MunicipioNacimiento?.Id,
                    EpsId = responseCiudadanoInput?.Eps?.Id,
                    RangoSalarialId = responseCiudadanoInput?.RangoSalarial?.Id,
                    GrupoEtnicoId = responseCiudadanoInput?.GrupoEtnico?.Id,
                    CondicionDiscapacidadId = responseCiudadanoInput?.CondicionDiscapacidad?.Id,
                    CondicionSaludMentalId = responseCiudadanoInput?.CondicionSaludMental?.Id,
                    CategoriaLicenciaCarroId = responseCiudadanoInput?.CategoriaLicenciaCarro?.Id,
                    CategoriaLicenciaMotoId = responseCiudadanoInput?.CategoriaLicenciaMoto?.Id,
                    SituacionLaboralActualId = responseCiudadanoInput?.SituacionLaboralActual?.Id,
                    PerteneceAId = responseCiudadanoInput?.PerteneceA?.Id,
                    TipoPoblacionId = responseCiudadanoInput?.TipoPoblacion?.Id,
                };
                var responseParametrico = await _parametricoService.ConsultarParametrico(input);
                if (responseParametrico.resultado)
                {
                    responseCiudadanoInput.Municipio.Nombre = responseParametrico.parametrico?.Municipio?.Nombre;
                    responseCiudadanoInput.Departamento.Nombre = responseParametrico.parametrico?.Departamento?.Nombre;
                    responseCiudadanoInput.TipoDocumento.Nombre = responseParametrico.parametrico?.TipoDocumento?.Nombre;
                    responseCiudadanoInput.Genero.Nombre = responseParametrico.parametrico?.Genero?.Nombre;
                    responseCiudadanoInput.PaisResidencia.Nombre = responseParametrico.parametrico?.Pais?.Nombre;
                    responseCiudadanoInput.EstadoCivil.Nombre = responseParametrico.parametrico?.EstadoCivil?.Nombre;
                    responseCiudadanoInput.PaisNacimiento.Nombre = responseParametrico.parametrico?.PaisNacimiento?.Nombre;
                    responseCiudadanoInput.DepartamentoNacimiento.Nombre = responseParametrico.parametrico?.DepartamentoNacimiento?.Nombre;
                    responseCiudadanoInput.MunicipioNacimiento.Nombre = responseParametrico.parametrico?.MunicipioNacimiento?.Nombre;
                    responseCiudadanoInput.Eps.Nombre = responseParametrico.parametrico?.Eps?.Nombre;
                    responseCiudadanoInput.RangoSalarial.Nombre = responseParametrico.parametrico?.RangoSalarial?.Nombre;
                    responseCiudadanoInput.GrupoEtnico.Nombre = responseParametrico.parametrico?.GrupoEtnico?.Nombre;
                    responseCiudadanoInput.CondicionDiscapacidad.Nombre = responseParametrico.parametrico?.CondicionDiscapacidad?.Nombre;
                    responseCiudadanoInput.CondicionSaludMental.Nombre = responseParametrico.parametrico?.CondicionSaludMental?.Nombre;
                    responseCiudadanoInput.CategoriaLicenciaCarro.Nombre = responseParametrico.parametrico?.CategoriaLicenciaCarro?.Nombre;
                    responseCiudadanoInput.CategoriaLicenciaMoto.Nombre = responseParametrico.parametrico?.CategoriaLicenciaMoto?.Nombre;
                    responseCiudadanoInput.SituacionLaboralActual.Nombre = responseParametrico.parametrico?.SituacionLaboralActual?.Nombre;
                    responseCiudadanoInput.PerteneceA.Nombre = responseParametrico.parametrico?.PerteneceA?.Nombre;
                    responseCiudadanoInput.TipoPoblacion.Nombre = responseParametrico.parametrico?.TipoPoblacion?.Nombre;
                    var resultadoStr = JsonConvert.SerializeObject(responseCiudadanoInput);
                    response.Content = new StringContent(resultadoStr,System.Text.Encoding.UTF8,"application/json");
                }
                else
                {
                    _logger.LogError(responseParametrico.errorMesaje);
                }
            }

            return response;
        }
    }
}
