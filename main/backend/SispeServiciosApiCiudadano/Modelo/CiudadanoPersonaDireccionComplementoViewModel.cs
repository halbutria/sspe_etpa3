using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    [Table("ComplementoDireccion", Schema = "People")]
    public class CiudadanoPersonaDireccionComplementoViewModel
    {
        
        public string Id { get; set; }
        public string IdDireccion { get; set; }
        public string IdComplemento { get; set; }
        public string NombreComplemento { get; set; } 
        public string Complemento { get; set; }
    }
}
