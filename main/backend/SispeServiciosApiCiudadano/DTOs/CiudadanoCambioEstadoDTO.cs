using SispeServicios.Api.Ciudadano.RemoteModel;
using System.Text.Json.Serialization;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class CiudadanoCambioEstadoDTO
    {
        public Guid Id { get; set; }
        public bool Activo { get; set; }
    }
}
