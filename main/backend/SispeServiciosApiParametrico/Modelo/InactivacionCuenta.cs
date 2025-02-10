using SispeServicios.DbContextBase.Modelo;
using SispeServiciosApiParametrico.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class InactivacionCuenta : EntidadBase
    {
        public int Id { get; set; }
        public int Meses { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
        public Guid RolModelId { get; set; }
        public RolModel RolModel { get; set; }
    }

}
