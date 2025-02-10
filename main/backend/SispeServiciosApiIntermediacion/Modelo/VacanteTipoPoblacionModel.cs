using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteTipoPoblacionModel : EntidadBase
    {
        public int TipoPoblacionId { get; set; }
        public Guid VacanteId { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
