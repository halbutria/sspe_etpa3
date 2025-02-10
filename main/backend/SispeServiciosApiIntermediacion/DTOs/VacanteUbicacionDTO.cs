namespace SispeServicios.Api.Intermediacion.DTOs
{
    public class VacanteUbicacionDTO
    {
        public string DepartamentoID { get; set; }
        public string MunicipioID { get; set; }
        public int? LocalidadComunaId { get; set; }
        public int NumeroPuestos { get; set; }
    }
}
