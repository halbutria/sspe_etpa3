using AutoMapper;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.RemoteModel;
using SispeServiciosApiCiudadano.DTOs;
using SispeServiciosApiCiudadano.DTOs.Curriculum;
using SispeServiciosApiCiudadano.Modelo;
using SispeServiciosApiCiudadano.Modelo.CurriculumAnnexes;
using CiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano;
using ConocimientoCompetenciaCiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.ConocimientoCompetencia;
using EducacionFormalApp = SispeServicios.Api.Ciudadano.Aplicacion.EducacionFormal;
using EducacionNoFirmalApp = SispeServicios.Api.Ciudadano.Aplicacion.EducacionNoFormal;
using ExperienciaPreviaApp = SispeServicios.Api.Ciudadano.Aplicacion.Experiencia;
using HabilidadDestrezaCiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.HabilidadDestreza;
using IdiomaCiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.Idioma;
using InformacionLaboralApp = SispeServicios.Api.Ciudadano.Aplicacion.InformacionLaboral;
using RedesSocialesCiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.RedesSociales;
using ServiciosAsociadosCiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.ServiciosAsociados;
using ServiciosBasicosCiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.ServiciosBasicos;
using ServiciosOfertaCiudadanoApp = SispeServicios.Api.Ciudadano.Aplicacion.ServiciosOferta;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<origen, destino>();
            CreateMap<CiudadanoModel, CiudadanoCambioEstadoDTO>();
            CreateMap<CiudadanoModel, CiudadanoInfoDTO>()
                .ForMember(dest => dest.CargoIneteres, opt => opt.Ignore())
                .ForMember(dest => dest.CondicionDiscapacidad, opt => opt.Ignore())
                .ForMember(dest => dest.CondicionSaludMental, opt => opt.Ignore())
                .ForMember(dest => dest.GrupoEtnico, opt => opt.Ignore())
                .ForMember(dest => dest.TipoPoblacion, opt => opt.Ignore());
            CreateMap<CiudadanoModel, CiudadanoVisualizacionDTO>()
                .ForMember(dest => dest.CargoIneteres, opt => opt.Ignore())
                .ForMember(dest => dest.CondicionDiscapacidad, opt => opt.Ignore())
                .ForMember(dest => dest.CondicionSaludMental, opt => opt.Ignore())
                .ForMember(dest => dest.GrupoEtnico, opt => opt.Ignore())
                .ForMember(dest => dest.TipoPoblacion, opt => opt.Ignore());
            CreateMap<CiudadanoApp.Nuevo.Ejecuta, CiudadanoModel>()
               .ForMember(dest => dest.TipoNotificacion, opt => opt.Ignore());
            CreateMap<CiudadanoApp.Edicion.Ejecuta, CiudadanoModel>()
               .ForMember(dest => dest.TipoNotificacion, opt => opt.Ignore());

            CreateMap<CiudadanoModel, PorcentajesAvanceDTO>();
            CreateMap<CiudadanoCargoInteresModel, string>().ConvertUsing(source => source.CargoInteresId);
            CreateMap<CiudadanoGrupoEtnicoModel, int>().ConvertUsing(source => source.GrupoEtnicoId);
            CreateMap<CiudadanoDiscapacidadesModel, int>().ConvertUsing(source => source.DisacapacidaId);
            CreateMap<CiudadanoCondicionMentalModel, int>().ConvertUsing(source => source.CondicionMentalId);
            CreateMap<CiudadanoTipoPoblacionModel, int>().ConvertUsing(source => source.TipoPoblacionId);

            CreateMap<CiudadanoCargoInteresModel, ParametricoIntDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CargoInteresId));

            CreateMap<CiudadanoTipoNotificacionModel, TipoNotificacionDTO>();

            CreateMap<InformacionLaboralApp.Nuevo.Ejecuta, CiudadanoInformacionLaboralModel>()
                .ForMember(dest => dest.ConocimientoCompetenciaInformacionLaboral, opt => opt.Ignore())
                .ForMember(dest => dest.HabilidadDestrezaInformacionLaboral, opt => opt.Ignore());
            CreateMap<InformacionLaboralApp.Edicion.Ejecuta, CiudadanoInformacionLaboralModel>()
                .ForMember(dest => dest.ConocimientoCompetenciaInformacionLaboral, opt => opt.Ignore())
                .ForMember(dest => dest.HabilidadDestrezaInformacionLaboral, opt => opt.Ignore());
            CreateMap<CiudadanoInformacionLaboralModel, InformacionLaboralDTO>();
            //.ForMember(dest => dest.ConocimientoCompetenciaInformacionLaboral, opt => opt.Ignore())
            //.ForMember(dest => dest.HabilidadDestrezaInformacionLaboral, opt => opt.Ignore()); ;
            //.ForMember(dest => dest.ConocimientoCompetenciaInformacionLaboral, opt => opt.MapFrom(src => src.ConocimientoCompetenciaInformacionLaboral))
            //.ForMember(dest => dest.HabilidadDestrezaInformacionLaboral, opt => opt.MapFrom(src => src.HabilidadDestrezaInformacionLaboral));

            //CreateMap<string, ConocimientoCompetenciaInformacionLaboralModel>().ForMember(dest => dest.ConocimientoId, opt => opt.MapFrom(src => src));
            //CreateMap<string, HabilidadDestrezaInformacionLaboralModel>().ForMember(dest => dest.HabilidadId, opt => opt.MapFrom(src => src));

            CreateMap<ConocimientoCompetenciaInformacionLaboralModel, string>().ConvertUsing(source => source.ConocimientoId);
            CreateMap<HabilidadDestrezaInformacionLaboralModel, string>().ConvertUsing(source => source.HabilidadId);

            CreateMap<ExperienciaPreviaApp.Nuevo.Ejecuta, CiudadanoExperienciaModel>()
                .ForMember(dest => dest.ConocimientoCompetenciaExperienciaPrevia, opt => opt.Ignore())
                .ForMember(dest => dest.HabilidadDestrezaExperienciaPrevia, opt => opt.Ignore());
            CreateMap<ExperienciaPreviaApp.Edicion.Ejecuta, CiudadanoExperienciaModel>()
                .ForMember(dest => dest.ConocimientoCompetenciaExperienciaPrevia, opt => opt.Ignore())
                .ForMember(dest => dest.HabilidadDestrezaExperienciaPrevia, opt => opt.Ignore());
            CreateMap<CiudadanoExperienciaModel, ExperienciaDTO>()
                .ForMember(dest => dest.CiudadanoEducacionFormalId, opt => opt.Ignore()); //opt.MapFrom("CiudadanoEducacionFormalExperiencia.CiudadanoEducacionFormalId")); //.MapFrom(src => src.CiudadanoEducacionFormalId));

            // CreateMap<CiudadanoEducacionFormalExperienciaModel, Guid>().ConvertUsing(source => source.CiudadanoEducacionFormalId);
            CreateMap<ConocimientoCompetenciaExperienciaPreviaModel, string>().ConvertUsing(source => source.ConocimientoId);
            CreateMap<HabilidadDestrezaExperienciaPreviaModel, string>().ConvertUsing(source => source.HabilidadId);

            /////////////////////////////////////////////////
            //CreateMap<CiudadanoExperienciaModel, ExperienciaDTO>()
            //    .ForMember(dest => dest.CiudadanoInformacionLaboralId, opt => opt.MapFrom("CiudadanoInformacionLaboralExperiencia.CiudadanoInformacionLaboralId"));

            CreateMap<EducacionFormalApp.Nuevo.Ejecuta, CiudadanoEducacionFormalModel>();
            CreateMap<EducacionFormalApp.Edicion.Ejecuta, CiudadanoEducacionFormalModel>();
            CreateMap<CiudadanoEducacionFormalModel, EducacionFormalDTO>();



            //.ForMember(dest => dest.TituloNivelEducativo, opt => opt.MapFrom(src => new ParametricoIntDTO() { Id = src.TituloNivelEducativo }))
            //.ForMember(dest => dest.Pais, opt => opt.MapFrom(src => new ParametricoIntDTO() { Id = src.PaisId }))

            CreateMap<IdiomaCiudadanoApp.Nuevo.Ejecuta, CiudadanoIdiomaModel>();
            CreateMap<IdiomaCiudadanoApp.Edicion.Ejecuta, CiudadanoIdiomaModel>();
            CreateMap<CiudadanoIdiomaModel, IdiomaDTO>();

            CreateMap<EducacionNoFirmalApp.Nuevo.Ejecuta, CiudadanoEducacionNoFormalModel>();
            CreateMap<CiudadanoEducacionNoFormalModel, EducacionNoFormalDTO>();

            CreateMap<ConocimientoCompetenciaCiudadanoApp.Nuevo.Ejecuta, CiudadanoConocimientoCompetenciaModel>();
            CreateMap<ConocimientoCompetenciaCiudadanoApp.Edicion.Ejecuta, CiudadanoConocimientoCompetenciaModel>();
            CreateMap<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>();

            CreateMap<HabilidadDestrezaCiudadanoApp.Nuevo.Ejecuta, CiudadanoHabilidadDestrezaModel>();
            CreateMap<HabilidadDestrezaCiudadanoApp.Edicion.Ejecuta, CiudadanoHabilidadDestrezaModel>();
            CreateMap<CiudadanoHabilidadDestrezaModel, HabilidadDestrezaDTO>();

            CreateMap<RedesSocialesCiudadanoApp.Nuevo.Ejecuta, CiudadanoRedesSocialesModel>();
            CreateMap<RedesSocialesCiudadanoApp.Edicion.Ejecuta, CiudadanoRedesSocialesModel>();
            CreateMap<CiudadanoRedesSocialesModel, RedesSocialesDTO>();

            //CreateMap<EducacionFormalApp.Nuevo.Ejecuta, CiudadanoEducacionFormalModel>().ReverseMap();
            //CreateMap<EducacionFormalApp.Edicion.Ejecuta, CiudadanoEducacionFormalModel>();
            //CreateMap<CiudadanoEducacionFormalModel, EducacionFormalDTO>();

            //CreateMap<DireccionCiudadanoApp.Nuevo.Ejecuta, CiudadanoDireccionModel>();
            //CreateMap<ExperienciaPreviaApp.Edicion.Ejecuta, CiudadanoExperienciaModel>();
            CreateMap<CiudadanoDireccionModel, DireccionDTO>().ReverseMap();
            CreateMap<CiudadanoDireccionComplementoModel, DireccionComplementoDTO>().ReverseMap();

            CreateMap<CiudadanoModel, CiudadanoTieneEducacionFormalDTO>()
                .ForMember(dest => dest.CiudadanoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<CiudadanoModel, CiudadanoTieneEducacionNoFormalDTO>()
                .ForMember(dest => dest.CiudadanoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<CiudadanoModel, CiudadanoTieneInformacionLaboralDTO>()
                .ForMember(dest => dest.CiudadanoId, opt => opt.MapFrom(src => src.Id));
            CreateMap<CiudadanoModel, CiudadanoTieneExperienciaPreviaDTO>()
                .ForMember(dest => dest.CiudadanoId, opt => opt.MapFrom(src => src.Id));

            CreateMap<ConocimientoCompetenciaInformacionLaboralModel, ConocimientoCompetenciaILDTO>();
            CreateMap<ConocimientoCompetenciaInformacionLaboralModel, ConocimientoCompetenciaILDTO>().ReverseMap();
            CreateMap<HabilidadDestrezaInformacionLaboralModel, HabilidadDestrezaILDTO>();
            CreateMap<HabilidadDestrezaInformacionLaboralModel, HabilidadDestrezaILDTO>().ReverseMap();

            CreateMap<ConocimientoCompetenciaExperienciaPreviaModel, ConocimientoCompetenciaEPDTO>();
            CreateMap<ConocimientoCompetenciaExperienciaPreviaModel, ConocimientoCompetenciaEPDTO>().ReverseMap();
            CreateMap<HabilidadDestrezaExperienciaPreviaModel, HabilidadDestrezaEPDTO>();
            CreateMap<HabilidadDestrezaExperienciaPreviaModel, HabilidadDestrezaEPDTO>().ReverseMap();



            CreateMap<Aplicacion.Ciudadano.Nuevo.Ejecuta, UsuarioRemote>()
            .ForMember(dest => dest.direccion, opt => opt.MapFrom(src => src.Direcciones.FirstOrDefault()));
            CreateMap<Aplicacion.Ciudadano.Edicion.Ejecuta, UsuarioRemote>()
          .ForMember(dest => dest.direccion, opt => opt.MapFrom(src => src.Direcciones.FirstOrDefault()));
            CreateMap<DireccionRemote, DireccionDTO>().ReverseMap();
            CreateMap<DireccionComplementoRemote, DireccionComplementoDTO>().ReverseMap();
            CreateMap<int, TipoNotificacionRemote>().ConvertUsing(source => new TipoNotificacionRemote() { notificationId = source });

            //.ForMember(dest => dest.Animal, opt => opt.ResolveUsing(src => new Pet() { Type = src.Animal, Color = src.AnimalColor }));
            //.ForMember(dest => dest.Sector.id, opt => opt.MapFrom(src => src.SectorId));
            //.ForMember(dest => dest.TipoNotificacion, opt => opt.MapFrom(src => src.TipoNotificacion.fo ));
            //.ForMember(x => x.BillInfo, src => src.MapFrom(y => new BillInfo(y.billingAcct, billTypeCode ))

            CreateMap<CurriculumAnnexesModel, CurriculumAnnexesDto>().ReverseMap();
            CreateMap<Aplicacion.CursoFortalecimiento.Edicion.Ejecuta, CiudadanoCursoFortalecimiento>().ReverseMap();
            CreateMap<Aplicacion.CursoFortalecimiento.Nuevo.Ejecuta, CiudadanoCursoFortalecimiento>().ReverseMap();
            CreateMap<CiudadanoCursoFortalecimiento, CiudadanoCursoFortalecimientoRespDTO>()
                //.ForMember(dest => dest.CursoFortalecimiento, opt => opt.MapFrom(src => src.CursoFortalecimiento))
                .ReverseMap();
            CreateMap<Parametrico.Modelo.CursoFortalecimiento, Parametrico.Modelo.CursoFortalecimiento>().ReverseMap();


            //CreateMap<CiudadanoCriteriosNotificacionesRespDto, CiudadanoCriteriosNotificaciones>().ReverseMap();
            //CreateMap<Aplicacion.NotificacionVacanteDeseada.Nuevo.Ejecuta, CiudadanoNotificacionVacanteDeseada>()
            //    .ForMember(dest => dest.Criterios, opt => opt.MapFrom(src => src.Criterios))
            //    .ReverseMap();
            //CreateMap<CiudadanoNotificacionVacanteDeseada, CiudadanoNotificacionVacanteDeseadaDto>()
            //    .ForMember(dest => dest.Criterios, opt => opt.MapFrom(src => src.Criterios))
            //    .ReverseMap();


            // Mapeo de CiudadanoCriteriosNotificacionesPostDto a CiudadanoCriteriosNotificaciones
            CreateMap<CiudadanoCriteriosNotificacionesPostDto, CiudadanoCriteriosNotificaciones>().ReverseMap();

            // Mapeo de Ejecuta a CiudadanoNotificacionVacanteDeseada
            CreateMap<Aplicacion.NotificacionVacanteDeseada.Nuevo.Ejecuta, CiudadanoNotificacionVacanteDeseada>()
                .ForMember(dest => dest.Criterios, opt => opt.MapFrom(src => src.Criterios))
                .ReverseMap();

            // Mapeo para los criterios
            CreateMap<CiudadanoCriteriosNotificaciones, CiudadanoCriteriosNotificacionesRespDto>().ReverseMap();

            // Mapeo para CiudadanoNotificacionVacanteDeseada y su DTO
            CreateMap<CiudadanoNotificacionVacanteDeseada, CiudadanoNotificacionVacanteDeseadaDto>()
                .ForMember(dest => dest.Criterios, opt => opt.MapFrom(src => src.Criterios))
                .ReverseMap();

            // Mapeo de CiudadanoCriteriosNotificacionesUpdateDto a CiudadanoCriteriosNotificaciones
            CreateMap<CiudadanoCriteriosNotificacionesUpdateDto, CiudadanoCriteriosNotificaciones>().ReverseMap();


            CreateMap<TipoPQRSDFResponseDto, TipoPQRSDF>().ReverseMap();

            CreateMap<Aplicacion.PQRSDF.Nuevo.Ejecuta, CiudadanoPQRSDF>()
                .ForMember(dest => dest.FechaRegistro, opt => opt.Ignore())
                .ForMember(dest => dest.Radicado, opt => opt.Ignore());

            CreateMap<CiudadanoPQRSDF, CiudadanoPQRSDFResponseDto>()
                .ForMember(dest => dest.TipoPQRSDF, opt => opt.MapFrom(src => src.TipoPQRSDF))
                .ReverseMap();

            CreateMap<BarreraEmpleoDTO, BarreraEmpleoModel>().ReverseMap();
            CreateMap<BarreraEmpleoModel, BarreraEmpleoDTO>().ReverseMap();

            CreateMap<CiudadanoEncuentasIesModel, CiudadanoEncuentasIesDTO>().ReverseMap();
            CreateMap<CiudadanoEncuentasIesDTO, CiudadanoEncuentasIesModel>().ReverseMap();

            CreateMap<CiudadanoServiciosBasicosModel, CiudadanoServiciosBasicosDTO>().ReverseMap();
            CreateMap<CiudadanoServiciosBasicosDTO, CiudadanoServiciosBasicosModel>().ReverseMap();

            CreateMap<CiudadanoServiciosEspecialesModel, CiudadanoServiciosEspecialesDTO>().ReverseMap();
            CreateMap<CiudadanoServiciosEspecialesDTO, CiudadanoServiciosEspecialesModel>().ReverseMap();

            CreateMap<ServiciosAsociadosCiudadanoApp.Nuevo.Ejecuta, CiudadanoServiciosAsociadosModel>();
            CreateMap<ServiciosAsociadosCiudadanoApp.Edicion.Ejecuta, CiudadanoServiciosAsociadosModel>();
            CreateMap<CiudadanoServiciosAsociadosModel, ServiciosAsociadosDTO>();

            CreateMap<ServiciosOfertaCiudadanoApp.Nuevo.Ejecuta, CiudadanoServiciosOfertaModel>();
            CreateMap<ServiciosOfertaCiudadanoApp.Edicion.Ejecuta, CiudadanoServiciosOfertaModel>();
            CreateMap<CiudadanoServiciosOfertaModel, ServiciosOfertaDTO>();

            CreateMap<ServiciosBasicosCiudadanoApp.Nuevo.Ejecuta, CiudadanoServiciosBasicosBrechaModel>();
            CreateMap<ServiciosBasicosCiudadanoApp.Edicion.Ejecuta, CiudadanoServiciosBasicosBrechaModel>();
            CreateMap<CiudadanoServiciosBasicosBrechaModel, ServiciosBasicosDTO>();
        }
    }
}
