using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.NotificacionVacanteDeseada;
using SispeServicios.Api.Ciudadano.DTOs;
using System.Threading.Tasks;


namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NotificacionVacanteDeseadaController : ControllerBase
    {
        private IMediator _mediator;

        public NotificacionVacanteDeseadaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<CiudadanoNotificacionVacanteDeseadaDto>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [HttpPost]
        public async Task<ActionResult<CiudadanoNotificacionVacanteDeseadaDto>> Post(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut]
        public async Task<ActionResult<CiudadanoNotificacionVacanteDeseadaDto>> Put(Edicion.Ejecuta data)
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
