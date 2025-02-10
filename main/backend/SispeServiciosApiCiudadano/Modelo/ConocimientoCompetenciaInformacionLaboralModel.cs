using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class ConocimientoCompetenciaInformacionLaboralModel : EntidadBase
    {
        public Guid InformacionLaboralId { get; set; }
        public string ConocimientoId { get; set; }
        public CiudadanoInformacionLaboralModel InformacionLaboral { get; set; }
    }
}
