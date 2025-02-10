using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CierreSesion : EntidadBase
    {
        public int Id { get; set; }
        public string? TiempoInactividad { get; set; }
        public string? TiempoActividad { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
