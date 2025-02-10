using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoExperienciaModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        //public Guid EducacionFormalId { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public int TipoExperienciaId { get; set; }
        public string OcupacionId { get; set; }
        public string? LugarExperiencia { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaRetiro { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
       // public CiudadanoEducacionFormalModel EducacionFormal { get; set; } 
        public ICollection<ConocimientoCompetenciaExperienciaPreviaModel>? ConocimientoCompetenciaExperienciaPrevia { get; set; }
        public ICollection<HabilidadDestrezaExperienciaPreviaModel>? HabilidadDestrezaExperienciaPrevia { get; set; }
        public ICollection<CiudadanoEducacionFormalExperienciaModel>? CiudadanoEducacionFormalExperiencia { get; set; }
    }
}