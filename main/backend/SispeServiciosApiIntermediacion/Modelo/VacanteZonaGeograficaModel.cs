using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteZonaGeograficaModel: EntidadBase
    {
        public int VacanteZonaGeograficaId { get; set; }
        public Guid VacanteId { get; set; }
        public int? IdCarga { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
