using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ServiciosOferta : EntidadBase
    {
        public new int Id { get; set; }
        public string Codigo { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public ICollection<ServiciosOfertaBrecha> ServiciosOfertaBrecha { get; set; }
    }
}
