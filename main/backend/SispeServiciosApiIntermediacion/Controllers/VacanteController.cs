using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Intermediacion.Aplicacion.Vacante;
using SispeServicios.Api.Intermediacion.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServicios.Api.Intermediacion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VacanteController : ControllerBase
    {

        private IMediator _mediator;
        private readonly IConfiguration _config;

        public VacanteController(IMediator mediator, IConfiguration config)
        {
            _mediator = mediator;
            _config = config;
        }

        // GET: api/<VacanteController>
        [HttpGet]
        public async Task<List<VacanteInfoDTO>> GetAsync([FromQuery] Lista.Ejecuta data)
        {
            var respuesta = await _mediator.Send(data);
            Response.Headers.Add("X-Paginacion", respuesta.encabezado);
            return respuesta.vacantes;
        }

        // GET api/<VacanteController>/5
        [HttpGet("{VacanteId}")]
        public async Task<VacanteDetalleDTO> GetAsync(Guid VacanteId)
        {
            var urlBase = _config["GatewayBaseUrl"];
            var baseUrl = Request.GetTypedHeaders().Headers;
            var vacante = await _mediator.Send(new Consulta.Ejecuta() { Id = VacanteId });
            vacante.SolicitudAutorizacionExcepcionalidadFilePath =(vacante.SolicitudAutorizacionExcepcionalidadFilePath is not null)? $"{urlBase}{vacante.SolicitudAutorizacionExcepcionalidadFilePath}":null;
            return vacante;
        }


        // GET api/<VacanteController>/5
        [HttpGet("Archivo/{Tipo}/{ArchivoId}/{Archivo}")]
        public async Task<FileStreamResult> GetArchivoAsync(string Tipo,Guid ArchivoId,string Archivo)
        {
            return await _mediator.Send(new ArchivoDescarga.Ejecuta(){Tipo = Tipo, ArchivoId = ArchivoId });
        }

        // POST api/<VacanteController>
        [HttpPost]
        public async Task<VacanteNuevoSalidaDTO> Post([FromForm] Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // PUT api/<VacanteController>/5
        [HttpPut]
        public async Task<VacanteNuevoSalidaDTO> PutAsync([FromForm] Edicion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        // DELETE api/<VacanteController>/5
        [HttpDelete("{VacanteId}")]
        public async Task<Unit> DeleteAsync(Guid VacanteId)
        {
            return await _mediator.Send(new Borrado.Ejecuta() { Id = VacanteId });
        }
    }
}
