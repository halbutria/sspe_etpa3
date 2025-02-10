using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.ServiciosAsociados;
using SispeServicios.Api.Ciudadano.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiciosAsociadosController : ControllerBase
    {
        private IMediator _mediator;

        public ServiciosAsociadosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<ServiciosAsociadosDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [Route("listaPaginada")]
        [HttpGet]
        public async Task<List<ServiciosAsociadosDTO>> GetListQuery([FromQuery] ListaPaginada.Ejecuta data)
        {
            var respuesta = await _mediator.Send(data);
            Response.Headers.Add("X-Paginacion", respuesta.encabezado);
            return respuesta.registros;
        }


        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiciosAsociadosDTO>> Get(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost]
        public async Task<ActionResult<ServiciosAsociadosDTO>> Post(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut]
        public async Task<ActionResult<ServiciosAsociadosDTO>> Put(Edicion.Ejecuta data)
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
