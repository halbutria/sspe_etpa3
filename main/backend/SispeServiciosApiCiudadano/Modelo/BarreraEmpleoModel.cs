using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class BarreraEmpleoModel: EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public string TipoBarrera { get; set; }
        public int? CodigoBarrera { get; set; }
        public int? CodigoPregunta { get; set; }
        public int? CodigoRespuesta { get; set; }
        public string? Observaciones { get; set; }

    }
}
