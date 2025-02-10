namespace SispeServicios.Api.Gateway.RemoteModel.Vacante.Salida
{
    public class VacanteSedeEmpresa
    {
        public int? SedeId { get; set; }
        public string? Nombre { get; set; }
        public VacanteUsuarioResponsable Responsable { get; set; }
    }
}
