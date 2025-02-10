using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class ConocimientoCompetenciaExperienciaPreviaModel : EntidadBase
    {
        public Guid CiudadanoExperienciaId { get; set; }
        public string ConocimientoId { get; set; }
        public CiudadanoExperienciaModel CiudadanoExperiencia { get; set; }
    }
}
