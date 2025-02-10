using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ConfiguracionAvanceHojaVida : EntidadBase
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public decimal? Avance { get; set; }
    }
}
