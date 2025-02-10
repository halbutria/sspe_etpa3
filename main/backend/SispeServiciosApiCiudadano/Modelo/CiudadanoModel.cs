using SispeServicios.DbContextBase.Modelo;


namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoModel : EntidadBase
    {
        public Guid? UsuarioId { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public string CorreoElectronico { get; set; }
        public string PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int SexoId { get; set; }
        public string Telefono { get; set; }
        public string DireccionResidencia { get; set; }
        public int PaisResidenciaId { get; set; }
        public string? DepartamentoResidenciaId { get; set; }
        public string? MunicipioResidenciaId { get; set; }
        public string PrestadorPreferenciaId { get; set; }
        public string PuntoAtencionId { get; set; }
        public int? PreguntaSeguridadId { get; set; }
        public string? PreguntaSeguridadRespuesta { get; set; }
        public bool TerminosCondiciones { get; set; }
        public bool TratamientoDatosPersonales { get; set; }
        public decimal? PorcentajeRegistro { get; set; }
        public decimal? PorcentajeHv { get; set; }
        public decimal? PorcentajeInfoPersonal { get; set; }
        public decimal? PorcentajeEduFormal { get; set; }
        public decimal? PorcentajeInfoLaboral { get; set; }
        public decimal? PorcentajeEduNoFormal { get; set; }
        public int? LocalidadComunaId { get; set; }
        public int? GeneroId { get; set; }
        public string? CualGenero { get; set; }
        public int? OrientacionSexualId { get; set; }
        public string? CualOrientacionSexual { get; set; }
        public string? PreguntaLibre { get; set; }
        public bool? DispuestoDesplazarseDiariamente { get; set; }
        public bool? DispuestoCambiarMunicipio { get; set; }
        public bool? Activo { get; set; } = true;
        // opcionales
        public int? EstadoCivilId { get; set; }
        public int? PaisNacimientoId { get; set; }
        public bool? TieneLibretaMilitar { get; set; }
        public int? TipoLibretaMilitarId { get; set; }
        public string? NumeroLibretaMiltar { get; set; }
        public string? DepartamentoNacimientoId { get; set; }
        public string? MunicipioNacimientoId { get; set; }
        public int? NacionalidadId { get; set; }
        public bool? JefeHogar { get; set; }
        public bool? PoblacionFocalizada { get; set; }
        public bool? Sisben { get; set; }
        public int? EpsId { get; set; }
        public string? BarrioResidencia { get; set; }
        public bool? PerteneceARural { get; set; }
        public string? OtroTelefono { get; set; }
        public string? Observacion { get; set; }
        public int? RangoSalarialId { get; set; }
        public int? Estrato { get; set; }
        public string? PerfilLaboral { get; set; }
        public bool? PosibilidadViajar { get; set; }
        public bool? PosibilidadTrasladarse { get; set; }
        public bool? InteresOfertasTeletrabajo { get; set; }
        public int? SituacionLaboralActualId { get; set; }
        public bool? PropiedadMedioTransporte { get; set; }
        public bool? TieneLicenciaConduccionCarro { get; set; }
        public int? CategoriaLicenciaCarroId { get; set; }
        public bool? TieneLicenciaConduccionMoto { get; set; }
        public int? CategoriaLicenciaMotoId { get; set; }
        public bool? TieneEducacionFormal { get; set; }
        public bool? InteresPracticaEmpresarial { get; set; }
        public bool? TieneInformacionLaboral { get; set; }
        public bool? TieneEducacionNoFormal { get; set; }
        public bool? TieneExperienciaLaboral { get; set; }
        public int? TipoDocumentoAdicionalId { get; set; }
        public string? NumeroDocumentoAdicional { get; set; }
        public bool? Autorregistro { get; set; }
        public bool? HojaVidaCompleta { get; set; }
        public int? EstadoCiudadanoId { get; set; }
        public string? CodigoPostal { get; set; }
        public int? IdCarga { get; set; }


        public DateTime? FechaTerminosCondiciones { get; set; }
        public DateTime? FechaTratamientoDatos { get; set; }
        public DateTime? FechaExpedicionDocumento { get; set; }
        public string? Estado { get; set; }
        public string? Ciudad { get; set; }
        public bool? CertificadoResidencia { get; set; }
        public string? EstadoNacimiento { get; set; }
        public string? CiudadNacimiento { get; set; }
        public SispeServiciosApiCiudadano.Modelo.Parametricos.Pais? Nacionalidad { get; set; }
        public SispeServiciosApiCiudadano.Modelo.Parametricos.Genero? Genero { get; set; }
        public SispeServiciosApiCiudadano.Modelo.Parametricos.Pais? PaisResidencia { get; set; }

        public ICollection<CiudadanoTipoNotificacionModel>? TipoNotificacion { get; set; }
        public ICollection<CiudadanoCargoInteresModel>? CargoInteres { get; set; }
        public ICollection<CiudadanoEducacionFormalModel>? EducacionFormal { get; set; }
        public ICollection<CiudadanoInformacionLaboralModel>? InformacionLaboral { get; set; }
        public ICollection<CiudadanoEducacionNoFormalModel>? EducacionNoFormal { get; set; }
        public ICollection<CiudadanoExperienciaModel>? ExperienciaPrevia { get; set; }
        public ICollection<CiudadanoRedesSocialesModel>? RedSocial { get; set; }
        public ICollection<CiudadanoDiscapacidadesModel>? Discapacidad { get; set; }
        public ICollection<CiudadanoGrupoEtnicoModel>? GrupoEtnico { get; set; }
        public ICollection<CiudadanoTipoPoblacionModel>? TipoPoblacion { get; set; }
        public ICollection<CiudadanoCondicionMentalModel>? CondicionMental { get; set; }
        public ICollection<CiudadanoDireccionModel>? Direcciones { get; set; }
        public ICollection<CiudadanoHabilidadDestrezaModel>? Destrezas { get; set; }
        public ICollection<CiudadanoIdiomaModel>? Idiomas { get; set; }
        public ICollection<CiudadanoServiciosAsociadosModel>? ServiciosAsociados { get; set; }
        public ICollection<CiudadanoServiciosOfertaModel>? ServiciosOferta { get; set; }
        public ICollection<CiudadanoServiciosBasicosBrechaModel>? ServiciosBasicos { get; set; }
    }
}
