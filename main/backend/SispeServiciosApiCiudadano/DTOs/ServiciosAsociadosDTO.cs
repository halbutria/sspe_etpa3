namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class ServiciosAsociadosDTO
    {
        public Guid? Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int ServiciosAsociadosId { get; set; }
        public string CodigoServiciosAsociados { get; set; } = string.Empty;
        public string NombreServiciosAsociados { get; set; } = string.Empty;
        public int BrechaServiciosAsociadosId { get; set; }
        public string CodigoBrechaServiciosAsociados { get; set; } = string.Empty;
        public string NombreBrechaServiciosAsociados { get; set; } = string.Empty;
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Seguimiento { get; set; } = string.Empty;
        public string? Observacion { get; set; } = string.Empty;
    }
}
