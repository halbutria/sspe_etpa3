using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Preguntas : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int EncuestaSistemaId { get; set; }
        public EncuestaSistema EncuestaSistema { get; set; }
        public int TipoPreguntasId { get; set; }
        public TipoPreguntas TipoPreguntas { get; set; }
        public string Opciones { get; set; }

    }
}
