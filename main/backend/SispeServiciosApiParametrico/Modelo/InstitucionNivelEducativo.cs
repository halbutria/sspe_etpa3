using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class InstitucionNivelEducativo : EntidadBase
    {
        public int InstitucionId { get; set; }
        public int NivelEducativoId { get; set; }
        public Institucion Institucion { get; set; }
        public NivelEducativo NivelEducativo { get; set; }
    }
}
