namespace SispeServicios.Api.Gateway.RemoteModel
{
    public class InformacionLaboraInputRemote
    {
        public Guid? Id { get; set; }
        public Guid? CiudadanoId { get; set; }
        public ParametricoIntRemote? TipoExperiencia { get; set; }
        public string? NombreEmpresa { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public bool? TrabajoActual { get; set; }
        public ParametricoIntRemote? Sector { get; set; }
        public string? TelefonoEmpresa { get; set; }
        public ParametricoIntRemote? Pais { get; set; }
        public string? Cargo { get; set; }
        public ParametricoIntRemote? CargoEquivalente { get; set; }
        public ParametricoIntRemote? OcupacionEquivalente { get; set; }
        public ParametricoIntRemote? Conocimiento { get; set; }
        public ParametricoIntRemote? Habilidad { get; set; }        
    }
}
