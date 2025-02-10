namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class ServiciosBasicosDTO
    {
        public Guid? Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int ServiciosBasicosId { get; set; }
        public string CodigoServiciosBasicos { get; set; } = string.Empty;
        public string NombreServiciosBasicos { get; set; } = string.Empty;
        public int BrechaServiciosBasicosId { get; set; }
        public string CodigoBrechaServiciosBasicos { get; set; } = string.Empty;
        public string NombreBrechaServiciosBasicos { get; set; } = string.Empty;
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Seguimiento { get; set; } = string.Empty;
        public string? Observacion { get; set; } = string.Empty;
    }
}
