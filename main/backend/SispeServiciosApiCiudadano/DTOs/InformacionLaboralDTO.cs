namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class InformacionLaboralDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int TipoExperienciaId { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public bool TrabajoActual { get; set; }
        public int SectorId { get; set; }
        public string TelefonoEmpresa { get; set; }
        public int PaisId { get; set; }
        public string? Funciones { get; set; }
        public string Cargo { get; set; }
        public string OcupacionEquivalenteId { get; set; }
        public string? ProductoServicioProduceComercializa { get; set; }
        public int? CuantasPresonasTrabajanConUsted { get; set; }
        public string[]? ConocimientoCompetenciaInformacionLaboral { get; set; }
        public string[]? HabilidadDestrezaInformacionLaboral { get; set; }
        
    }
}
