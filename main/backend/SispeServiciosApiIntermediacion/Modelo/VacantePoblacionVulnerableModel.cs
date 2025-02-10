using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacantePoblacionVulnerableModel : EntidadBase
    {
        public int PoblacionVulnerableId { get; set; }
        public Guid VacanteId { get; set; }
        public VacanteModel Vacante { get; set; }
        public int? IdCarga { get; set; }
    }
}
