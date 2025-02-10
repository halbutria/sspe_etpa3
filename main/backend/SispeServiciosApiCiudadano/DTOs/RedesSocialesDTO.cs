namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class RedesSocialesDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int RedSocialId { get; set; }
        public string NombreRedSocial { get; set; }
        public string NombreUsuarioRedSocial { get; set; }
    }
}
