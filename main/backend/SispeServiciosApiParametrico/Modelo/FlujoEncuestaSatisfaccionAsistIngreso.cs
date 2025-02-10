using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class FlujoEncuestaSatisfaccionAsistIngreso : EntidadBase
    {
        public int Id { get; set; }
        [MaxLength(60)]
        public string Pregunta { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
