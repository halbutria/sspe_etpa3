using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ParametrizaOfertaModoAsistencia: EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
