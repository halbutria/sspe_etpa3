namespace SispeServicios.Api.Intermediacion.DTOs
{
    public class VacanteDetalleDTO
    {
        public Guid? Id { get; set; }
        public string? Identificador { get; set; }
        public string? Nombre { get; set; }
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
        //public IFormFile? SolicitudAutorizacionExcepcionalidadFile { get; set; } //url-> archivo
        //public int? MotivoId { get; set; }
        public bool? AptaParaPersonasConDiscapacidad { get; set; }
        public bool? GestionadaPorPrestador { get; set; }
        public bool? GestionadaPorPrestadorAlterno { get; set; }
        //primero
        public string? FormacionTitulo { get; set; }
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
        public string? SolicitudAutorizacionExcepcionalidadFilePath { get; set; }
        public int SedeId { get; set; }

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
        public string? NombreZonaGeografica { get; set; }

        public VacanteEstadoDTO? Estado { get; set; }
        public List<Guid>? PrestadoresAlternos { get; set; }
        public List<int>? MotivosExcepcionalidad { get; set; }
        public List<int>? Discapacidades { get; set; }
        public List<VacanteIdiomaDTO>? Idiomas { get; set; }
        public List<string>? DenominacionesRelacionadas { get; set; }
        public List<string>? ConocimientosCompetencias { get; set; }
        public List<string>? HabilidadesDestrezas { get; set; }
        public List<int>? PoblacionesVulnerables { get; set; }
        public List<int>? GruposEtnicos { get; set; }
        public List<int>? CondicionesSaludMental { get; set; }
        public List<int>? TiposPoblacion { get; set; }
        public List<VacanteUbicacionDTO>? Ubicaciones { get; set; }
        public List<int>? ZonasGeograficas { get; set; }
    }
}
