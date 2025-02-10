namespace SispeServicios.Api.Gateway.RemoteModel.Empresa
{
    public class SedeRemote
    {
        public int? id { get; set; }
        public EmpresaRemote? empresa { get; set; }
        public string? direccion { get; set; }
        public string? telefono { get; set; }
        public List<UsuarioRemote>? usuarios { get; set; }
    }
}
