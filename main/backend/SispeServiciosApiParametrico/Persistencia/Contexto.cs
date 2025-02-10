using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.DbContextBase;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServicios.Api.Parametrico.Persistencia
{
    public class Contexto : ContextoBase
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreatingCustum(ModelBuilder modelBuilder)
        {

        }
        public virtual DbSet<TipoDocumento> tipoDocumento { get; set; }
        public virtual DbSet<Departamento> departamento { get; set; }
        public virtual DbSet<Municipio> municipio { get; set; }
        public virtual DbSet<TipoDireccion> tipoDireccion { get; set; }
        public virtual DbSet<TipoCapacitacion> tipoCapacitacion { get; set; }
        public virtual DbSet<TipoUbicacion> tipoUbicacion { get; set; }
        public virtual DbSet<NivelEducativo> nivelEducativo { get; set; }
        public virtual DbSet<Genero> genero { get; set; }
        public virtual DbSet<EstadoCivil> estadoCivil { get; set; }
        public virtual DbSet<GrupoEtnico> grupoEtnico { get; set; }
        public virtual DbSet<TipoSituacionLaboral> tipoSituacionLaboral { get; set; }
        public virtual DbSet<NucleoConocimiento> nucleoConocimiento { get; set; }
        public virtual DbSet<TituloNivelEducativo> tituloNivelEducativo { get; set; }
        public virtual DbSet<CursosComplementarios> cursosComplementarios { get; set; }
        public virtual DbSet<NivelCompetencia> nivelCompetencia { get; set; }
        public virtual DbSet<CompetenciasDuras> competenciasDuras { get; set; }
        public virtual DbSet<Subcompetencia> subCompetencia { get; set; }
        public virtual DbSet<Sector> sector { get; set; }
        public virtual DbSet<Cargo> cargo { get; set; }
        public virtual DbSet<TipoExperiencia> tipoExperiencia { get; set; }
        public virtual DbSet<ClaseAficion> claseAficion { get; set; }
        public virtual DbSet<FrecuenciaAficion> frecuenciaAficion { get; set; }
        public virtual DbSet<Subaficion> subaficion { get; set; }
        public virtual DbSet<Pais> pais { get; set; }
        public virtual DbSet<TipoNotificacion> tipoNotificacion { get; set; }
        public virtual DbSet<PreguntaSeguridad> preguntaSeguridad { get; set; }
        public virtual DbSet<Eps> eps { get; set; }
        public virtual DbSet<CategoriaLicencia> categoriaLicencia { get; set; }
        public virtual DbSet<RangoSalarial> rangoSalarial { get; set; }
        public virtual DbSet<Ocupacion> ocupacion { get; set; }
        public virtual DbSet<EstadoEducacion> estadoEducacion { get; set; }
        public virtual DbSet<MensajePreseleccion> mensajePreseleccion { get; set; }
        public virtual DbSet<Idioma> idioma { get; set; }
        public virtual DbSet<FluidezIdioma> fluidezIdioma { get; set; }
        public virtual DbSet<NivelDominioIdioma> nivelDominioIdioma { get; set; }
        public virtual DbSet<SectorEconomico> sectorEconomico { get; set; }
        public virtual DbSet<SubsectorEconomico> subSectorEconomico { get; set; }
        public virtual DbSet<ModalidadTrabajo> modalidadTrabajo { get; set; }
        public virtual DbSet<AreaEmpresa> areaEmpresa { get; set; }
        public virtual DbSet<MotivoExcepcionalidad> motivoExcepcionalidad { get; set; }
        public virtual DbSet<TipoContrato> tipoContrato { get; set; }
        public virtual DbSet<JornadaLaboral> jornadaLaboral { get; set; }
        public virtual DbSet<PeriodicidadSalarial> periodicidadSalarial { get; set; }
        public virtual DbSet<SituacionActualTrabajo> situacionActualTrabajo { get; set; }
        public virtual DbSet<EstadoEducacionNoFormal> estadoEducacionNoFormal { get; set; }
        public virtual DbSet<AreaConocimiento> areaConocimiento { get; set; }
        public virtual DbSet<Discapacidad> discapacidad { get; set; }
        public virtual DbSet<TituloHomologado> tituloHomologado { get; set; }
        public virtual DbSet<Institucion> institucion { get; set; }
        public virtual DbSet<Profesion> profesion { get; set; }
        public virtual DbSet<DescripcionExperienciasPrevias> descripcionExperienciasPrevias { get; set; }
        public virtual DbSet<TipoSalario> tipoSalario { get; set; }
        public virtual DbSet<CondicionSaludMental> condicionSaludMental { get; set; }
        public virtual DbSet<TipoPoblacion> tipoPoblacion { get; set; }

        public virtual DbSet<Comuna> comuna { get; set; }
        public virtual DbSet<Localidad> localidad { get; set; }
        public virtual DbSet<TipoProyecto> tipoProyecto { get; set; }
        public virtual DbSet<CUOCDenominacion> CUOCdenominacion { get; set; }
        public virtual DbSet<CUOCOcupacion> CUOCocupacion { get; set; }
        public virtual DbSet<CUOCConocimiento> CUOCconocimiento { get; set; }
        public virtual DbSet<CUOCConocimientoOcupacion> CUOCConocimientoOcupacion { get; set; }
        public virtual DbSet<CUOCDestreza> CUOCdestreza { get; set; }
        public virtual DbSet<CUOCDestrezaOcupacion> CUOCdestrezaOcupacion { get; set; }
        public virtual DbSet<CUOCGranGrupo> CUOCgranGrupo { get; set; }
        public virtual DbSet<CUOCGrupoPrimario> CUOCgrupoPrimario { get; set; }
        public virtual DbSet<CUOCFuncion> CUOCfuncion { get; set; }
        public virtual DbSet<ZonaGeografica> zonaGeografica { get; set; }
        public virtual DbSet<TipoZonaGeografica> tipoZonaGeografica { get; set; }

        public virtual DbSet<TipoLibretaMilitar> tipoLibretaMilitar { get; set; }
        public virtual DbSet<EstadoCiudadano> estadoCiudadano { get; set; }
        public virtual DbSet<TipoExperienciaPrevia> tipoExperienciaPrevia { get; set; }
        public virtual DbSet<TipoPoblacionVulnerable> tipoPoblacionVulnerable { get; set; }
        public virtual DbSet<RedSocial> redSocial { get; set; }
        public virtual DbSet<InformacionLaboral> informacionLaboral { get; set; }
        public virtual DbSet<Terminos> terminos { get; set; }
        public virtual DbSet<MotivoRechazo> motivoRechazo { get; set; }
        public virtual DbSet<TipoPrestador> tipoPrestador { get; set; }
        public virtual DbSet<EstadoVacante> estadoVacante { get; set; }

        public virtual DbSet<CriterioMatch> criterioMatch { get; set; }
        public virtual DbSet<PlantillaDescripcionVacante> plantillaDescripcionVacante { get; set; }
        public virtual DbSet<MotivoAmpliarZona> motivoAmpliarZona { get; set; }
        public virtual DbSet<MotivoCambioPrestador> motivoCambioPrestador { get; set; }
        public virtual DbSet<DireccionTipoVia> direccionTipoVia { get; set; }
        public virtual DbSet<DireccionLetra> direccionLetra { get; set; }
        public virtual DbSet<DireccionCuadrante> direccionCuadrante { get; set; }
        public virtual DbSet<DireccionComplemento> direccionComplemento { get; set; }
        public virtual DbSet<InstitucionNivelEducativo> institucionNivelEducativo { get; set; }
        public virtual DbSet<PlantillaMensaje> plantillaMensaje { get; set; }

        public virtual DbSet<AreaInfluencia> areaInfluencia { get; set; }
        public virtual DbSet<DivisionTerritorial> divisionTerritorial { get; set; }
        public virtual DbSet<NucleoConocimientoHidrocarburos> nucleoConocimientoHidrocarburos { get; set; }
        public virtual DbSet<TipoVacante> tipoVacante { get; set; }
        public virtual DbSet<ModuloModel>? Modulo { get; set; }
        public virtual DbSet<RolModel>? Rol { get; set; }
        public virtual DbSet<ModuloRolModel>? ModuloRol { get; set; }
        public virtual DbSet<ModuloRolFuncionalidadModel>? ModuloRolFuncionalidad { get; set; }
        public virtual DbSet<ViaPrincipalModel>? ViaPrincipal { get; set; }
        public virtual DbSet<ViaComplementoModel>? ViaComplemento { get; set; }
        public virtual DbSet<NumeroIntentos> NumeroIntentos { get; set; }
        public virtual DbSet<CierreSesion> CierreSesion { get; set; }
        public virtual DbSet<ControlPesoNumeroArchivosCargar> ControlPesoNumeroArchivosCargar { get; set; }
        public virtual DbSet<EstadoFasesProcesoSeleccion> EstadoFasesProcesoSeleccion { get; set; }
        public virtual DbSet<InactivarCuentaEmpresarial> InactivarCuentaEmpresarial { get; set; }
        public virtual DbSet<IndicadorSatisfaccionDiligenciamiento> IndicadorSatisfaccionDiligenciamiento { get; set; }
        public virtual DbSet<IndicadorSatisfaccionManejoHerramienta> IndicadorSatisfaccionManejoHerramienta { get; set; }
        public virtual DbSet<FlujoEncuestaSatisfaccionAsistIngreso> FlujoEncuestaSatisfaccionAsistIngresos { get; set; }
        public virtual DbSet<PreguntasFrecuentes> PreguntasFrecuentes { get; set; }
        public virtual DbSet<RecepcionNotificaciones> RecepcionNotificaciones { get; set; }
        public virtual DbSet<Notificaciones> Notificaciones { get; set; }
        public virtual DbSet<CanalesNotificacion> CanalesNotificacion { get; set; }
        public virtual DbSet<EncuestaSistema> EncuestaSistema { get; set; }
        public virtual DbSet<Preguntas> Preguntas { get; set; }
        public virtual DbSet<TipoPreguntas> TipoPreguntas { get; set; }
        public virtual DbSet<Direccionamiento> Direccionamientos { get; set; }
        public virtual DbSet<PasosRutaEmpleabilidad> PasosRutaEmpleabilidad { get; set; }
        public virtual DbSet<InactivacionCuenta> InactivacionCuenta { get; set; }
        public virtual DbSet<EstadoCandidato> EstadoCandidato { get; set; }
        public virtual DbSet<CampoCertificadoEstadoVacante> CampoCertificadoEstadoVacantes { get; set; }
        public virtual DbSet<AdministrarNaturaleza> AdministrarNaturaleza { get; set; }
        public virtual DbSet<AdministrarTipo> AdministrarTipo { get; set; }
        public virtual DbSet<AdministrarTamano> AdministrarTamano { get; set; }
        public virtual DbSet<AdministraProgramaEmpleo> AdministraProgramaEmpleo { get; set; }
        public virtual DbSet<AdministraGrupoEspeciales> AdministraGrupoEspecial { get; set; }
        public virtual DbSet<AdministraMotivoProcesoSeleccionCandidato> AdministraMotivoProcesoSeleccionCandidatos { get; set; }
        public virtual DbSet<AdministraPortafolioServicioOrientacionBuscador> AdministraPortafolioServicioOrientacionBuscador { get; set; }
        public virtual DbSet<AdministraPortafolioServicioOrientacionEmpleador> AdministraPortafolioServicioOrientacionEmpleador { get; set; }
        public virtual DbSet<ParametrizaOfertaModalidad> ParametrizaOfertaModalidad { get; set; }
        public virtual DbSet<ParametrizaOfertaModoAsistencia> ParametrizaOfertaModoAsistencia { get; set; }
        public virtual DbSet<ParametrizaOfertaTipoOferta> ParametrizaOfertaTipoOferta { get; set; }
        public virtual DbSet<SemanaCotizar> SemanaCotizar { get; set; }
        public virtual DbSet<ControlSemanaCotizacion> ControlSemanaCotizacion { get; set; }
        public virtual DbSet<CatalogoEstadoCurso> CatalogoEstadoCurso { get; set; }
        public virtual DbSet<CriterioVideo> CriterioVideo { get; set; }
        public virtual DbSet<RecoleccionIndicSatisDiligenciamiento> RecoleccionIndicSatisDiligenciamiento { get; set; }
        public virtual DbSet<RespuestasSatisfaccionDiligenciamiento> RespuestasSatisfaccionDiligenciamiento { get; set; }
        public virtual DbSet<RecoleccionIndicSatisHerramienta> RecoleccionIndicSatisHerramienta { get; set; }
        public virtual DbSet<RespuestasSatisfaccionHerramienta> RespuestasSatisfaccionHerramienta { get; set; }
        public virtual DbSet<ConfiguraPlantillaMensaje> ConfiguraPlantillaMensaje { get; set; }
        public virtual DbSet<MotivoInactivacionBuscador> MotivoInactivacionBuscador { get; set; }
        public virtual DbSet<NotificacionesAlarmas> NotificacionesAlarmas { get; set; }
        public virtual DbSet<CampoSalidaPlanMejoramiento> CampoSalidaPlanMejoramiento { get; set; }
        public virtual DbSet<PrestadoresExternos> PrestadoresExternos { get; set; }
        public virtual DbSet<CursoFortalecimiento> CursoFortalecimiento { get; set; }
        public virtual DbSet<CamposCreacionEmpresaExtrangera> CamposCreacionEmpresaExtrangera { get; set; }
        public virtual DbSet<PaisInternacional> PaisInternacional { get; set; }
        public virtual DbSet<DepartamentoInternacional> DepartamentoInternacional { get; set; }
        public virtual DbSet<MunicipioInternacional> MunicipioInternacional { get; set; }
        public virtual DbSet<BarreraFormacion> BarreraFormacion { get; set; }
        public virtual DbSet<BarreraDestrezas> BarreraDestrezas { get; set; }
        public virtual DbSet<BarreraConocimientoEspecifico> BarreraConocimientoEspecifico { get; set; }
        public virtual DbSet<BarreraManejoTic> BarreraManejoTic { get; set; }
        public virtual DbSet<BarreraServicioAlCliente> BarreraServicioAlCliente { get; set; }
        public virtual DbSet<BarreraGerenciaAdministracion> BarreraGerenciaAdministracion { get; set; }
        public virtual DbSet<EtapaSeguroDesempleo> EtapaSeguroDesempleo { get; set; }

        public virtual DbSet<BarreraDocumentalPreguntas> BarreraDocumentalPreguntas { get; set; }
        public virtual DbSet<BarreraEntornoPreguntas> BarreraEntornoPreguntas { get; set; }
        //HU0099
        public virtual DbSet<ServiciosAsociados> ServiciosAsociados { get; set; }
        public virtual DbSet<ServiciosBasicos> ServiciosBasicos { get; set; }
        public virtual DbSet<ServiciosOferta> ServiciosOferta { get; set; }

        public virtual DbSet<BrechaServiciosAsociados> BrechaServiciosAsociados { get; set; }
        public virtual DbSet<BrechaServiciosBasicos> BrechaServiciosBasicos { get; set; }
        public virtual DbSet<BrechaServiciosOferta> BrechaServiciosOferta { get; set; }

        public virtual DbSet<ServiciosAsociadosBrecha> ServiciosAsociadosBrecha { get; set; }
        public virtual DbSet<ServiciosBasicosBrecha> ServiciosBasicosBrecha { get; set; }
        public virtual DbSet<ServiciosOfertaBrecha> ServiciosOfertaBrecha { get; set; }
        //HU0099
    }

    public class ContextoCiudadano : ContextoBase
    {
        public ContextoCiudadano(DbContextOptions<ContextoCiudadano> options) : base(options)
        {

        }

        protected override void OnModelCreatingCustum(ModelBuilder modelBuilder)
        {

        }
        public virtual DbSet<ConfiguracionAvanceHojaVida> configuracionAvanceHojaVida { get; set; }

    }
}
