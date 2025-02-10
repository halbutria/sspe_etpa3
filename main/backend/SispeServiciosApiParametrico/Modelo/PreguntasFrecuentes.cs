using SispeServicios.DbContextBase.Modelo;
using SispeServiciosApiParametrico.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class PreguntasFrecuentes : EntidadBase
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public bool Estado { get; set; }
        public string Respuesta { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
        public Guid ModuloId { get; set; }
        public ModuloModel Modulo { get; set; }
    }
}
