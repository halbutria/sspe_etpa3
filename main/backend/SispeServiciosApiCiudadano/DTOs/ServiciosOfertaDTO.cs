namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class ServiciosOfertaDTO
    {
        public Guid? Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int ServiciosOfertaId { get; set; }
        public string CodigoServiciosOferta { get; set; } = string.Empty;
        public string NombreServiciosOferta { get; set; } = string.Empty;
        public int BrechaServiciosOfertaId { get; set; }
        public string CodigoBrechaServiciosOferta { get; set; } = string.Empty;
        public string NombreBrechaServiciosOferta { get; set; } = string.Empty;
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Seguimiento { get; set; } = string.Empty;
        public string? Observacion { get; set; } = string.Empty;
    }
}
