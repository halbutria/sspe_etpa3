using SispeServicios.DbContextBase.Modelo;


namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoCursoFortalecimiento : EntidadBase
    {
        public int Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int CursoFortalecimientoId { get; set; }
        //public Parametrico.Modelo.CursoFortalecimiento CursoFortalecimiento { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public int ObtuvoCertificado { get; set; }
        public int EstadoCurso { get; set; }
    }
}
