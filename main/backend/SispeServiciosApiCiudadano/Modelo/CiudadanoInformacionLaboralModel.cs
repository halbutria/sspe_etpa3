using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoInformacionLaboralModel: EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int TipoExperienciaId { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaRetiro { get; set; }
        public bool TrabajoActual { get; set; }
        public int SectorId { get; set; }
        public string? TelefonoEmpresa { get; set; }
        public int PaisId { get; set; }
        public string? Funciones { get; set; }
        public string Cargo { get; set; }
        public string? OcupacionEquivalenteId { get; set; }
        public string? ProductoServicioProduceComercializa { get; set; }
        public int? CuantasPresonasTrabajanConUsted { get; set; }
        public string? OcupacionEquivalenteAnteriorId { get; set; }
        public int? IdCarga { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
        public ICollection<ConocimientoCompetenciaInformacionLaboralModel>? ConocimientoCompetenciaInformacionLaboral { get; set; }
        public ICollection<HabilidadDestrezaInformacionLaboralModel>? HabilidadDestrezaInformacionLaboral { get; set; }

    }
}