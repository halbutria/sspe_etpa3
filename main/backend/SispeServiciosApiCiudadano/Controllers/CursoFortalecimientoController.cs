using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.CursoFortalecimiento;
using SispeServicios.Api.Ciudadano.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CursoFortalecimientoController : ControllerBase
    {
        private IMediator _mediator;

        public CursoFortalecimientoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<CiudadanoCursoFortalecimientoRespDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<CiudadanoCursoFortalecimientoRespDTO>> Get(int Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost]
        public async Task<ActionResult<CiudadanoCursoFortalecimientoRespDTO>> Post(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut]
        public async Task<ActionResult<CiudadanoCursoFortalecimientoRespDTO>> Put(Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Unit>> Delete(int Id)
        {
            return await _mediator.Send(new Borrado.Ejecuta() { Id = Id });
        }
    }
}
