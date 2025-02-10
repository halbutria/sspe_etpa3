namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class BarreraEmpleoDTO
    {
        public Guid CiudadanoId { get; set; }
        public string TipoBarrera { get; set; }
        public int? CodigoBarrera { get; set; }
        public int? CodigoPregunta { get; set; }
        public int? CodigoRespuesta { get; set; }
        public string? Observaciones { get; set; }
    }
}
