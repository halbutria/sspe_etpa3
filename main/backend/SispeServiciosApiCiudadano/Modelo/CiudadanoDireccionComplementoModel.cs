using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoDireccionComplementoModel : EntidadBase
    {
        public string? ComplementoId { get; set; }
        public string? ComplementoNombre { get; set; }
        public string? Complemento { get; set; }
        public Guid CiudadanoDireccionId { get; set; }
        public CiudadanoDireccionModel CiudadanoDireccion { get; set;}
    }
}
