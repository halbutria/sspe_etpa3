using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoTipoPoblacionModel:EntidadBase
    {
        public int TipoPoblacionId { get; set; }
        public Guid CiudadanoId { get; set; }
        public int? IdCarga { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}
