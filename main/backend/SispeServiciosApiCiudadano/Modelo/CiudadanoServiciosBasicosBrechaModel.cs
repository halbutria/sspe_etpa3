using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoServiciosBasicosBrechaModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int ServiciosBasicosId { get; set; }
        public string? CodigoServiciosBasicos { get; set; }
        public string? NombreServiciosBasicos { get; set; }
        public int BrechaServiciosBasicosId { get; set; }
        public string? CodigoBrechaServiciosBasicos { get; set; }
        public string? NombreBrechaServiciosBasicos { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Seguimiento { get; set; }
        public string? Observacion { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}