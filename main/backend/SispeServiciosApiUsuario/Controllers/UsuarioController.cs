using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SispeServicios.Api.Usuario.Aplicacion;
using SispeServicios.Api.Usuario.DTOs;

namespace SispeServicios.Api.Usuario.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IMediator _mediator;

        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [Route("/api/[controller]/crear")]
        public async Task<ActionResult<UsuarioInfo>> crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);

        }

        [HttpPost]
        [Route("/api/[controller]/informacion")]
        public async Task<ActionResult<UsuarioInfo>> info(UsuarioInformacion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        [HttpPost]
        [Route("/api/[controller]/login")]
        public async Task<ActionResult<RespuestaAuntenticacion>>autenticacion(Autenticacion.Ejecuta data)
        {
            return await _mediator.Send(data);
        }
    }
}
