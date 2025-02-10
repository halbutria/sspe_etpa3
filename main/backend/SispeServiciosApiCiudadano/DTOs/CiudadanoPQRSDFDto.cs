using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class CiudadanoPQRSDFResponseDto : EntidadBase
    {
        public int Id { get; set; }
        public string Prestador { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public int TipoPQRSDFId { get; set; }
        public TipoPQRSDF TipoPQRSDF { get; set; }
        public string HechosPQR { get; set; }
        public string Radicado { get; set; }
    }

    public class TipoPQRSDFResponseDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
