using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class IndicadorSatisfaccionDiligenciamiento : EntidadBase
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Pregunta { get; set; }
        [MaxLength(60)]
        public int TipoPreguntasId { get; set; }
        public TipoPreguntas TipoPreguntas { get; set; }
        public string Opciones { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
