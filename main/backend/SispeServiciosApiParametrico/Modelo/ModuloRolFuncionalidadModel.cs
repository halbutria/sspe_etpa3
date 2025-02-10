using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class ModuloRolFuncionalidadModel : EntidadBase
    {
        public Guid Id { get; set; }
        public Guid IdModulo { get; set; }
        public Guid IdRol { get; set; }
        public string Funcionalidad { get; set; }
    }
}
