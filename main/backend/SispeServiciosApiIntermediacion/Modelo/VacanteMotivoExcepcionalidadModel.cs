using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteMotivoExcepcionalidadModel : EntidadBase
    {
        public int MotivosExcepcionalidadId { get; set; }
        public Guid VacanteId { get; set; }
        public int? IdCarga { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
