using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiParametrico.Modelo
{
    public class ViaPrincipalModel : EntidadBase
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
    }
}
