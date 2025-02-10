using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class HabilidadDestrezaInformacionLaboralModel:EntidadBase
    {
        public Guid InformacionLaboralId { get; set; }
        public string HabilidadId { get; set; }
        //public string NombreHabilidad { get; set; }
        public CiudadanoInformacionLaboralModel InformacionLaboral { get; set; }
    }
}
