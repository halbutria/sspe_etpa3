using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiParametrico.DTOs;
using appViaPrincipal = SispeServiciosApiParametrico.Aplicacion.CrudViaPrincipal;

namespace SispeServiciosApiParametrico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ViaPrincipalController : Controller
    {
        private IMediator _mediator;

        public ViaPrincipalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("ViaPrincipal/{Id}")]
        public async Task<ActionResult<ViaPrincipalDTO>> Get(string Id)
        {
            return await _mediator.Send(new appViaPrincipal.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("ViaPrincipal")]
        public async Task<ActionResult<ViaPrincipalDTO>> Ingresar([FromForm] appViaPrincipal.Ingresar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("ViaPrincipal")]
        public async Task<ActionResult<ViaPrincipalDTO>> Actualizacion([FromForm] appViaPrincipal.Modificar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("ViaPrincipal/{Id}")]
        public async Task<ActionResult<Unit>> Eliminar(string Id)
        {
            return await _mediator.Send(new appViaPrincipal.Eliminar.Ejecuta() { Id = Id });
        }
    }
}
