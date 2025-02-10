using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiCiudadano.DTOs;
using SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoServiciosBasicos;

namespace SispeServiciosApiCiudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CiudadanoServiciosBasicosController: ControllerBase
    {

        private IMediator _mediator;

        public CiudadanoServiciosBasicosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CiudadanoServiciosBasicosDTO>> Post(CiudadanoServiciosBasicosDTO request)
        {
            return await _mediator.Send(new Nuevo.Ejecuta { CiudadanoServiciosBasicos = request });
        }

        [Route("{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<CiudadanoServiciosBasicosDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [HttpGet]
        public async Task<ActionResult<List<CiudadanoServiciosBasicosDTO>>> Get([FromQuery] FiltrosCiudadanoServiciosBasicosDTO request)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Filtros = request });
        }
    }
}
