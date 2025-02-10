using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoServiciosOfertaModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int ServiciosOfertaId { get; set; }
        public string? CodigoServiciosOferta { get; set; }
        public string? NombreServiciosOferta { get; set; }
        public int BrechaServiciosOfertaId { get; set; }
        public string? CodigoBrechaServiciosOferta { get; set; }
        public string? NombreBrechaServiciosOferta { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Seguimiento { get; set; }
        public string? Observacion { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}