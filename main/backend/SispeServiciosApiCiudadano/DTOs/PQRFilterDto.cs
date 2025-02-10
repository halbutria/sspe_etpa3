using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class PQRFilterDto
    {
        public string? Prestador { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? TipoIdentificacionPrestador { get; set; }
        public string? IdentificacionPrestador { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int? TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public int? TipoPQRSDFId { get; set; }
        public int? Radicado { get; set; }
    }
}
