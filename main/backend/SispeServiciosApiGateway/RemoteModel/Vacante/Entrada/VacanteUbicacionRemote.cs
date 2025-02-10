namespace SispeServicios.Api.Gateway.RemoteModel.Vacante.Entrada
{
    public class VacanteUbicacionRemote
    {
        public string? DepartamentoID { get; set; }
        public string? MunicipioID { get; set; }
        public int? LocalidadComunaId { get; set; }
        public int? NumeroPuestos { get; set; }
    }
}
