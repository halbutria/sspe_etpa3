namespace SispeServicios.Api.Usuario.DTOs
{
    public class RespuestaAuntenticacion
    {
        public string? Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
