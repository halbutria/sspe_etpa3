using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class PreguntaSeguridad : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
