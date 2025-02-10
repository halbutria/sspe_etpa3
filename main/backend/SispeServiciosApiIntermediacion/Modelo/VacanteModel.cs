using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    [Table("Vacante")]
    public class VacanteModel : EntidadBase
    {
        public string? Nombre { get; set; }
        public string Identificador { get; set; }
        public string Numero { get; set; }
        public int? PuestosRequeridos { get; set; }
        public int? ModalidadTrabajoId { get; set; }
        public int? SectorEconomicoId { get; set; }
        public int? SubsectorEconomicoId { get; set; }
        public bool? RequiereViajarPorTrabajo { get; set; }
        public bool? TendraPersonasCargo { get; set; }
        public bool? RequiereLicenciaConduccion { get; set; }
        public bool? RequiereLicenciaConduccionCarro { get; set; }
        public int? CategoriaLicenciaCarroId { get; set; }
        public bool? RequiereLicenciaConduccionMoto { get; set; }
        public int? CategoriaLicenciaMotoId { get; set; }
        public int? AreaEmpresaId { get; set; }
        public Guid? ResponsableId { get; set; }
        public DateTime? FechaEstimadaOcupacionCargo { get; set; }
        public DateTime? FechaVencimientoVacante { get; set; }
        public DateTime? FechaLimiteEnvioHv { get; set; }
        public bool? Confidencial { get; set; }
        public bool? SolicitudExcepcionalidad { get; set; }
        public string? SolicitudAutorizacionExcepcionalidad { get; set; } //url-> archivo
        public bool? AptaParaPersonasConDiscapacidad { get; set; }
        public bool? GestionadaPorPrestador { get; set; }
        public bool? GestionadaPorPrestadorAlterno { get; set; }
        //primero
        public string? FormacionTitulo { get; set; }
        public int? FormacionTituloId { get; set; }
        public bool? Graduado { get; set; }
        public int? NivelMinimoEstudioId { get; set; }
        public bool? RequiereExperienciaGeneral { get; set; }
        public decimal? TiempoExperiencia { get; set; }
        public bool? RequiereExperienciaEspecifica { get; set; }
        public string? DescripcionExperienciaEspecifica { get; set; }
        public bool? RequiereCapacitacionEspecifica { get; set; }
        public string? DescripcionCapacitacionEspecifica { get; set; }
        public bool? RequiereCertificacionEspecifica { get; set; }
        public string? DescripcionCertificacionEspecifica { get; set; }
        public string? InformacionAdicional { get; set; }
        public string? Descripcion { get; set; }
        public int? TipoContratoId { get; set; }
        public int? JornadaLaboralId { get; set; }
        public int? TipoSalarioId { get; set; }
        public int? RangoSalarialInicial { get; set; }
        public int? RangoSalarialFinal { get; set; }
        public int? PeriodicidadSalarialId { get; set; }
        public bool? VisibilidadSalario { get; set; }
        public bool? CompensacionAdicional { get; set; }
        public string? DescripcionCompensacionAdicional { get; set; }
        public string? VideoUrl { get; set; }  //url video
        public string? VideoDescripcion { get; set; }
        public int? EstadoId { get; set; }
        public int? SedeId { get; set; }


        public bool? TieneVideoAdjunto { get; set; }
        public int? TipoProyectoId { get; set; }
        public string? CodigoInternoVacante { get; set; }
        public bool? ManoObraCalificada { get; set; }
        public int? RangoRemitirCandidatoInicial { get; set; }
        public int? RangoRemitirCandidatoFinal { get; set; }
        public bool? PriorizarZonaRural { get; set; }
        public bool? PriorizarPoblacionVulnerable { get; set; }
        public bool? PerteneceARural { get; set; }
        public bool? RegistroVacanteDemasPrestadores { get; set; }
        public bool? EsHidrocarburos { get; set; }
        public string ? NombreZonaGeografica { get; set; }
        public int? IdCarga { get; set; }

        public List<VacantePrestadorAlternoModel>? PrestadoresAlternos { get; set; }
        public List<VacanteIdiomaModel>? Idiomas { get; set; }
        public List<VacanteMotivoExcepcionalidadModel>? MotivosExcepcionalidad { get; set; }
        public List<VacanteDiscapacidadModel>? Discapacidades { get; set; }
        public List<VacanteDenominacionRelacionadaModel>? DenominacionesRelacionadas { get; set; }        
        public List<VacanteConocimientoCompetenciaModel>? ConocimientosCompetencias { get; set; }
        public List<VacanteHabilidadDestrezaModel>? HabilidadesDestrezas { get; set; }
        public List<VacanteUbicacionModel>? Ubicaciones { get; set; }
        public VacanteEstadoModel? Estado { get; set; }
        public List<VacanteArchivoModel>? Archivos { get; set; }
        public List<VacanteCambioEstadoModel>? CambioEstados { get; set; }
        public List<VacantePoblacionVulnerableModel>? PoblacionesVulnerables { get; set; }
        public List<VacanteGrupoEtnicoModel>?GruposEtnicos { get; set; }
        public List<VacanteCondicionSaludMentalModel>? CondicionesSaludMental { get; set; }
        public List<VacanteTipoPoblacionModel>? TiposPoblacion { get; set; }
        public List<VacanteZonaGeograficaModel>? ZonasGeograficas { get; set; }
    }
}
