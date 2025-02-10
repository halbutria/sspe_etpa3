using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    [Table("VacanteIdioma")]
    public class VacanteIdiomaModel : EntidadBase
    {
        public int IdiomaId { get; set; }
        public Guid VacanteId { get; set; }
        public int NivelConversacionalId { get; set; }
        public int NivelLecturaId { get; set; }
        public int NivelEscrituraId { get; set; }
        public int NivelEscuchaId { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
