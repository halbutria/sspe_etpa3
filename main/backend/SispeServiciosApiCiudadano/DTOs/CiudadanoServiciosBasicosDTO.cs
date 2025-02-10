namespace SispeServiciosApiCiudadano.DTOs
{
    public class CiudadanoServiciosBasicosDTO
    {
        public Guid? Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int CodigoServicio { get; set; }
        public int EstadoServicio { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreServicio { get; set; } = string.Empty;
    }
}
