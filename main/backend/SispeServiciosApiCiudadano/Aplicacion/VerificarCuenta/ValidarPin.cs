using MediatR;
using SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta.Common;
using SispeServiciosApiCiudadano.DTOs;
using System.Net.NetworkInformation;

namespace SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta
{
    public class ValidarPin
    {
        public class Ejecuta : IRequest<ValidarPinDTO>
        {
            public string NumeroDocumento { get; set; }
            public int TipoDocumentoId { get; set; }
            public string email { get; set; }
            public long key { get; set; }
            public uint pin { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, ValidarPinDTO>
        {
            public  Task<ValidarPinDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var pinGenerado = Pin.crear(request.email,request.key);
                var validacion = new ValidarPinDTO() { valido = request.pin == pinGenerado.pin };            
                return Task.FromResult(validacion);
            }
        }
    }
    
}
