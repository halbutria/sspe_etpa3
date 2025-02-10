using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CriterioVideo : EntidadBase
    {
        public int Id { get; set; }
        public Guid ModuloId { get; set; }
        public string TiempoMaximo { get; set; }
        public string TipoFormato { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
