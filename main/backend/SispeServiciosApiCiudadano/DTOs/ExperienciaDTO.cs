namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class ExperienciaDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public Guid? CiudadanoEducacionFormalId { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public int TipoExperienciaId { get; set; }
        public string OcupacionId { get; set; }
        public string? LugarExperiencia { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaRetiro { get; set; }
        public string[]? ConocimientoCompetenciaExperienciaPrevia { get; set; }
        public string[]? HabilidadDestrezaExperienciaPrevia { get; set; }
    }
}
