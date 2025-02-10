using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.EducacionFormal;
using SispeServicios.Api.Ciudadano.DTOs;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EducacionFormalController : ControllerBase
    {
        private IMediator _mediator;
        
        public EducacionFormalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Para retornar un listado de objetos de educacion formal creados
        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<EducacionFormalDTO>>> GetList(Guid CiudadanoId, [FromQuery] bool Graduado)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId, Graduado = Graduado });
        }

        // Para retornar un objeto especifico de educacion formal que se encuentran creado
        [HttpGet("{Id}")]
        public async Task<ActionResult<EducacionFormalDTO>> Get(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        // Creacion de un nuevo registro para Educacion Formal
        [HttpPost]
        public async Task<ActionResult<Unit>> Post(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }


        // Edicion de un registro existente que haga referencia a la educacion Formal de un Ciudadano
        [HttpPut]
        public async Task<ActionResult<Unit>> Put(Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // DELETE api/<EducacionFormalController>/5
        [HttpDelete("{Id}")]
        public async Task<ActionResult<Unit>> Delete(Guid Id)
        {
            return await _mediator.Send(new Borrado.Ejecuta() { Id = Id });
        }
    }
}
