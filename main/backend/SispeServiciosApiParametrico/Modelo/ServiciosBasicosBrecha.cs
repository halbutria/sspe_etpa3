using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ServiciosBasicosBrecha : EntidadBase
    {
        public new int Id { get; set; }
        public int ServiciosBasicosId { get; set; }
        public int BrechaServiciosBasicosId { get; set; }

        public ServiciosBasicos ServiciosBasicos { get; set; }
        public BrechaServiciosBasicos BrechaServiciosBasicos { get; set; }
    }
}
