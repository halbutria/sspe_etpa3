namespace SispeServicios.Api.Intermediacion.DTOs
{
    public class VacanteInfoDTO
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaVencimientoVacante { get; set; }
        public DateTime? FechaLimiteEnvioHv { get; set; }
        public List<VacanteUbicacionDTO>? Ubicaciones { get; set; }
        public int? PuestosRequeridos { get; set; }
        public VacanteEstadoDTO? Estado { get; set; }
        public int SedeId { get; set; }
        public Guid? ResponsableId { get; set; }
        public bool? EsHidrocarburos { get; set; }
    }
}
