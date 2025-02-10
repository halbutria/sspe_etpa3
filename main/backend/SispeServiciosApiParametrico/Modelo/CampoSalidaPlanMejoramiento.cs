using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CampoSalidaPlanMejoramiento : EntidadBase
    {
        public int Id { get; set; }
        public int NombreCriterio { get; set; }
        public int RangoCriterio { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
