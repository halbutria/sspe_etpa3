using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiParametrico.DTOs;
using appModuloRolFuncionalidad = SispeServiciosApiParametrico.Aplicacion.ModuloRolFuncionalidad;

namespace SispeServiciosApiParametrico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModuloRolFuncionalidadController : Controller
    {
        private IMediator _mediator;

        public ModuloRolFuncionalidadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("lista")]
        public async Task<List<ModuloRolFuncionalidadDTO>> GetAsync()
        {
            return await _mediator.Send(new appModuloRolFuncionalidad.Lista.Ejecuta() { tipo = "ModuloRolFuncionalidad" });
        }

        [HttpGet("ModuloRolFuncionalidad/{id}")]
        public async Task<ActionResult<ModuloRolFuncionalidadDTO>> Get(string id)
        {
            return await _mediator.Send(new appModuloRolFuncionalidad.Consulta.Ejecuta() { Id = id });
        }

        [HttpPost("ModuloRolFuncionalidad")]
        public async Task<ActionResult<ModuloRolFuncionalidadDTO>> Ingresar([FromForm] appModuloRolFuncionalidad.Ingresar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("ModuloRolFuncionalidad")]
        public async Task<ActionResult<ModuloRolFuncionalidadDTO>> Actualizacion([FromForm] appModuloRolFuncionalidad.Modificar.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("ModuloRolFuncionalidad/{Id}")]
        public async Task<ActionResult<Unit>> Eliminar(string Id)
        {
            return await _mediator.Send(new appModuloRolFuncionalidad.Eliminar.Ejecuta() { Id = Id });
        }
    }
}
