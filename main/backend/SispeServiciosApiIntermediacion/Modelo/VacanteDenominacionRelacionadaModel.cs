using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteDenominacionRelacionadaModel : EntidadBase
    {
        public string? DenominacionRelacionadaId { get; set; }
        public string? DenominacionRelacionadaAnteriorId { get; set; }
        public int? IdCarga { get; set; }
        public Guid VacanteId { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
