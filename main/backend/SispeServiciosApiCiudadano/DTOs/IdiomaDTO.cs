namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class IdiomaDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int IdiomaId { get; set; }
        public string Idioma { get; set; }
        public string NivelEscrito { get; set; }
        public string NivelHablado { get; set; }
        public string NivelEscucha { get; set; }
        public string NivelLectura { get; set; }
    }
}
