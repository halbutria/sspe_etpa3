namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class CiudadanoCursoFortalecimientoDTO
    {
        public int Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int CursoFortalecimientoId { get; set; }
        //public Parametrico.Modelo.CursoFortalecimiento CursoFortalecimiento { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int ObtuvoCertificado { get; set; }
        public int EstadoCurso { get; set; }
    }

    public class CiudadanoCursoFortalecimientoRespDTO
    {
        public int Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int CursoFortalecimientoId { get; set; }
        public Parametrico.Modelo.CursoFortalecimiento CursoFortalecimiento { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int ObtuvoCertificado { get; set; }
        public int EstadoCurso { get; set; }
    }
}
