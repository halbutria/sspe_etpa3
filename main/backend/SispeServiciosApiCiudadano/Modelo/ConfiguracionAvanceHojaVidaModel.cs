using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class ConfiguracionAvanceHojaVidaModel : EntidadBase
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public decimal? Avance { get; set; }
    }
}
