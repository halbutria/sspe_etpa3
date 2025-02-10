namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class ConocimientoCompetenciaDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public string? Nombre { get; set; }
        public string? ConocimientoId { get; set; }
    }
}
