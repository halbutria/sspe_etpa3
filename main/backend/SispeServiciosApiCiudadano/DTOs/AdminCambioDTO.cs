namespace SispeServiciosApiCiudadano.DTOs
{
    public class AdminCambioDTO
    {
        public string? correo { get; set; }
        public string? password { get; set; }
        public int PreguntaSeguridadId { get; set; }
        public string? PreguntaSeguridadRespuesta { get; set; }
        public string? PreguntaLibre { get; set; }
        public string? Prestador { get; set; }
    }
}
