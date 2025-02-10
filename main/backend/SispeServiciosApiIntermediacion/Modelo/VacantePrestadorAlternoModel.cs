using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    [Table("VacantePrestadorAlterno")]
    public class VacantePrestadorAlternoModel : EntidadBase
    {
        public Guid VacanteId { get; set; }
        public Guid PrestadorId { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
