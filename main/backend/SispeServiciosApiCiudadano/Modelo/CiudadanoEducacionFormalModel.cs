using SispeServicios.DbContextBase.Modelo;
using SispeServiciosApiCiudadano.Modelo.Parametricos;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoEducacionFormalModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int? NucleoConocimientoId { get; set; }
        public int NivelEducativoId { get; set; }
        public int? AreaConocimientoId { get; set; }
        public string? TituloObtenido { get; set; }
        public int? TituloHomologadoId { get; set; }
        public string? Institucion { get; set; }
        public int? InstitucionId { get; set; }
        public int? PaisId { get; set; }
        public int EstadoId { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public bool? TarjetaProfesional { get; set; }
        public String? NumeroTarjetaProfesional { get; set; }
        public DateTime? FechaExpedicionTarjetaProfesional { get; set; }
        public string? Observacion { get; set; }
        public bool PracticaEmpresarial { get; set; }
        public int? IdCarga { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
        public NivelEducativo  NivelEducativo { get; set; }
        //public ICollection<CiudadanoExperienciaModel>? CiudadanoExperiencia { get; set; }
        public ICollection<CiudadanoEducacionFormalExperienciaModel>? CiudadanoEducacionFormalExperiencia { get; set; }
    }
}
