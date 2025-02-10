using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteUbicacionModel : EntidadBase
    {
        public string DepartamentoId { get; set; }
        public string MunicipioId { get; set; }
        public int? LocalidadComunaId { get; set; }
        public int NumeroPuestos { get; set; }
        public int? IdCarga { get; set; }
        public VacanteModel Vacante { get; set; }
        public int? PaisId { get; set; }
    }
}
