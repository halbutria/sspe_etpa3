using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteCambioEstadoModel : EntidadBase
    {
        public Guid VacanteId { get; set; }
        public int? EstadoId { get; set; }
        public int? IdCarga { get; set; }
        public VacanteEstadoModel? Estado { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
