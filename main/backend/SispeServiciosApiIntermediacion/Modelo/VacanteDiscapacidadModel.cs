using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteDiscapacidadModel : EntidadBase
    {
        public int DiscapacidadId { get; set; }
        public Guid VacanteId { get; set; }
        public int? IdCarga { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
