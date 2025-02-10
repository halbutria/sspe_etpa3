using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ControlSemanaCotizacion : EntidadBase
    {
        public int Id { get; set; }
        public int EdadHombre { get; set; }
        public int EdadMujer { get; set; }
        public int SemanaCotizarHombre { get; set; }
        public int SemanaCotizarMujer { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
