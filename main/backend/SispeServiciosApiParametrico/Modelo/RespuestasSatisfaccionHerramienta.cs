using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class RespuestasSatisfaccionHerramienta
    {
        public int Id { get; set; }
        public int RecoleccionIndicSatisHerramientaId { get; set; }
        public RecoleccionIndicSatisHerramienta RecoleccionIndicSatisHerramienta { get; set; }
        [MaxLength(100)]
        public int IdPregunta { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
    }
}
