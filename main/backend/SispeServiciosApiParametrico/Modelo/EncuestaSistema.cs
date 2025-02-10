using SispeServicios.DbContextBase.Modelo;
using SispeServiciosApiParametrico.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class EncuestaSistema : EntidadBase
    {
        public int Id { get; set; }
        public Guid ModuloId { get; set; }
        public ModuloModel Modulo { get; set; }
        public string Nombre { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
        public List<Preguntas> Preguntas { get; set; } = new List<Preguntas>();
    }
}
