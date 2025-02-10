using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiParametrico.DTOs;
using appViaComplemento = SispeServiciosApiParametrico.Aplicacion.CrudViaComplemento;

namespace SispeServiciosApiParametrico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ViaComplementoController : Controller
    {
        private IMediator _mediator;

        public ViaComplementoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("ViaComplemento/{Id}")]
        public async Task<ActionResult<ViaComplementoDTO>> Get(string Id)
        {
            return await _mediator.Send(new appViaComplemento.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("ViaComplemento")]
        public async Task<ActionResult<ViaComplementoDTO>> Ingresar([FromForm] appViaComplemento.Ingresar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("ViaComplemento")]
        public async Task<ActionResult<ViaComplementoDTO>> Actualizacion([FromForm] appViaComplemento.Modificar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("ViaComplemento/{Id}")]
        public async Task<ActionResult<Unit>> Eliminar(string Id)
        {
            return await _mediator.Send(new appViaComplemento.Eliminar.Ejecuta() { Id = Id });
        }
    }
}
