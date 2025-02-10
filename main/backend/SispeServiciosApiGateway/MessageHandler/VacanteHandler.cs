using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SispeServicios.Api.Gateway.RemoteInterface;
using SispeServicios.Api.Gateway.RemoteModel;
using SispeServicios.Api.Gateway.RemoteModel.Empresa;
using SispeServicios.Api.Gateway.RemoteModel.Salida;
using SispeServicios.Api.Gateway.RemoteModel.Vacante;
using SispeServicios.Api.Gateway.RemoteModel.Vacante.Entrada;
using SispeServicios.Api.Gateway.RemoteModel.Vacante.Salida;
using SispeServicios.Api.Gateway.RemoteService;

namespace SispeServicios.Api.Gateway.MessageHandler
{
    public class VacanteHandler : DelegatingHandler
    {
        private IParametricoService _parametricoService;
        private readonly IEmpresaService _empresaService;
        private readonly ILogger<InformacionLaboralHandler> _logger;
        private List<ParametricoConsultaOutputRemote> _historicoParametrico = new List<ParametricoConsultaOutputRemote>();
        private List<SedeRemote> _historicoEmpresaSede = new List<SedeRemote>();


        public VacanteHandler(IParametricoService parametricoService, IEmpresaService empresaService, ILogger<InformacionLaboralHandler> logger)
        {
            _parametricoService = parametricoService;
            _empresaService = empresaService;
            _logger = logger;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            var contenido = await response.Content.ReadAsStringAsync();
            var resultadoStr = contenido;
            var token = JToken.Parse(contenido);
            if (token is JArray)
            {
                _historicoParametrico = new List<ParametricoConsultaOutputRemote>();
                _historicoEmpresaSede = new List<SedeRemote>();

                var responseInputList = JsonConvert.DeserializeObject<List<VacanteInfoRemote>>(contenido);
                var responseInput = new List<VacanteInfo>();
                foreach (var item in responseInputList)
                {
                    responseInput.Add(await ProcesarRespuestaAsync(item));
                }
                resultadoStr = JsonConvert.SerializeObject(responseInput);
                response.Content = new StringContent(resultadoStr, System.Text.Encoding.UTF8, "application/json");

            }

            return response;
        }

        private async Task<VacanteInfo> ProcesarRespuestaAsync(VacanteInfoRemote responseInput)
        {

            VacanteInfo salida = new VacanteInfo()
            {
                Id = responseInput.Id,
                Nombre = responseInput?.Nombre,
                FechaVencimientoVacante = responseInput?.FechaVencimientoVacante,
                FechaLimiteEnvioHv = responseInput?.FechaLimiteEnvioHv,
                EsHidrocarburos= responseInput?.EsHidrocarburos,
                Ubicaciones = new List<VacanteUbicacion>(),
                PuestosRequeridos = responseInput?.PuestosRequeridos,
                Estado = new VacanteEstadoRemote() { Id = responseInput?.Estado?.Id, Nombre = responseInput?.Estado?.Nombre },
                Empresa = new VacanteEmpresa() { Sede = new VacanteSedeEmpresa() {SedeId= responseInput?.SedeId, Responsable = new VacanteUsuarioResponsable() } }             

            };

            var existeEmpresa = _historicoEmpresaSede.Where(x => x.id == responseInput?.SedeId).FirstOrDefault();

            if (existeEmpresa is null)
            {
                var sede = await _empresaService.ConsultarSede(responseInput?.SedeId);
                if (sede.resultado)
                {
                    _historicoEmpresaSede.Add(sede.sede);
                    AgregarSedeEmpresaEmpresa(salida, sede.sede, responseInput?.ResponsableId);
                }
            }
            else
            {
                AgregarSedeEmpresaEmpresa(salida, existeEmpresa, responseInput?.ResponsableId);
            }




            foreach (var ubicacion in responseInput?.Ubicaciones)
            {
                var parametricoExiste = _historicoParametrico?.Where(x =>
                x.Departamento.Id == ubicacion?.DepartamentoID &&
                x.Municipio.Id == ubicacion?.MunicipioID 
                //&& x.LocalidadComuna.Id == ubicacion?.LocalidadComunaId
                ).FirstOrDefault();

                if (parametricoExiste is null)
                {
                    var input = new ParametricoConsultaInputRemote
                    {
                        MunicipioId = ubicacion?.MunicipioID,
                        DepartamentoId = ubicacion?.DepartamentoID,
                        LocalidadComunaId = ubicacion?.LocalidadComunaId,
                    };
                    var responseParametrico = await _parametricoService.ConsultarParametrico(input);
                    if (responseParametrico.resultado)
                    {
                        _historicoParametrico?.Add(responseParametrico.parametrico);
                        salida.Ubicaciones.Add(AgregarUbicacion(responseParametrico.parametrico, ubicacion?.NumeroPuestos));                    
                    }
                }
                else
                {
                    salida.Ubicaciones.Add(AgregarUbicacion(parametricoExiste, ubicacion?.NumeroPuestos));
                }
            };

            return salida;
        }


        private VacanteUbicacion AgregarUbicacion(ParametricoConsultaOutputRemote? Parametrico, int? NumeroPuestos)
        {
            return new VacanteUbicacion()
            {
                Departamento = Parametrico?.Departamento?.Nombre ?? "",
                Municipio = Parametrico?.Municipio?.Nombre ?? "",
                NumeroPuestos = NumeroPuestos,
                LocalidadComuna = Parametrico?.LocalidadComuna?.Nombre ?? "",
            };
        }

        private void AgregarSedeEmpresaEmpresa(VacanteInfo salida, SedeRemote SedeEmpresa, Guid? ResponsableId)
        {
            var responsable = SedeEmpresa?.usuarios?.FirstOrDefault(x => x.id == ResponsableId);
            salida.Empresa.RazonSocial = SedeEmpresa?.empresa?.razonSocial;
            salida.Empresa.Sede.Responsable.Correo = responsable?.correoElectronico;
            salida.Empresa.Sede.Responsable.Nombre = $"{responsable?.primerNombre} {responsable?.segundoNombre} {responsable?.primerApellido} {responsable?.segundoApellido}";
        }
    }
}
