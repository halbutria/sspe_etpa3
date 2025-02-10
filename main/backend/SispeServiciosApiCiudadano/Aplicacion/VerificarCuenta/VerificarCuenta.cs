using MediatR;
using SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta.Common;
using SispeServiciosApiCiudadano.DTOs;
using System;

namespace SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta
{
    public class VerificarCuenta
    {
        public class Ejecuta : IRequest<VerificarCuentaDTO>
        {
            public string NumeroDocumento { get; set; }
            public int TipoDocumentoId { get; set; }
            public string email { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecuta, VerificarCuentaDTO>
        {
            private readonly IMediator _mediator;
            private readonly IEmailService _email;

            public Manejador(IMediator mediator, IEmailService email)
            {
                _mediator = mediator;
                _email = email;
            }

            public async Task<VerificarCuentaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var respuesta = new VerificarCuentaDTO();
                var existeCuenta = new Existe.Ejecuta() { NumeroDocumento= request.NumeroDocumento,TipoDocumentoId=request.TipoDocumentoId };
                var existeCuentaCommand = await _mediator.Send(existeCuenta);

                if (!existeCuentaCommand.existe)
                {
                    var pin = Pin.crear(request.email);
                    var mensaje = htmlEmail().Replace("@pin", pin.pin.ToString()).Replace("@email", request.email);
                    _email.Send(request.email, "Verificación de cuenta", mensaje);
                    respuesta.key = pin.key;
                }
                respuesta.activo = existeCuentaCommand.activo;
                respuesta.existe = existeCuentaCommand.existe;

                return respuesta;
            }


            private string htmlEmail()
            {
                return @"Hola, @email<br>
                Para continuar con el proceso de registro, ingrese el siguiente código:
                <b>@pin</b>";
            }
        }
    }
}
