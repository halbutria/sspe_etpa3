using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class HabilidadDestrezaExperienciaPreviaModel : EntidadBase
    {
        public Guid ExperienciapreviaId { get; set; }
        public string HabilidadId { get; set; }
        public CiudadanoExperienciaModel Experienciaprevia { get; set; }
    }
}
