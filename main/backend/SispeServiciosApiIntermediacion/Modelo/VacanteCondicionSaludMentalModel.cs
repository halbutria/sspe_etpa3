using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteCondicionSaludMentalModel : EntidadBase
    {
        public int CondicionSaludMentalId { get; set; }
        public Guid VacanteId { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
