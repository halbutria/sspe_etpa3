using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoServiciosEspeciales;
using SispeServiciosApiCiudadano.DTOs;

namespace SispeServiciosApiCiudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CiudadanoServiciosEspecialesController
    {
        private IMediator _mediator;

        public CiudadanoServiciosEspecialesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CiudadanoServiciosEspecialesDTO>> Post(CiudadanoServiciosEspecialesDTO request)
        {
            return await _mediator.Send(new Nuevo.Ejecuta { CiudadanoServiciosEspeciales = request });
        }

        [Route("{CiudadanoId}")]
        [HttpGet]
        public async Task<ActionResult<List<CiudadanoServiciosEspecialesDTO>>> GetList(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        [HttpGet]
        public async Task<ActionResult<List<CiudadanoServiciosEspecialesDTO>>> Get([FromQuery] FiltrosCiudadanoServiciosEspecialesDTO request)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Filtros = request });
        }
    }
}
