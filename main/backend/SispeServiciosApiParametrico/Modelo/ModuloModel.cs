using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class ModuloModel : EntidadBase
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; }

    }
}
