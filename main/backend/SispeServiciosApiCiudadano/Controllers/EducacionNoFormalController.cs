using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.EducacionNoFormal;
using SispeServicios.Api.Ciudadano.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EducacionNoFormalController : ControllerBase
    {

        private IMediator _mediator;

        public EducacionNoFormalController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<EducacionNoFormalController>
        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<List<EducacionNoFormalDTO>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        // GET api/<EducacionNoFormalController>/5
        [HttpGet("{Id}")]
        public async Task<EducacionNoFormalDTO> GetAsync(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        // POST api/<EducacionNoFormalController>
        [HttpPost]
        public async Task<Unit> PostAsync([FromBody] Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // PUT api/<EducacionNoFormalController>/5
        [HttpPut]
        public async Task<Unit> PutAsync([FromBody] Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // DELETE api/<EducacionNoFormalController>/5
        [HttpDelete("{Id}")]
        public async Task<Unit> DeleteAsync(Guid Id)
        {
            return await _mediator.Send(new Borrado.Ejecuta() { Id = Id });
        }
    }
}
