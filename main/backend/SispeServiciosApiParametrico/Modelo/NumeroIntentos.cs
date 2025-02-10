using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class NumeroIntentos : EntidadBase
    {
        public int Id { get; set; }
        public int NumeroIntentosIngreso { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
