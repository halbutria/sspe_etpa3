using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoEducacionFormalExperienciaModel:EntidadBase
    {
        public Guid CiudadanoExperienciaId { get; set; }
        public Guid CiudadanoEducacionFormalId { get; set; }
        public CiudadanoExperienciaModel CiudadanoExperiencia { get; set; }
        public CiudadanoEducacionFormalModel CiudadanoEducacionFormal { get; set; }

    }
}
