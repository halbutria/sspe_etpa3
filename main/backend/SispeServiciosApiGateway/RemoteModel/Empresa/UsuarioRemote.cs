namespace SispeServicios.Api.Gateway.RemoteModel.Empresa
{
    public class UsuarioRemote
    {
        public Guid? id { get; set; }
        public int? tipoDocumentoId { get; set; }
        public string? numeroDocumento { get; set; }
        public string? primerNombre { get; set; }
        public string?segundoNombre { get; set; }
        public string? primerApellido { get; set; }
        public string? segundoApellido { get; set; }
        public string? correoElectronico { get; set; }
    }
}
