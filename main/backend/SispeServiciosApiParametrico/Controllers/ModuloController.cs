using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiParametrico.DTOs;
using appModulo = SispeServiciosApiParametrico.Aplicacion.Modulo;

namespace SispeServiciosApiParametrico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModuloController : Controller
    {
        private IMediator _mediator;

        public ModuloController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //[Route("lista")]
        //public async Task<List<ModuloDTO>> GetAsync()
        //{
        //    return await _mediator.Send(new appModulo.Lista.Ejecuta() { tipo="Modulo"});
        //}

        [HttpGet("Modulo/{Id}")]
        public async Task<ActionResult<ModuloDTO>> Get(string Id)
        {
            return await _mediator.Send(new appModulo.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("Modulo")]
        public async Task<ActionResult<ModuloDTO>> Ingresar([FromBody] appModulo.Ingresar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("Modulo")]
        public async Task<ActionResult<ModuloDTO>> Actualizacion([FromForm] appModulo.Modificar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("Modulo/{Id}")]
        public async Task<ActionResult<Unit>> Eliminar(string Id)
        {
            return await _mediator.Send(new appModulo.Eliminar.Ejecuta() { Id = Id });
        }
    }
}
