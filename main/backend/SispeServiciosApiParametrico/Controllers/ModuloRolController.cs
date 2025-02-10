using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiParametrico.DTOs;
using appModuloRol = SispeServiciosApiParametrico.Aplicacion.ModuloRol;

namespace SispeServiciosApiParametrico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModuloRolController : Controller
    {
        private IMediator _mediator;

        public ModuloRolController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("lista")]
        public async Task<List<ModuloRolDTO>> GetAsync()
        {
            return await _mediator.Send(new appModuloRol.Lista.Ejecuta() { tipo = "ModuloRol" });
        }

        [HttpGet("ModuloRol/{idModulo}/{idRol}")]
        public async Task<ActionResult<ModuloRolDTO>> Get(string idModulo, string idRol)
        {
            return await _mediator.Send(new appModuloRol.Consulta.Ejecuta() { IdModulo = idModulo,IdRol = idRol});
        }

        [HttpPost("ModuloRol")]
        public async Task<ActionResult<ModuloRolDTO>> Ingresar([FromForm] appModuloRol.Ingresar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("ModuloRol")]
        public async Task<ActionResult<ModuloRolDTO>> Actualizacion([FromForm] appModuloRol.Modificar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("ModuloRol/{Id}")]
        public async Task<ActionResult<Unit>> Eliminar(string Id)
        {
            return await _mediator.Send(new appModuloRol.Eliminar.Ejecuta() { Id = Id });
        }
    }
}
