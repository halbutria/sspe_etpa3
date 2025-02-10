using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ServiciosAsociados : EntidadBase
    {
        public new int Id { get; set; }
        public string Codigo { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public ICollection<ServiciosAsociadosBrecha> ServiciosAsociadosBrecha { get; set; }
    }
}
