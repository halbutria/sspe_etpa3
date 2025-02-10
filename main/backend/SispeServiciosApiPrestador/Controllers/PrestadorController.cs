using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Prestador.Aplicacion.Prestador;
using SispeServicios.Api.Prestador.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Prestador.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrestadorController : ControllerBase
    {

        private IMediator _mediator;

        public PrestadorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("lista/{DepartamentoId}")]
        [HttpGet]
        public async Task<List<PrestadorDTO>> GetList(string DepartamentoId)
        {
            return await _mediator.Send(new Lista.Ejecuta() { DepartamentoId = DepartamentoId });
        }

        [HttpGet("{Id}")]
        public async Task<PrestadorDTO> GetAsync(Guid Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        [HttpPost]
        public async Task<PrestadorDTO> PostAsync([FromBody] Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpGet("{FechaInicial}/{FechaFinal}")]
        public async Task<List<PrestadorListDTO>> GetByDateAsync(DateTime FechaInicial, DateTime FechaFinal)
        {
            return await _mediator.Send(new ConsultaFecha.Ejecuta() { FechaInicial = FechaInicial, FechaFinal = FechaFinal });
        }

        //// PUT api/<PrestadorController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PrestadorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
