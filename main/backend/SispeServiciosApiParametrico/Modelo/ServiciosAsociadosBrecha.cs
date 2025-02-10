using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ServiciosAsociadosBrecha : EntidadBase
    {
        public new int Id { get; set; }
        public int ServiciosAsociadosId { get; set; }
        public int BrechaServiciosAsociadosId { get; set; }

        public ServiciosAsociados ServiciosAsociados { get; set; }
        public BrechaServiciosAsociados BrechaServiciosAsociados { get; set; }
    }
}
