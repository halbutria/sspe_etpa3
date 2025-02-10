namespace SispeServiciosApiCiudadano.DTOs
{
    public class LoginDTO
    {
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string password { get; set; } = null!;
    }
}
