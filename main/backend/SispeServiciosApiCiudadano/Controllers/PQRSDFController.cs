using MediatR;
using Microsoft.AspNetCore.Mvc;
using PdfSharpCore.Pdf.Filters;
using SispeServicios.Api.Ciudadano.Aplicacion.PQRSDF;
using SispeServicios.Api.Ciudadano.DTOs;
using System.Threading.Tasks;


namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PQRSDFController : ControllerBase
    {
        private IMediator _mediator;

        public PQRSDFController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista")]
        [HttpGet]
        public async Task<List<CiudadanoPQRSDFResponseDto>> GetListQuery([FromQuery] Lista.Ejecuta data)
        {
            var respuesta = await _mediator.Send(data);
            Response.Headers.Add("X-Paginacion", respuesta.encabezado);
            return respuesta.registros;
        }

        [HttpPost]
        public async Task<ActionResult<CiudadanoPQRSDFResponseDto>> Post(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [Route("lista/TipoPQR")]
        [HttpGet]
        public async Task<ActionResult<List<TipoPQRSDFResponseDto>>> GetListType()
        {
            return await _mediator.Send(new ListaTipoPQR.Ejecuta());
        }
    }
}
