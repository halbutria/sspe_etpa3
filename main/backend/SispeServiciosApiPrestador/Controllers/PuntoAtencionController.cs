using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Prestador.Aplicacion.PuntoAtencion;
using SispeServicios.Api.Prestador.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Prestador.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PuntoAtencionController : ControllerBase
    {

        private IMediator _mediator;

        public PuntoAtencionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista/{PrestadorId}")]
        [HttpGet]
        public async Task<List<PuntoAtencionDTO>> GetList(Guid PrestadorId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { PrestadorId = PrestadorId });
        }

        [HttpGet("{Id}")]
        public async Task<PuntoAtencionDTO> GetAsync(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        //[HttpPost]
        //public async Task<PuntoAtencionDTO> PostAsync([FromBody] Nuevo.Ejecuta data)
        //{
        //    return await _mediator.Send(data);
        //}
    }
}
