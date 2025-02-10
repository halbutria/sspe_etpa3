using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCDestreza : EntidadBase
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public ICollection<CUOCDestrezaOcupacion> CUOCDestrezaOcupacion { get; set; }
    }
}
