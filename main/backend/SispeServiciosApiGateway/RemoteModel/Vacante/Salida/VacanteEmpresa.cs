namespace SispeServicios.Api.Gateway.RemoteModel.Vacante.Salida
{
    public class VacanteEmpresa
    {
        public string? RazonSocial { get; set; }
        public VacanteSedeEmpresa? Sede { get; set; }
    }
}
