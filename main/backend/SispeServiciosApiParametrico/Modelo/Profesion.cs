using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Profesion : EntidadBase
    {
        public int Id { get; set; }
        public int InstitucionId { get; set; }
        public int AreaConocimientoId { get; set; }
        public string Nombre { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual AreaConocimiento AreaConocimiento { get; set; }

    }
}
