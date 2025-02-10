using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.Direccion;
using SispeServicios.Api.Ciudadano.DTOs;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DireccionController : ControllerBase
    {
        private IMediator _mediator;

        public DireccionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Listado
        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<DireccionDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }
        
        // Creacion
        [HttpPost]
        public async Task<ActionResult<Unit>> Post([FromBody] Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // Edicion
        [HttpPut]
        public async Task<ActionResult<Unit>> Put(Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        /*
        [HttpGet("{Id}")]
        public async Task<ActionResult<ConocimientoCompetenciaDTO>> Get(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Unit>> Delete(Guid Id)
        {
            return await _mediator.Send(new Borrado.Ejecuta() { Id = Id });
        }*/
    }
}
