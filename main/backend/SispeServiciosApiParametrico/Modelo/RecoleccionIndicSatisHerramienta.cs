using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class RecoleccionIndicSatisHerramienta : EntidadBase
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Usuario { get; set; }
        public List<RespuestasSatisfaccionHerramienta> Respuestas { get; set; }
        public string Observaciones { get; set; }
    }
}
