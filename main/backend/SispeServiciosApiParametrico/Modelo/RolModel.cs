using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class RolModel : EntidadBase
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
    }
}
