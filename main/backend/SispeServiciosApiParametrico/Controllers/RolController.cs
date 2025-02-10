using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiParametrico.DTOs;
using appRol = SispeServiciosApiParametrico.Aplicacion.Rol;

namespace SispeServiciosApiParametrico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RolController : Controller
    {
        private IMediator _mediator;

        public RolController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //[Route("lista")]
        //public async Task<List<RolDTO>> GetAsync()
        //{
        //    return await _mediator.Send(new appRol.Lista.Ejecuta() { tipo = "Rol" });
        //}

        [HttpGet("Rol/{Id}")]
        public async Task<ActionResult<RolDTO>> Get(string Id)
        {
            return await _mediator.Send(new appRol.Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost("Rol")]
        public async Task<ActionResult<RolDTO>> Ingresar([FromForm] appRol.Ingresar.Ejecuta dataRol)
        {
            return await _mediator.Send(dataRol);
        }

        [HttpPut("Rol")]
        public async Task<ActionResult<RolDTO>> Actualizacion([FromForm] appRol.Modificar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("Rol/{Id}")]
        public async Task<ActionResult<Unit>> Eliminar(string Id)
        {
            return await _mediator.Send(new appRol.Eliminar.Ejecuta() { Id = Id });
        }
    }
}
