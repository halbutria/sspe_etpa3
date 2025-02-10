using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class BarreraConocimientoEspecifico : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Respuesta { get; set; }
        public string Modulos { get; set; }
    }
}
