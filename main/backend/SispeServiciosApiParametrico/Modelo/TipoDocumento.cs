using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class TipoDocumento : EntidadBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Principal { get; set; }
        public string Sigla { get; set; }
        public string Nombre { get; set; }
    }
}
