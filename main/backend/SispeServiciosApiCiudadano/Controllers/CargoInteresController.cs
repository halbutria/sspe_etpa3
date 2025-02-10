using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Ciudadano.Aplicacion.CargoInteres;
using SispeServicios.Api.Ciudadano.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Ciudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CargoInteresController : ControllerBase
    {
        private IMediator _mediator;

        public CargoInteresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/<CargoInteresController>/5
        [HttpGet("{CiudadanoId}")]
        public async Task<List<ParametricoIntDTO>> GetAsync(Guid CiudadanoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { CiudadanoId = CiudadanoId });
        }

        
    }
}
