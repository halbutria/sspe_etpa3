using Azure;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoEncuentasIes;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServiciosApiCiudadano.Aplicacion.Utils;
using SispeServiciosApiCiudadano.DTOs;

namespace SispeServiciosApiCiudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CiudadanoEncuentasIesController : ControllerBase
    {

        private IMediator _mediator;

        public CiudadanoEncuentasIesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CiudadanoEncuentasIesDTO>> Post(CiudadanoEncuentasIesDTO request)
        {
            return await _mediator.Send(new Nuevo.Ejecuta { CiudadanoEncuentasIes = request });
        }

        [Route("{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<CiudadanoEncuentasIesDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [HttpGet]
        public async Task<ActionResult<List<CiudadanoEncuentasIesDTO>>> Get([FromQuery] FiltrosCiudadanoEncuentasIesDTO request)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Filtros = request });
        }

        [Route("{EncuestaId}/GenerarPdf")]
        [HttpGet]
        public async Task<IActionResult> GetEncuesta(Guid EncuestaId)
        {
            CiudadanoEncuentasIesDTO ciudadanoEncuentasIesDTO = await _mediator.Send(new ObtenerPorId.Ejecuta() { CiudadanoEncuestaIesId = EncuestaId });

            byte[]? response = new byte[1];
            string nombreDocumento = "Encuesta_ies.pdf";
            if (ciudadanoEncuentasIesDTO is not null) {
                nombreDocumento = $"Encuesta_ies_{ciudadanoEncuentasIesDTO.NumeroDocumento}.pdf";
                response = GenerarPdfEncuestaIes.GenerarPDF(ciudadanoEncuentasIesDTO);
            }

            return File(response, "application/pdf", nombreDocumento);
        }

        [Route("ObtenerProgramas")]
        [HttpGet]
        public async Task<ActionResult<List<string>>> GetPrograms()
        {
            return await _mediator.Send(new ObtenerProgramas.Ejecuta());
        }
    }
}
