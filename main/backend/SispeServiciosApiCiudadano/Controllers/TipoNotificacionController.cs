using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.TipoNotificacion;
using SispeServicios.Api.Ciudadano.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoNotificacionController : ControllerBase
    {
        private IMediator _mediator;

        public TipoNotificacionController(IMediator mediator)
        {
            _mediator = mediator;
        }


        
        // GET api/<TipoNotificacionController>/5
        [HttpGet("{CiudadanoId}")]
        public async Task<List<TipoNotificacionDTO>> GetAsync(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }


        // PUT api/<TipoNotificacionController>/5
        [HttpPut]
        public async Task<Unit> PutAsync(Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

    }
}
