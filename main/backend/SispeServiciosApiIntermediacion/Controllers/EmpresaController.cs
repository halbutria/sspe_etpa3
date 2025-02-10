using MediatR;
using Microsoft.AspNetCore.Mvc;
using appEmpresa = SispeServicios.Api.Intermediacion.Aplicacion.Empresa;
using appResponsable = SispeServicios.Api.Intermediacion.Aplicacion.EmpresaUsuario;
using SispeServicios.Api.Intermediacion.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Intermediacion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {

        private IMediator _mediator;

        public EmpresaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<EmpresaController>
        [HttpGet]
        [Route("lista")]
        public async Task<List<EmpresaDTO>> GetAsync([FromQuery] appEmpresa.Lista.Ejecuta data)
        {

            var respuesta =  await _mediator.Send(data);
            Response.Headers.Add("X-Paginacion", respuesta.encabezado);
            return respuesta.data;
        }

        // GET api/<EmpresaController>/5
        [HttpGet]
        public async Task<EmpresaDetalleDTO> GetAsync(int? Id, [FromQuery] EmpresaBaseDTO empresa)
        {
            return await _mediator.Send(new appEmpresa.Consulta.Ejecuta() { Id = Id, TipoDocumentoId = empresa.TipoDocumentoId, NumeroDocumento = empresa.NumeroDocumento });
        }

        //// GET: api/<EmpresaController>
        //[HttpGet]
        //[Route("responsable/lista")]
        //public async Task<List<EmpresaUsuarioDTO>> GetResponsableListAsync([FromQuery] appResponsable.Lista.Ejecuta data)
        //{

        //    var respuesta = await _mediator.Send(data);
        //    Response.Headers.Add("X-Paginacion", respuesta.encabezado);
        //    return respuesta.data;
        //}

        //// GET: api/<EmpresaController>
        //[HttpGet]
        //[Route("responsable")]
        //public async Task<EmpresaUsuarioDTO> GetResponsableAsync([FromQuery] appResponsable.Consulta.Ejecuta data)
        //{

        //    return await _mediator.Send(data);
        //}

        

        //// POST api/<EmpresaController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<EmpresaController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EmpresaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
