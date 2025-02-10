using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class PrestadoresExternos : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
