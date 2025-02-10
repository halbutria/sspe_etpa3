using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.InformacionLaboral;
using SispeServicios.Api.Ciudadano.DTOs;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InformacionLaboralController : ControllerBase
    {
        private IMediator _mediator;

        public InformacionLaboralController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<InformacionLaboralController>/lista/{CiudadanoId}
        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<InformacionLaboralDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        // GET api/<InformacionLaboralController>/5
        [HttpGet("{Id}")]
        public async Task<ActionResult<InformacionLaboralDTO>> Get(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta(){ Id = Id });
        }

        // POST api/<InformacionLaboralController>
        [HttpPost]
        public async Task<ActionResult<Unit>> post(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // PUT api/<InformacionLaboralController>
        [HttpPut]
        public async Task<ActionResult<Unit>> put(Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // DELETE api/<InformacionLaboralController>/5
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Unit>> Delete(Guid Id)
        {
            return await _mediator.Send(new Borrado.Ejecuta() { Id = Id });
        }
    }
}
