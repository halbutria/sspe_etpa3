using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiCiudadano.Modelo
{
    public class CiudadanoServiciosEspecialesModel: EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int CodigoServicioEspecial { get; set; }
        public string TipoServicio { get; set; } = string.Empty;
        public int CodigoTipoServicio { get; set; }
    }
}
