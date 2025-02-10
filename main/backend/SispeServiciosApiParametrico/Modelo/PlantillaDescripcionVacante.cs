using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class PlantillaDescripcionVacante : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Texto { get; set; }
    }
}
