using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class ModuloRolModel : EntidadBase
    {
        public Guid Id { get; set; }
        public Guid IdModulo { get; set; }
        public Guid IdRol { get; set; }
    }
}
