namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class HabilidadDestrezaDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public string? HabilidadId { get; set; }
        public string? Nombre { get; set; }
    }
}
