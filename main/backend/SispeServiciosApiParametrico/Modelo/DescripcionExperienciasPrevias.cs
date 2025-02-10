using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class DescripcionExperienciasPrevias : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Equivalencias { get; set; }
        
    }
}
