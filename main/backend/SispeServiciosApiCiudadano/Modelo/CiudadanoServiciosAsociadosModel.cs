using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoServiciosAsociadosModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int ServiciosAsociadosId { get; set; }
        public string? CodigoServiciosAsociados { get; set; }
        public string? NombreServiciosAsociados { get; set; }
        public int BrechaServiciosAsociadosId { get; set; }
        public string? CodigoBrechaServiciosAsociados { get; set; }
        public string? NombreBrechaServiciosAsociados { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Seguimiento { get; set; }
        public string? Observacion { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}