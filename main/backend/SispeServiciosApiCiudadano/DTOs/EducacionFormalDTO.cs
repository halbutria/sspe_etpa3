namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class EducacionFormalDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int? NucleoConocimientoId { get; set; }
        public int? NivelEducativoId { get; set; }
        public int? AreaConocimientoId { get; set; }
        public string? TituloObtenido { get; set; }
        public int? TituloHomologadoId { get; set; }
        public string? Institucion { get; set; }
        public int? InstitucionId { get; set; }
        public int? PaisId { get; set; }
        public int? EstadoId { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public bool TarjetaProfesional { get; set; }
        public string? NumeroTarjetaProfesional { get; set; }
        public DateTime? FechaExpedicionTarjetaProfesional { get; set; }
        public string? Observacion { get; set; }
        public bool PracticaEmpresarial { get; set; }
       
    }
}
