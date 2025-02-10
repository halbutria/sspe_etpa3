using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoCondicionMentalModel:EntidadBase
    {
        public int CondicionMentalId { get; set; }
        public Guid CiudadanoId { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}
