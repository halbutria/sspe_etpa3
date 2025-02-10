using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class MotivoInactivacionBuscador : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
