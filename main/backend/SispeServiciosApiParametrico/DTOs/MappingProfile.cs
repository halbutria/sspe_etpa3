using AutoMapper;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServiciosApiParametrico.DTOs;
using SispeServiciosApiParametrico.Modelo;
using PAreaConocimiento = SispeServicios.Api.Parametrico.Aplicacion.CrudAreaConocimiento.Edicion;
using PAreaInfluencia = SispeServicios.Api.Parametrico.Aplicacion.CrudAreaInfluencia.Edicion;
using PBrechaServiciosAsociados = SispeServicios.Api.Parametrico.Aplicacion.CrudBrechaServiciosAsociados.Edicion;
using PBrechaServiciosBasicos = SispeServicios.Api.Parametrico.Aplicacion.CrudBrechaServiciosBasicos.Edicion;
using PBrechaServiciosOferta = SispeServicios.Api.Parametrico.Aplicacion.CrudBrechaServiciosOferta.Edicion;
using PCategoriaLicencia = SispeServicios.Api.Parametrico.Aplicacion.CrudCategoriaLicencia.Edicion;
using PConfiguracionAvanceHojaVida = SispeServicios.Api.Parametrico.Aplicacion.CrudConfiguracionAvanceHojaVida.Edicion;
using PCriterioMatch = SispeServicios.Api.Parametrico.Aplicacion.CrudCriterioMatch.Edicion;
using PDireccionComplemento = SispeServicios.Api.Parametrico.Aplicacion.CrudDireccionComplemento.Edicion;
using PDireccionCuadrante = SispeServicios.Api.Parametrico.Aplicacion.CrudDireccionCuadrante.Edicion;
using PDireccionLetra = SispeServicios.Api.Parametrico.Aplicacion.CrudDireccionLetra.Edicion;
using PDireccionTipoVia = SispeServicios.Api.Parametrico.Aplicacion.CrudDireccionTipoVia.Edicion;
using PDiscapacidad = SispeServicios.Api.Parametrico.Aplicacion.CrudDiscapacidad.Edicion;
using PDivisionTerritorial = SispeServicios.Api.Parametrico.Aplicacion.CrudDivisionTerritorial.Edicion;
using PEstadoVacante = SispeServicios.Api.Parametrico.Aplicacion.CrudEstadoVacante.Edicion;
using PFluidezIdioma = SispeServicios.Api.Parametrico.Aplicacion.CrudFluidezIdioma.Edicion;
using PGenero = SispeServicios.Api.Parametrico.Aplicacion.CrudGenero.Edicion;
using PIdioma = SispeServicios.Api.Parametrico.Aplicacion.CrudIdioma.Edicion;
using PInformacionLaboral = SispeServicios.Api.Parametrico.Aplicacion.CrudInformacionLaboral.Edicion;
using PInstitucion = SispeServicios.Api.Parametrico.Aplicacion.CrudInstitucion.Edicion;
using PJornadaLaboral = SispeServicios.Api.Parametrico.Aplicacion.CrudJornadaLaboral.Edicion;
using PMensajePreseleccion = SispeServicios.Api.Parametrico.Aplicacion.CrudMensajePreseleccion.Edicion;
using PModalidadTrabajo = SispeServicios.Api.Parametrico.Aplicacion.CrudModalidadTrabajo.Edicion;
using PMotivoAmpliarZona = SispeServicios.Api.Parametrico.Aplicacion.CrudMotivoAmpliarZona.Edicion;
using PMotivoCambioPrestador = SispeServicios.Api.Parametrico.Aplicacion.CrudMotivoCambioPrestador.Edicion;
using PMotivoExcepcionalidad = SispeServicios.Api.Parametrico.Aplicacion.CrudMotivoExcepcionalidad.Edicion;
using PMotivoRechazo = SispeServicios.Api.Parametrico.Aplicacion.CrudMotivoRechazo.Edicion;
using PNivelCompetencia = SispeServicios.Api.Parametrico.Aplicacion.CrudNivelCompetencia.Edicion;
using PNivelDominioIdioma = SispeServicios.Api.Parametrico.Aplicacion.CrudNivelDominioIdioma.Edicion;
using PNivelEducativo = SispeServicios.Api.Parametrico.Aplicacion.CrudNivelEducativo.Edicion;
using PNucleoConocimientoHidrocarburos = SispeServicios.Api.Parametrico.Aplicacion.CrudNucleoConocimientoHidrocarburos.Edicion;
using PPlantillaDescripcionVacante = SispeServicios.Api.Parametrico.Aplicacion.CrudPlantillaDescripcionVacante.Edicion;
using PPlantillaMensaje = SispeServicios.Api.Parametrico.Aplicacion.CrudPlantillaMensaje.Edicion;
using PPreguntaSeguridad = SispeServicios.Api.Parametrico.Aplicacion.CrudPreguntaSeguridad.Edicion;
using PProfesion = SispeServicios.Api.Parametrico.Aplicacion.CrudProfesion.Edicion;
using PRangoSalarial = SispeServicios.Api.Parametrico.Aplicacion.CrudRangoSalarial.Edicion;
using PSectorEconomico = SispeServicios.Api.Parametrico.Aplicacion.CrudSectorEconomico.Edicion;
using PServiciosAsociados = SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosAsociados.Edicion;
using PServiciosAsociadosBrecha = SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosAsociadosBrecha.Edicion;
using PServiciosBasicos = SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosBasicos.Edicion;
using PServiciosBasicosBrecha = SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosBasicosBrecha.Edicion;
using PServiciosOferta = SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosOferta.Edicion;
using PServiciosOfertaBrecha = SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosOfertaBrecha.Edicion;
using PSubsectorEconomico = SispeServicios.Api.Parametrico.Aplicacion.CrudSubsectorEconomico.Edicion;
using PTerminos = SispeServicios.Api.Parametrico.Aplicacion.CrudTerminos.Edicion;
using PTipoCapacitacion = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoCapacitacion.Edicion;
using PTipoContrato = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoContrato.Edicion;
using PTipoDireccion = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoDireccion.Edicion;
using PTipoDocumento = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoDocumento.Edicion;
using PTipoExperiencia = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoExperiencia.Edicion;
using PTipoExperienciaPrevia = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoExperienciaPrevia.Edicion;
using PTipoLibretaMilitar = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoLibretaMilitar.Edicion;
using PTipoNotificacion = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoNotificacion.Edicion;
using PTipoPoblacion = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoPoblacion.Edicion;
using PTipoPoblacionVulnerable = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoPoblacionVulnerable.Edicion;
using PTipoPrestador = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoPrestador.Edicion;
using PTipoProyecto = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoProyecto.Edicion;
using PTipoSalario = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoSalario.Edicion;
using PTipoSituacionLaboral = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoSituacionLaboral.Edicion;
using PTipoUbicacion = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoUbicacion.Edicion;
using PTipoVacante = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoVacante.Edicion;
using PTipoZonaGeografica = SispeServicios.Api.Parametrico.Aplicacion.CrudTipoZonaGeografica.Edicion;
using PTituloNivelEducativo = SispeServicios.Api.Parametrico.Aplicacion.CrudTituloNivelEducativo.Edicion;

namespace SispeServicios.Api.Parametrico.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<origen, destino>();
            //HU286
            CreateMap<PPlantillaMensaje.Ejecuta, PlantillaMensaje>();
            //HU267
            CreateMap<PPreguntaSeguridad.Ejecuta, PreguntaSeguridad>();
            //HU273
            CreateMap<PInstitucion.Ejecuta, Institucion>();
            CreateMap<PProfesion.Ejecuta, Profesion>();
            CreateMap<PAreaConocimiento.Ejecuta, AreaConocimiento>();
            //HU274
            CreateMap<PInformacionLaboral.Ejecuta, InformacionLaboral>();
            //HU276
            CreateMap<PConfiguracionAvanceHojaVida.Ejecuta, ConfiguracionAvanceHojaVida>();
            //HU278
            CreateMap<PNivelEducativo.Ejecuta, NivelEducativo>();
            //HU280
            CreateMap<PCategoriaLicencia.Ejecuta, CategoriaLicencia>();
            //HU281
            CreateMap<PMensajePreseleccion.Ejecuta, MensajePreseleccion>();
            //HU282
            CreateMap<PIdioma.Ejecuta, Idioma>();
            //HU297
            CreateMap<PFluidezIdioma.Ejecuta, FluidezIdioma>();
            CreateMap<PNivelDominioIdioma.Ejecuta, NivelDominioIdioma>();
            //HU300
            CreateMap<PGenero.Ejecuta, Genero>();
            //HU301
            CreateMap<PTipoDocumento.Ejecuta, TipoDocumento>();

            //HU302
            CreateMap<PDireccionTipoVia.Ejecuta, DireccionTipoVia>();
            CreateMap<PTipoDireccion.Ejecuta, TipoDireccion>();
            CreateMap<PDireccionLetra.Ejecuta, DireccionLetra>();
            CreateMap<PDireccionCuadrante.Ejecuta, DireccionCuadrante>();
            CreateMap<PDireccionComplemento.Ejecuta, DireccionComplemento>();
            //HU304
            CreateMap<PTerminos.Ejecuta, Terminos>();
            //HU307
            CreateMap<PModalidadTrabajo.Ejecuta, ModalidadTrabajo>();
            //HU308
            CreateMap<PSectorEconomico.Ejecuta, SectorEconomico>();
            CreateMap<PSubsectorEconomico.Ejecuta, SubsectorEconomico>();
            //HU311
            CreateMap<PDiscapacidad.Ejecuta, Discapacidad>();
            //HU264
            CreateMap<PTipoZonaGeografica.Ejecuta, TipoZonaGeografica>();
            CreateMap<PTipoPoblacionVulnerable.Ejecuta, TipoPoblacionVulnerable>();
            //HU310
            CreateMap<PMotivoExcepcionalidad.Ejecuta, MotivoExcepcionalidad>();
            //HU314
            CreateMap<PTipoContrato.Ejecuta, TipoContrato>();
            CreateMap<PJornadaLaboral.Ejecuta, JornadaLaboral>();
            CreateMap<PRangoSalarial.Ejecuta, RangoSalarial>();
            //HU290
            CreateMap<PMotivoRechazo.Ejecuta, MotivoRechazo>();
            //HU295
            CreateMap<PMotivoCambioPrestador.Ejecuta, MotivoCambioPrestador>();
            //HU299
            CreateMap<PTipoPrestador.Ejecuta, TipoPrestador>();
            //HU270
            CreateMap<PMotivoAmpliarZona.Ejecuta, MotivoAmpliarZona>();
            //HU271
            CreateMap<PPlantillaDescripcionVacante.Ejecuta, PlantillaDescripcionVacante>();
            //HU306
            CreateMap<PEstadoVacante.Ejecuta, EstadoVacante>();
            //HU315
            CreateMap<PAreaInfluencia.Ejecuta, AreaInfluencia>();
            CreateMap<PDivisionTerritorial.Ejecuta, DivisionTerritorial>();
            //HU316
            CreateMap<PTipoProyecto.Ejecuta, TipoProyecto>();
            //HU317
            CreateMap<PNucleoConocimientoHidrocarburos.Ejecuta, NucleoConocimientoHidrocarburos>();
            //HU320
            CreateMap<PCriterioMatch.Ejecuta, CriterioMatch>();
            CreateMap<PTipoVacante.Ejecuta, TipoVacante>();
            CreateMap<PTipoCapacitacion.Ejecuta, TipoCapacitacion>();
            CreateMap<PTipoExperiencia.Ejecuta, TipoExperiencia>();
            CreateMap<PTipoExperienciaPrevia.Ejecuta, TipoExperienciaPrevia>();
            CreateMap<PTipoLibretaMilitar.Ejecuta, TipoLibretaMilitar>();
            CreateMap<PTipoNotificacion.Ejecuta, TipoNotificacion>();
            CreateMap<PTipoPoblacion.Ejecuta, TipoPoblacion>();
            CreateMap<PTipoSalario.Ejecuta, TipoSalario>();
            CreateMap<PTipoSituacionLaboral.Ejecuta, TipoSituacionLaboral>();
            CreateMap<PTipoUbicacion.Ejecuta, TipoUbicacion>();
            CreateMap<PTituloNivelEducativo.Ejecuta, TituloNivelEducativo>();
            CreateMap<PTituloNivelEducativo.Ejecuta, TituloNivelEducativo>();
            CreateMap<PNivelCompetencia.Ejecuta, NivelCompetencia>();

            CreateMap<TipoDocumento, ParametricoDTO>();
            CreateMap<Departamento, ParametricoDTO>();
            CreateMap<Municipio, ParametricoDTO>();
            CreateMap<TipoDireccion, ParametricoDTO>();
            CreateMap<TipoCapacitacion, ParametricoDTO>();
            CreateMap<TipoUbicacion, ParametricoDTO>();
            CreateMap<NivelEducativo, ParametricoDTO>();
            CreateMap<Genero, ParametricoDTO>();
            CreateMap<EstadoCivil, ParametricoDTO>();
            CreateMap<Aplicacion.CrudEstadoCivil.Edicion.Ejecuta, EstadoCivil>().ReverseMap();
            CreateMap<Aplicacion.CrudNumeroIntentosIngreso.Edicion.Ejecuta, NumeroIntentos>().ReverseMap();
            CreateMap<GrupoEtnico, ParametricoDTO>();
            CreateMap<Aplicacion.CrudGrupoEtnico.Edicion.Ejecuta, GrupoEtnico>().ReverseMap();
            CreateMap<TipoSituacionLaboral, ParametricoDTO>();
            CreateMap<NucleoConocimiento, ParametricoDTO>();
            CreateMap<TituloNivelEducativo, ParametricoDTO>();
            CreateMap<CursosComplementarios, ParametricoDTO>();
            CreateMap<NivelCompetencia, ParametricoDTO>();
            CreateMap<CompetenciasDuras, ParametricoDTO>();
            CreateMap<Subcompetencia, ParametricoDTO>();
            CreateMap<Sector, ParametricoDTO>();
            CreateMap<Cargo, ParametricoDTO>();
            CreateMap<TipoExperiencia, ParametricoDTO>();
            CreateMap<ClaseAficion, ParametricoDTO>();
            CreateMap<FrecuenciaAficion, ParametricoDTO>();
            CreateMap<Subaficion, ParametricoDTO>();
            CreateMap<TipoNotificacion, ParametricoDTO>();
            CreateMap<PreguntaSeguridad, ParametricoDTO>();
            CreateMap<Eps, ParametricoDTO>();
            CreateMap<CategoriaLicencia, ParametricoDTO>();
            CreateMap<RangoSalarial, ParametricoDTO>();
            CreateMap<Ocupacion, ParametricoDTO>();
            CreateMap<EstadoEducacion, ParametricoDTO>();
            CreateMap<MensajePreseleccion, ParametricoDTO>();
            CreateMap<Idioma, ParametricoDTO>();
            CreateMap<FluidezIdioma, ParametricoDTO>();
            CreateMap<NivelDominioIdioma, ParametricoDTO>();
            CreateMap<SectorEconomico, ParametricoDTO>();
            CreateMap<SubsectorEconomico, ParametricoDTO>();
            CreateMap<ModalidadTrabajo, ParametricoDTO>();
            CreateMap<AreaEmpresa, ParametricoDTO>();
            CreateMap<MotivoExcepcionalidad, ParametricoDTO>();
            CreateMap<TipoContrato, ParametricoDTO>();
            CreateMap<JornadaLaboral, ParametricoDTO>();
            CreateMap<PeriodicidadSalarial, ParametricoDTO>();
            CreateMap<SituacionActualTrabajo, ParametricoDTO>();
            CreateMap<EstadoEducacionNoFormal, ParametricoDTO>();
            CreateMap<AreaConocimiento, ParametricoDTO>();
            CreateMap<Discapacidad, ParametricoDTO>();
            CreateMap<TituloHomologado, ParametricoDTO>();
            CreateMap<Institucion, ParametricoDTO>();
            CreateMap<Profesion, ParametricoDTO>();
            CreateMap<DescripcionExperienciasPrevias, ParametricoDTO>();
            CreateMap<TipoSalario, ParametricoDTO>();
            CreateMap<CondicionSaludMental, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCondicionSaludMental.Edicion.Ejecuta, CondicionSaludMental>().ReverseMap();
            CreateMap<TipoPoblacion, ParametricoDTO>();
            CreateMap<Localidad, ParametricoDTO>();
            CreateMap<Comuna, ParametricoDTO>();
            CreateMap<TipoProyecto, ParametricoDTO>();

            CreateMap<CUOCOcupacion, ParametricoDTO>();
            CreateMap<CUOCDenominacion, ParametricoDTO>();
            CreateMap<CUOCConocimiento, ParametricoDTO>();
            CreateMap<CUOCDestreza, ParametricoDTO>();
            CreateMap<NumeroIntentos, ParametricoDTO>();

            CreateMap<CUOCConocimientoOcupacion, ParametricoDTO>()
              .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.CUOCConocimiento.Nombre))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CUOCConocimiento.Id));
            ;
            CreateMap<CUOCDestrezaOcupacion, ParametricoDTO>()
              .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.CUOCDestreza.Nombre))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CUOCDestreza.Id));
            ;

            CreateMap<TipoZonaGeografica, ParametricoDTO>();
            CreateMap<ZonaGeografica, ParametricoDTO>();
            CreateMap<TipoLibretaMilitar, ParametricoDTO>();
            CreateMap<EstadoCiudadano, ParametricoDTO>();
            CreateMap<TipoExperienciaPrevia, ParametricoDTO>();
            CreateMap<TipoPoblacionVulnerable, ParametricoDTO>();
            CreateMap<RedSocial, ParametricoDTO>();

            CreateMap<Terminos, ParametricoDTO>();
            CreateMap<MotivoRechazo, ParametricoDTO>();
            CreateMap<TipoPrestador, ParametricoDTO>();
            CreateMap<TipoPrestador, ParametricoDTO>();

            //CreateMap<EstadoVacante, SalarioMinimoDTO>();
            CreateMap<EstadoVacante, ParametricoDTO>();

            CreateMap<CriterioMatch, ParametricoDTO>();
            CreateMap<TipoVacante, ParametricoDTO>();
            CreateMap<PlantillaDescripcionVacante, ParametricoDTO>();
            CreateMap<MotivoAmpliarZona, ParametricoDTO>();
            CreateMap<MotivoCambioPrestador, ParametricoDTO>();
            CreateMap<DireccionTipoVia, ParametricoDTO>();
            CreateMap<DireccionLetra, ParametricoDTO>();
            CreateMap<DireccionCuadrante, ParametricoDTO>();
            CreateMap<DireccionComplemento, ParametricoDTO>();

            CreateMap<ConfiguracionAvanceHojaVida, ParametricoDTO>();

            CreateMap<DivisionTerritorial, ParametricoDTO>();
            CreateMap<AreaInfluencia, ParametricoDTO>();
            CreateMap<NucleoConocimientoHidrocarburos, ParametricoDTO>();

            CreateMap<InstitucionNivelEducativo, ParametricoDTO>();
            CreateMap<InformacionLaboral, ParametricoDTO>();
            CreateMap<PlantillaMensaje, ParametricoDTO>();

            CreateMap<ModuloModel, ModuloDTO>().ReverseMap();
            CreateMap<RolModel, RolDTO>().ReverseMap();
            CreateMap<ModuloRolModel, ModuloRolDTO>().ReverseMap();
            CreateMap<ModuloRolFuncionalidadModel, ModuloRolFuncionalidadDTO>().ReverseMap();
            CreateMap<ViaPrincipalModel, ViaPrincipalDTO>().ReverseMap();
            CreateMap<ViaComplementoModel, ViaComplementoDTO>().ReverseMap();


            CreateMap<CierreSesion, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCierreSesion.Edicion.Ejecuta, CierreSesion>();

            CreateMap<ControlPesoNumeroArchivosCargar, ParametricoDTO>();
            CreateMap<Aplicacion.CrudControlPesoNumeroArchivosCargar.Edicion.Ejecuta, ControlPesoNumeroArchivosCargar>();

            CreateMap<EstadoFasesProcesoSeleccion, ParametricoDTO>();
            CreateMap<Aplicacion.CrudEstadoFasesProcesoSeleccion.Edicion.Ejecuta, EstadoFasesProcesoSeleccion>().ReverseMap();

            CreateMap<Aplicacion.CrudInactivarCuentaEmpresarial.Edicion.Ejecuta, InactivarCuentaEmpresarial>().ReverseMap();
            CreateMap<InactivarCuentaEmpresarial, ParametricoDTO>()
            .ForMember(dest => dest.Opciones, opt => opt.MapFrom(src =>
                src.Opciones != null ?
                src.Opciones.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .Where((item, index) => !string.IsNullOrWhiteSpace(item))
                .ToList() :
                new List<string>()))
            .ReverseMap()
            .ForMember(dest => dest.Opciones, opt => opt.MapFrom(src =>
                src.Opciones != null ?
                string.Join("", src.Opciones.Select(o => $"[{o}]")) :
                ""));

            CreateMap<Aplicacion.CrudIndicadorSatisfaccionDiligenciamiento.Edicion.Ejecuta, IndicadorSatisfaccionDiligenciamiento>().ReverseMap();
            CreateMap<IndicadorSatisfaccionDiligenciamiento, ParametricoDTO>()
            .ForMember(dest => dest.Opciones, opt => opt.MapFrom(src =>
                src.Opciones != null ?
                src.Opciones.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .Where((item, index) => !string.IsNullOrWhiteSpace(item))
                .ToList() :
                new List<string>()))
            .ReverseMap()
            .ForMember(dest => dest.Opciones, opt => opt.MapFrom(src =>
                src.Opciones != null ?
                string.Join("", src.Opciones.Select(o => $"[{o}]")) :
                ""));

            CreateMap<Aplicacion.CrudIndicadorSatisfaccionManejoHerramienta.Edicion.Ejecuta, IndicadorSatisfaccionManejoHerramienta>().ReverseMap();
            CreateMap<IndicadorSatisfaccionManejoHerramienta, ParametricoDTO>()
            .ForMember(dest => dest.Opciones, opt => opt.MapFrom(src =>
                src.Opciones != null ?
                src.Opciones.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .Where((item, index) => !string.IsNullOrWhiteSpace(item))
                .ToList() :
                new List<string>()))
            .ReverseMap()
            .ForMember(dest => dest.Opciones, opt => opt.MapFrom(src =>
                src.Opciones != null ?
                string.Join("", src.Opciones.Select(o => $"[{o}]")) :
                ""));


            CreateMap<FlujoEncuestaSatisfaccionAsistIngreso, ParametricoDTO>();
            CreateMap<Aplicacion.CrudFlujoEncuestaSatisfaccionAsistIngreso.Edicion.Ejecuta, FlujoEncuestaSatisfaccionAsistIngreso>().ReverseMap();

            CreateMap<PreguntasFrecuentes, ParametricoDTO>();
            CreateMap<Aplicacion.CrudPreguntasFrecuentes.Edicion.Ejecuta, PreguntasFrecuentes>().ReverseMap();

            CreateMap<NotificacionesDTO, Notificaciones>().ReverseMap();
            CreateMap<RecepcionNotificaciones, ParametricoDTO>().ReverseMap();
            CreateMap<Aplicacion.CrudRecepcionNotificaciones.Edicion.Ejecuta, RecepcionNotificaciones>()
            .ForMember(dest => dest.Notificaciones, opt => opt.MapFrom(src => src.Notificaciones));
            CreateMap<NotificacionesUpdDTO, Notificaciones>().ReverseMap();

            CreateMap<CanalesNotificacion, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCanalesNotificacion.Edicion.Ejecuta, CanalesNotificacion>().ReverseMap();

            CreateMap<Aplicacion.CrudEncuestaSistema.Edicion.Ejecuta, EncuestaSistema>()
                .ForMember(dest => dest.Modulo, opt => opt.MapFrom(src => src.ModuloId))
                .ForMember(dest => dest.Preguntas, opt => opt.MapFrom(src => src.Preguntas.Select(p => new Preguntas
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    TipoPreguntasId = p.Tipo,
                    Opciones = p.Opciones != null && p.Opciones.Any() ? String.Join("", p.Opciones.Select(o => $"[{o}]")) : ""
                }).ToList())).ReverseMap();

            CreateMap<EncuestaSistema, ParametricoDTO>()
                .ForMember(dest => dest.Preguntas, opt => opt.MapFrom(src => src.Preguntas.Select(p => new Preguntas
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    EncuestaSistemaId = p.EncuestaSistemaId,
                    TipoPreguntasId = p.TipoPreguntasId,
                    Opciones = p.Opciones,
                    TipoPreguntas = p.TipoPreguntas

                }).ToList()))
                .ForMember(dest => dest.Modulo, opt => opt.MapFrom(src => src.Modulo))
                .ReverseMap();
            CreateMap<PreguntasUpdDto, Preguntas>().ReverseMap();


            CreateMap<TipoPreguntas, ParametricoDTO>();

            CreateMap<Aplicacion.CrudPasosRutaEmpleabilidad.Edicion.Ejecuta, PasosRutaEmpleabilidad>()
            .ForMember(dest => dest.Direccionamientos, opt => opt.MapFrom(src => src.Direccionamientos.Select(p => new Direccionamiento { Nombre = p }).ToList()));
            CreateMap<PasosRutaEmpleabilidad, ParametricoDTO>()
                .ForMember(dest => dest.Direccionamientos, opt => opt.MapFrom(src => src.Direccionamientos.Select(p => p.Nombre).ToList()));

            CreateMap<InactivacionCuenta, ParametricoDTO>()
           .ForMember(dest => dest.RolModels, opt => opt.MapFrom(src => new List<RolModel> {
               new RolModel { Id = src.RolModelId, Descripcion =  src.RolModel.Descripcion } }));


            CreateMap<Aplicacion.CrudInactivacionCuenta.Edicion.Ejecuta, InactivacionCuenta>()
                .ForMember(dest => dest.RolModelId, opt => opt.MapFrom(src => src.RolModelId));

            CreateMap<List<InactivacionCuenta>, List<ParametricoDTO>>()
                .ConvertUsing((src, dest, context) => src.Select(x => context.Mapper.Map<ParametricoDTO>(x)).ToList());

            CreateMap<EstadoCandidato, ParametricoDTO>();
            CreateMap<Aplicacion.CrudEstadoCandidato.Edicion.Ejecuta, EstadoCandidato>().ReverseMap();

            CreateMap<CampoCertificadoEstadoVacante, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCampoCertificadoEstadoVacante.Edicion.Ejecuta, CampoCertificadoEstadoVacante>().ReverseMap();

            CreateMap<AdministrarNaturaleza, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministrarNaturaleza.Edicion.Ejecuta, AdministrarNaturaleza>().ReverseMap();

            CreateMap<AdministrarTipo, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministrarTipo.Edicion.Ejecuta, AdministrarTipo>().ReverseMap();

            CreateMap<AdministrarTamano, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministrarTamano.Edicion.Ejecuta, AdministrarTamano>().ReverseMap();

            CreateMap<AdministraProgramaEmpleo, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministraProgramaEmpleo.Edicion.Ejecuta, AdministraProgramaEmpleo>().ReverseMap();

            CreateMap<AdministraGrupoEspeciales, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministraGrupoEspeciales.Edicion.Ejecuta, AdministraGrupoEspeciales>().ReverseMap();

            CreateMap<AdministraMotivoProcesoSeleccionCandidato, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministraMotivoProcesoSeleccionCandidato.Edicion.Ejecuta, AdministraMotivoProcesoSeleccionCandidato>().ReverseMap();

            CreateMap<AdministraPortafolioServicioOrientacionBuscador, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministraPortafolioServicioOrientacionBuscador.Edicion.Ejecuta, AdministraPortafolioServicioOrientacionBuscador>().ReverseMap();

            CreateMap<AdministraPortafolioServicioOrientacionEmpleador, ParametricoDTO>();
            CreateMap<Aplicacion.CrudAdministraPortafolioServicioOrientacionEmpleador.Edicion.Ejecuta, AdministraPortafolioServicioOrientacionEmpleador>().ReverseMap();

            CreateMap<ParametrizaOfertaModalidad, ParametricoDTO>();
            CreateMap<Aplicacion.CrudParametrizaOfertaModalidad.Edicion.Ejecuta, ParametrizaOfertaModalidad>().ReverseMap();

            CreateMap<ParametrizaOfertaModoAsistencia, ParametricoDTO>();
            CreateMap<Aplicacion.CrudParametrizaOfertaModoAsistencia.Edicion.Ejecuta, ParametrizaOfertaModoAsistencia>().ReverseMap();

            CreateMap<ParametrizaOfertaTipoOferta, ParametricoDTO>();
            CreateMap<Aplicacion.CrudParametrizaOfertaTipoOferta.Edicion.Ejecuta, ParametrizaOfertaTipoOferta>().ReverseMap();

            CreateMap<SemanaCotizar, ParametricoDTO>();
            CreateMap<Aplicacion.CrudSemanaCotizar.Edicion.Ejecuta, SemanaCotizar>().ReverseMap();

            CreateMap<ControlSemanaCotizacion, ParametricoDTO>();
            CreateMap<Aplicacion.CrudControlSemanaCotizacion.Edicion.Ejecuta, ControlSemanaCotizacion>().ReverseMap();

            CreateMap<CatalogoEstadoCurso, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCatalogoEstadoCurso.Edicion.Ejecuta, CatalogoEstadoCurso>().ReverseMap();

            CreateMap<CriterioVideo, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCriterioVideo.Edicion.Ejecuta, CriterioVideo>().ReverseMap();

            CreateMap<RecoleccionIndicSatisDiligenciamiento, ParametricoDTO>()
                 .ForMember(dest => dest.RespuestasSatisfaccionDiligenciamientos, opt => opt.MapFrom(src => src.Respuestas.Select(p => new RespuestasSatisfaccionDiligenciamiento
                 {
                     Id = p.Id,
                     IdPregunta = p.IdPregunta,
                     Pregunta = p.Pregunta,
                     Respuesta = p.Respuesta

                 }).ToList()))
                 .ReverseMap();


            CreateMap<RecoleccionIndicSatisHerramienta, ParametricoDTO>()
                 .ForMember(dest => dest.RespuestasSatisfaccionHerramienta, opt => opt.MapFrom(src => src.Respuestas.Select(p => new RespuestasSatisfaccionHerramienta
                 {
                     Id = p.Id,
                     IdPregunta = p.IdPregunta,
                     Pregunta = p.Pregunta,
                     Respuesta = p.Respuesta

                 }).ToList()))
                 .ReverseMap();

            CreateMap<ConfiguraPlantillaMensaje, ParametricoDTO>();
            CreateMap<Aplicacion.CrudConfiguraPlantillaMensaje.Edicion.Ejecuta, ConfiguraPlantillaMensaje>().ReverseMap();

            CreateMap<MotivoInactivacionBuscador, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCriterioVideo.Edicion.Ejecuta, MotivoInactivacionBuscador>().ReverseMap();

            CreateMap<NotificacionesAlarmas, ParametricoDTO>();
            CreateMap<Aplicacion.CrudNotificacionesAlarmas.Edicion.Ejecuta, NotificacionesAlarmas>().ReverseMap();

            CreateMap<CampoSalidaPlanMejoramiento, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCampoSalidaPlanMejoramiento.Edicion.Ejecuta, CampoSalidaPlanMejoramiento>().ReverseMap();

            CreateMap<PrestadoresExternos, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCriterioVideo.Edicion.Ejecuta, PrestadoresExternos>().ReverseMap();

            CreateMap<CursoFortalecimiento, ParametricoDTO>();
            CreateMap<Aplicacion.CrudCursoFortalecimiento.Edicion.Ejecuta, CursoFortalecimiento>().ReverseMap();

            CreateMap<CamposCreacionEmpresaExtrangera, ParametricoDTO>()
                .ForMember(dest => dest.TipoEmpresa, opt => opt.MapFrom(src => src.Tipo));

            CreateMap<Aplicacion.CrudCamposCreacionEmpresaExtrangera.Edicion.Ejecuta, CamposCreacionEmpresaExtrangera>()
                .ForMember(dest => dest.Tipo, opt => opt.MapFrom(src => src.TipoEmpresa))
                .ReverseMap();

            CreateMap<Pais, ParametricoDTO>().ReverseMap();
            CreateMap<PaisInternacional, ParametricoDTO>().ReverseMap();
            CreateMap<Aplicacion.CrudPaisInternacional.Edicion.Ejecuta, PaisInternacional>().ReverseMap();

            CreateMap<DepartamentoInternacional, ParametricoDTO>().ReverseMap();
            CreateMap<Aplicacion.CrudDepartamentoInternacional.Edicion.Ejecuta, DepartamentoInternacional>()
                //.ForMember(dest => dest.PaisInternacional, opt => opt.Ignore()) // Ignorar para evitar errores de mapeo automáticos.
                .ForMember(dest => dest.PaisInternacionalId, opt => opt.MapFrom(src => src.PaisInternacionalId))
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Codigo))
                .ForMember(dest => dest.Sigla, opt => opt.MapFrom(src => src.Sigla))
                .ForMember(dest => dest.Latitud, opt => opt.MapFrom(src => src.Latitud))
                .ForMember(dest => dest.Longitud, opt => opt.MapFrom(src => src.Longitud))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre));


            CreateMap<MunicipioInternacional, ParametricoDTO>().ReverseMap();
            CreateMap<Aplicacion.CrudMunicipioInternacional.Edicion.Ejecuta, MunicipioInternacional>()
                .ForMember(dest => dest.DepartamentoInternacionalId, opt => opt.MapFrom(src => src.DepartamentoInternacionalId))
                .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.Codigo))
                .ForMember(dest => dest.Sigla, opt => opt.MapFrom(src => src.Sigla))
                .ForMember(dest => dest.Latitud, opt => opt.MapFrom(src => src.Latitud))
                .ForMember(dest => dest.Longitud, opt => opt.MapFrom(src => src.Longitud))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre));

            CreateMap<BarreraFormacion, ParametricoDTO>();
            CreateMap<BarreraDestrezas, ParametricoDTO>();
            CreateMap<BarreraConocimientoEspecifico, ParametricoDTO>();
            CreateMap<BarreraManejoTic, ParametricoDTO>();
            CreateMap<BarreraServicioAlCliente, ParametricoDTO>();
            CreateMap<BarreraGerenciaAdministracion, ParametricoDTO>();
            CreateMap<EtapaSeguroDesempleo, ParametricoDTO>();
            CreateMap<BarreraDocumentalPreguntas, ParametricoDTO>();
            CreateMap<BarreraEntornoPreguntas, ParametricoDTO>();

            //HU0099
            CreateMap<PServiciosAsociados.Ejecuta, ServiciosAsociados>();
            CreateMap<ServiciosAsociados, ParametricoDTO>();
            CreateMap<PServiciosBasicos.Ejecuta, ServiciosBasicos>();
            CreateMap<ServiciosBasicos, ParametricoDTO>();
            CreateMap<PServiciosOferta.Ejecuta, ServiciosOferta>();
            CreateMap<ServiciosOferta, ParametricoDTO>();

            CreateMap<PBrechaServiciosAsociados.Ejecuta, BrechaServiciosAsociados>();
            CreateMap<BrechaServiciosAsociados, ParametricoDTO>();
            CreateMap<PBrechaServiciosBasicos.Ejecuta, BrechaServiciosBasicos>();
            CreateMap<BrechaServiciosBasicos, ParametricoDTO>();
            CreateMap<PBrechaServiciosOferta.Ejecuta, BrechaServiciosOferta>();
            CreateMap<BrechaServiciosOferta, ParametricoDTO>();

            CreateMap<PServiciosAsociadosBrecha.Ejecuta, SispeServicios.Api.Parametrico.Modelo.ServiciosAsociadosBrecha>();
            CreateMap<SispeServicios.Api.Parametrico.Modelo.ServiciosAsociadosBrecha, ParametricoDTO>()
              .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.BrechaServiciosAsociados.Nombre))
              .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.BrechaServiciosAsociados.Codigo))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BrechaServiciosAsociados.Id));

            CreateMap<PServiciosBasicosBrecha.Ejecuta, SispeServicios.Api.Parametrico.Modelo.ServiciosBasicosBrecha>();
            CreateMap<SispeServicios.Api.Parametrico.Modelo.ServiciosBasicosBrecha, ParametricoDTO>()
              .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.BrechaServiciosBasicos.Nombre))
              .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.BrechaServiciosBasicos.Codigo))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BrechaServiciosBasicos.Id));

            CreateMap<PServiciosOfertaBrecha.Ejecuta, SispeServicios.Api.Parametrico.Modelo.ServiciosOfertaBrecha>();
            CreateMap<SispeServicios.Api.Parametrico.Modelo.ServiciosOfertaBrecha, ParametricoDTO>()
              .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.BrechaServiciosOferta.Nombre))
              .ForMember(dest => dest.Codigo, opt => opt.MapFrom(src => src.BrechaServiciosOferta.Codigo))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BrechaServiciosOferta.Id));
            //HU0099
        }
    }
}
