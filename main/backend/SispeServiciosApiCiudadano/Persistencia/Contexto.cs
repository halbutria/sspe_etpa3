using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.DbContextBase;
using SispeServiciosApiCiudadano.Modelo;
using SispeServiciosApiCiudadano.Modelo.CurriculumAnnexes;
using SispeServiciosApiCiudadano.Modelo.ModelConfigurations;

namespace SispeServicios.Api.Ciudadano.Persistencia
{
    public class Contexto : ContextoBase
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreatingCustum(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<CiudadanoModel>()
               .HasIndex(e => e.TipoDocumentoId);
            modelBuilder.Entity<CiudadanoModel>()
               .HasIndex(e => e.NumeroDocumento);
            modelBuilder.Entity<CiudadanoModel>()
               .HasIndex(e => e.PrimerNombre);
            modelBuilder.Entity<CiudadanoModel>()
              .HasIndex(e => e.SegundoNombre);
            modelBuilder.Entity<CiudadanoModel>()
              .HasIndex(e => e.PrimerApellido);
            modelBuilder.Entity<CiudadanoModel>()
              .HasIndex(e => e.SegundoApellido);
            modelBuilder.Entity<CiudadanoModel>()
              .HasIndex(e => e.FechaCreacion);
            modelBuilder.Entity<CiudadanoModel>()
              .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoModel>()
              .HasIndex(e => e.CorreoElectronico);
            modelBuilder.Entity<CiudadanoModel>()
             .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoCargoInteresModel>()
             .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoEducacionFormalModel>()
             .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoInformacionLaboralModel>()
             .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoEducacionNoFormalModel>()
             .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoIdiomaModel>()
            .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoConocimientoCompetenciaModel>()
             .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoHabilidadDestrezaModel>()
             .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoExperienciaModel>()
            .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoRedesSocialesModel>()
              .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoDiscapacidadesModel>()
                 .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoGrupoEtnicoModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoTipoPoblacionModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoCondicionMentalModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoDireccionModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoDireccionComplementoModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<HabilidadDestrezaInformacionLaboralModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<ConocimientoCompetenciaInformacionLaboralModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<HabilidadDestrezaExperienciaPreviaModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<ConocimientoCompetenciaExperienciaPreviaModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoEducacionFormalExperienciaModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoEducacionFormalExperienciaModel>()
                     .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoServiciosAsociadosModel>()
            .HasIndex(e => e.Eliminado);
            modelBuilder.Entity<CiudadanoServiciosOfertaModel>()
            .HasIndex(e => e.Eliminado);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ModelFactory).Assembly);
        }

        public virtual DbSet<CiudadanoModel> Ciudadano { get; set; }
        public virtual DbSet<CiudadanoTipoNotificacionModel> CiudadanoTipoNotificacion { get; set; }
        public virtual DbSet<CiudadanoCargoInteresModel> CiudadanoCargoInteres { get; set; }
        public virtual DbSet<CiudadanoEducacionFormalModel> CiudadanoEducacionFormal { get; set; }
        public virtual DbSet<CiudadanoInformacionLaboralModel> CiudadanoInformacionLaboral { get; set; }
        public virtual DbSet<CiudadanoEducacionNoFormalModel> CiudadanoEducacionNoFormal { get; set; }
        public virtual DbSet<CiudadanoIdiomaModel> CiudadanoIdioma { get; set; }
        public virtual DbSet<CiudadanoConocimientoCompetenciaModel> CiudadanoConocimientoCompetencia { get; set; }
        public virtual DbSet<CiudadanoHabilidadDestrezaModel> CiudadanoHabilidadDestreza { get; set; }
        public virtual DbSet<CiudadanoExperienciaModel> CiudadanoExperiencia { get; set; }
        public virtual DbSet<CiudadanoRedesSocialesModel> CiudadanoRedesSociales { get; set; }
        public virtual DbSet<CiudadanoDiscapacidadesModel> CiudadanoDiscapacidad { get; set; }
        public virtual DbSet<CiudadanoGrupoEtnicoModel> CiudadanoGrupoEtnico { get; set; }
        public virtual DbSet<CiudadanoTipoPoblacionModel> CiudadanoTipoPoblacion { get; set; }
        public virtual DbSet<CiudadanoCondicionMentalModel> CiudadanoCondicionMental { get; set; }
        public virtual DbSet<ConfiguracionAvanceHojaVidaModel> ConfiguracionAvanceHojaVida { get; set; }
        public virtual DbSet<CiudadanoDireccionModel> CiudadanoDireccion { get; set; }
        public virtual DbSet<CiudadanoDireccionComplementoModel> CiudadanoDireccionComplemento { get; set; }
        public virtual DbSet<HabilidadDestrezaInformacionLaboralModel> CiudadanoHabilidadDestrezaInformacionLaboral { get; set; }
        public virtual DbSet<ConocimientoCompetenciaInformacionLaboralModel> CiudadanoConocimientoCompetenciaInformacionLaboral { get; set; }
        public virtual DbSet<HabilidadDestrezaExperienciaPreviaModel> CiudadanoHabilidadDestrezaExperienciaPrevia { get; set; }
        public virtual DbSet<ConocimientoCompetenciaExperienciaPreviaModel> CiudadanoConocimientoCompetenciaExperienciaPrevia { get; set; }
        public virtual DbSet<CiudadanoEducacionFormalExperienciaModel> CiudadanoEducacionFormalExperiencia { get; set; }
        public virtual DbSet<PersonaModel> PersonaModel { get; set; }
        public DbSet<CiudadanoPersonaViewModel> CiudadanoPersona { get; set; }
        public DbSet<CiudadanoPersonaDireccionComplementoViewModel> CiudadanoPersonaDireccionComplemento { get; set; }
        public virtual DbSet<CurriculumAnnexesModel> AnexosHojaDeVida { get; set; }
        public virtual DbSet<CiudadanoCursoFortalecimiento> CiudadanoCursoFortalecimiento { get; set; }
        public virtual DbSet<CiudadanoNotificacionVacanteDeseada> CiudadanoNotificacionVacanteDeseada { get; set; }
        public virtual DbSet<CiudadanoCriteriosNotificaciones> CiudadanoCriteriosNotificaciones { get; set; }
        public virtual DbSet<CiudadanoPQRSDF> CiudadanoPQRSDF { get; set; }
        public virtual DbSet<TipoPQRSDF> TipoPQRSDF { get; set; }
        public virtual DbSet<BarreraEmpleoModel> BarreraEmpleo { get; set; }
        public virtual DbSet<CiudadanoEncuentasIesModel> CiudadanoEncuentasIes { get; set; }
        public virtual DbSet<CiudadanoServiciosBasicosModel> CiudadanoServiciosBasicos { get; set; }
        public virtual DbSet<CiudadanoServiciosEspecialesModel> CiudadanoServiciosEspeciales { get; set; }
        public virtual DbSet<CiudadanoServiciosAsociadosModel> CiudadanoServiciosAsociados { get; set; }
        public virtual DbSet<CiudadanoServiciosOfertaModel> CiudadanoServiciosOferta { get; set; }
        public virtual DbSet<CiudadanoServiciosBasicosBrechaModel> CiudadanoServiciosBasicosBrecha { get; set; }
    }

    public class ContextoParametrico : ContextoBase
    {
        public ContextoParametrico(DbContextOptions<ContextoParametrico> options) : base(options)
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

    }
}
