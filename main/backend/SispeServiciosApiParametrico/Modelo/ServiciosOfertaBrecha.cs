using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ServiciosOfertaBrecha : EntidadBase
    {
        public new int Id { get; set; }
        public int ServiciosOfertaId { get; set; }
        public int BrechaServiciosOfertaId { get; set; }

        public ServiciosOferta ServiciosOferta { get; set; }
        public BrechaServiciosOferta BrechaServiciosOferta { get; set; }
    }
}
