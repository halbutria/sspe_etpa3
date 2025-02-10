using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Intermediacion.Aplicacion.EmpresaSede;
using SispeServicios.Api.Intermediacion.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Intermediacion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresaSedeController : ControllerBase
    {
        private IMediator _mediator;

        public EmpresaSedeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET: api/<EmpresaSedeController>
        [HttpGet("{Id}")]
        public async Task<EmpresaSedeDetalleDTO> Get(int Id)
        {
            return await _mediator.Send(new Consulta.Ejecuta() { Id = Id });
        }

        // GET api/<EmpresaSedeController>/5
        [HttpGet("EmpresaId")]
        public async Task<List<EmpresaSedeDTO>> GetAsync(int EmpresaId)
        {
            var respuesta = await _mediator.Send(new Lista.Ejecuta(){EmpresaId = EmpresaId });
            Response.Headers.Add("X-Paginacion", respuesta.encabezado); 
            return respuesta.data;
        }

        // POST api/<EmpresaSedeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmpresaSedeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmpresaSedeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
