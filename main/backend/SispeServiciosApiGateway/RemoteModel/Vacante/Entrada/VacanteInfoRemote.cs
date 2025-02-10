namespace SispeServicios.Api.Gateway.RemoteModel.Vacante.Entrada
{
    public class VacanteInfoRemote
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaVencimientoVacante { get; set; }
        public DateTime? FechaLimiteEnvioHv { get; set; }
        public List<VacanteUbicacionRemote>? Ubicaciones { get; set; }
        public int? PuestosRequeridos { get; set; }
        public VacanteEstadoRemote? Estado { get; set; }
        public int SedeId { get; set; }
        public Guid? ResponsableId { get; set; }
        public bool? EsHidrocarburos { get; set; }
    }
}
