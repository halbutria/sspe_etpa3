using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Aplicacion.BarreraEmpleo;

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BarrerasEmpleoController : ControllerBase
    {
        private IMediator _mediator;

        public BarrerasEmpleoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista/{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<BarreraEmpleoDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [HttpPost]
        public async Task<ActionResult<List<BarreraEmpleoDTO>>> Post(List<BarreraEmpleoDTO>  request)
        {
            return await _mediator.Send(new Nuevo.Ejecuta { BarrerasEmpleo = request });
        }


    }
}
