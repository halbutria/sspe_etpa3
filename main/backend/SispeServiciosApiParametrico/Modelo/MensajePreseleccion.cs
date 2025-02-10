using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class MensajePreseleccion : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Contenido { get; set; }
    }
}
