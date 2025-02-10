using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.RedesSociales;
using SispeServicios.Api.Ciudadano.DTOs;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RedesSocialesController : ControllerBase
    {
        private IMediator _mediator;

        public RedesSocialesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<RedesSocialesDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<RedesSocialesDTO>> Get(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost]
        public async Task<ActionResult<RedesSocialesDTO>> Post(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut]
        public async Task<ActionResult<RedesSocialesDTO>> Put(Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Unit>> Delete(Guid Id)
        {
            return await _mediator.Send(new Borrado.Ejecuta() { Id = Id });
        }
    }
}
