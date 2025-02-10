using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano;
using SispeServicios.Api.Ciudadano.Aplicacion.Utils;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServiciosApiCiudadano.Aplicacion.Ciudadano;
using SispeServiciosApiCiudadano.DTOs;

namespace SispeServicios.Api.Ciudadano.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class CiudadanoController : Controller
    {
        private readonly IMediator _mediator;

        public CiudadanoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CiudadanoInfoDTO>> crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut]
        public async Task<ActionResult<CiudadanoInfoDTO>> editar(Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet]
        public async Task<ActionResult<CiudadanoInfoDTO>> consulta(Guid? ciudadanoId, int? TipoDocumentoId, string? NumeroDocumento)
        {

            return await _mediator.Send(new Consulta.Ejecuta { Id = ciudadanoId, TipoDocumentoId= TipoDocumentoId, NumeroDocumento= NumeroDocumento });
        }


        [HttpGet("/[controller]/visualizacion")]
        public async Task<ActionResult<CiudadanoVisualizacionDTO>> visualizacion(Guid? ciudadanoId, int? TipoDocumentoId, string? NumeroDocumento)
        {

            return await _mediator.Send(new Visualizacion.Ejecuta { Id = ciudadanoId, TipoDocumentoId = TipoDocumentoId, NumeroDocumento = NumeroDocumento });
        }

        [HttpGet("/[controller]/GeneracionDocumento")]
        public async Task<IActionResult> GeneracionDocumento(Guid ciudadanoId, int? TipoDocumentoId, string? NumeroDocumento, int? TipoDocumentoGenerar)
        {
            string NombreDocumento = string.Empty;
            byte[]? response=new byte[1];

            if(TipoDocumentoGenerar == 1)
            {
                CiudadanoVisualizacionDTO InfoHv = await _mediator.Send(new Visualizacion.Ejecuta { Id = ciudadanoId, TipoDocumentoId = TipoDocumentoId, NumeroDocumento = NumeroDocumento });
                response = PdfGenerator.GeneracionPDF(InfoHv);
                NombreDocumento = "hv.pdf";

            }

            if (TipoDocumentoGenerar == 2)
            {
                CertificadoInscripcionDTO InfoCertificadoInscripcion = await _mediator.Send(new Certificado.EjecutaCertificado { Id = ciudadanoId.ToString() , TipoDocumentoId = TipoDocumentoId, NumeroDocumento = NumeroDocumento, TipoPersona=1 });
                response = PdfGenerator.GeneracionPDFCertificadoInscripcion(InfoCertificadoInscripcion);
                NombreDocumento = "certificadoInscripcion.pdf";

            }

            if (TipoDocumentoGenerar == 3)
            {
                CertificadoInscripcionDTO InfoCertificadoInscripcion = await _mediator.Send(new Certificado.EjecutaCertificado { Id = ciudadanoId.ToString(), TipoDocumentoId = TipoDocumentoId, NumeroDocumento = NumeroDocumento, TipoPersona =2 });
                response = PdfGenerator.GeneracionPDFCertificadoInscripcion(InfoCertificadoInscripcion);
                NombreDocumento = "certificadoInscripcion.pdf";

            }

            return File(response, "application/pdf", NombreDocumento);

        }

        [HttpGet("/[controller]/existe")]
        public async Task<ActionResult<CiudadanoExisteDTO>> existe(int TipoDocumentoId, string NumeroDocumento)
        {

            return await _mediator.Send(new Existe.Ejecuta { TipoDocumentoId = TipoDocumentoId, NumeroDocumento = NumeroDocumento });
        }

        [HttpPut("/CambioEstado")]
        public async Task<ActionResult<CiudadanoCambioEstadoDTO>> cambioEstado(CambioEstado.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("/CambioTieneEducacionFormal")]
        public async Task<ActionResult<CiudadanoTieneEducacionFormalDTO>> cambioTieneEducacionFormal(CambioTieneEducacionFormal.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
        [HttpPut("/CambioTieneEducacionNoFormal")]
        public async Task<ActionResult<CiudadanoTieneEducacionNoFormalDTO>> cambioTieneEducacionNoFormal(CambioTieneEducacionNoFormal.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
        [HttpPut("/CambioTieneInformacionLaboral")]
        public async Task<ActionResult<CiudadanoTieneInformacionLaboralDTO>> cambioTieneInformacionLaboral(CambioTieneInformacionLaboral.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
        
        [HttpPut("/[controller]/CambioTieneExperienciaPrevia")]
        public async Task<ActionResult<CiudadanoTieneExperienciaPreviaDTO>> cambioTieneExperienciaPrevia(CambioTieneExperienciaPrevia.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("DesactivarActivar")]
        public async Task<ActionResult<CiudadanoExisteDTO>> desactivar(DesactivarActivar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [Route("/PorcentajesAvance/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<PorcentajesAvanceDTO>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new PorcentajeAvanceHV.Ejecuta { CiudadanoId = CiudadanoId });
        }

        [Route("/[controller]/all")]
        [HttpGet]
        public async Task<List<CiudadanoInfoDTO>> GetAll([FromQuery] ConsultaAll.Ejecuta data)
        {
            var respuesta = await _mediator.Send(data);
            Response.Headers.Add("X-Paginacion", respuesta.encabezado);
            return respuesta.registros;
        }

        [Route("/[controller]/ids")]
        [HttpPost]
        public async Task<List<CiudadanoInfoDTO>> GetAllIds([FromBody] List<Guid> ids)
        {
            var data = new ConsultaAll.Ejecuta() { Ids = ids }; 
            var respuesta = await _mediator.Send(data);
            return respuesta.registros;
        }


        [Route("/[controller]/EditAdmin")]
        [HttpPut]
        public async Task<List<CiudadanoInfoDTO>> GetEditInfo(string tipo, [FromBody] AdminCambioDTO data)
        {
            var data1 = new ConsultaAll.Ejecuta() { Ids = new List<Guid>() };
            var respuesta = await _mediator.Send(data1);
            return respuesta.registros;
        }


        [Route("/[controller]/Login")]
        [HttpPost]
        public async Task<List<CiudadanoInfoDTO>> GetLogin([FromBody] LoginDTO data)
        {
            var data1 = new ConsultaAll.Ejecuta() { Ids = new List<Guid>() };
            var respuesta = await _mediator.Send(data1);
            return respuesta.registros;
        }

    }
}