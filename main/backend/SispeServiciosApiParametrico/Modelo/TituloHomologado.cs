using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class TituloHomologado : EntidadBase
    {
        public int Id { get; set; }
        public int NivelEducativoId { get; set; }
        public int? NucleoConocimientoId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public NivelEducativo NivelEducativo { get; set; }
        public NucleoConocimiento NucleoConocimiento { get; set; }

    }
}
