using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;


namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class TipoPQRSDF : EntidadBase
    {
        public int Id { get; set; }
        [MaxLength(60)]
        public string Descripcion { get; set; }     
    }
}
