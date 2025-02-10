using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CursoFortalecimiento : EntidadBase
    {
        public int Id { get; set; }
        public int TipoCurso { get; set; }
        [MaxLength(200)]
        public string Duracion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
        [MaxLength(200)]
        public string? DescripcionComplementaria { get; set; }
        public bool Estado { get; set; }
    }
}
