using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiCiudadano.Modelo
{
    public class CiudadanoServiciosBasicosModel: EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int CodigoServicio { get; set; }
        public int EstadoServicio { get; set; }
        public DateTime Fecha { get; set; }
    }
}
