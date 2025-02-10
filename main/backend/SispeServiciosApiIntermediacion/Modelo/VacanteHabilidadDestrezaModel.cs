using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteHabilidadDestrezaModel:EntidadBase
    {
        public string HabilidadDestrezaId { get; set; }
        public Guid VacanteId { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
