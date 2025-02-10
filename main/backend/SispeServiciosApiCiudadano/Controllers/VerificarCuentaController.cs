using MediatR;
using Microsoft.AspNetCore.Mvc;
using SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta;
using SispeServiciosApiCiudadano.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SispeServiciosApiCiudadano.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VerificarCuentaController : ControllerBase
    {
        private IMediator _mediator;

        public VerificarCuentaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<VerificarCuentaDTO>> Get(int TipoDocumentoId, string NumeroDocumento, string email)
        {
            var data = new VerificarCuenta.Ejecuta() { TipoDocumentoId = TipoDocumentoId, NumeroDocumento = NumeroDocumento, email = email };
            return await _mediator.Send(data);
        }

        [HttpGet("verificarPin")]
        public async Task<ActionResult<ValidarPinDTO>> Get(int TipoDocumentoId, string NumeroDocumento, string email, long key, uint pin)
        {
            var data = new ValidarPin.Ejecuta() { TipoDocumentoId = TipoDocumentoId, NumeroDocumento = NumeroDocumento, email = email,key=key,pin=pin };
            var validacion = await _mediator.Send(data);            
            return validacion;
        }
    }
}
