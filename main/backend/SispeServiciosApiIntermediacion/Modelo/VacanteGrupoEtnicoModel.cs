using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteGrupoEtnicoModel : EntidadBase
    {
        public int GrupoEtnicoId { get; set; }
        public Guid VacanteId { get; set; }
        public VacanteModel Vacante { get; set; }
    }
}
