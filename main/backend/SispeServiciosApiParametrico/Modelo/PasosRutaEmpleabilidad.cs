using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class PasosRutaEmpleabilidad : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
        public List<Direccionamiento> Direccionamientos { get; set; } = new List<Direccionamiento>();
    }
}
