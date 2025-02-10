using AutoMapper;
using SispeServicios.Api.Intermediacion.Modelo;
using VacanteApp = SispeServicios.Api.Intermediacion.Aplicacion.Vacante;

namespace SispeServicios.Api.Intermediacion.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<origen, destino>();
            CreateMap<VacanteApp.Nuevo.Ejecuta, VacanteModel>();
            CreateMap<VacanteApp.Edicion.Ejecuta, VacanteModel>();
            CreateMap<VacanteIdiomaDTO, VacanteIdiomaModel>();
            CreateMap<VacanteUbicacionDTO, VacanteUbicacionModel>();
            CreateMap<VacanteModel, VacanteDetalleDTO>()
                .ForMember(dest => dest.SolicitudAutorizacionExcepcionalidadFilePath, opt => opt.MapFrom(src =>$"/Vacante/Archivo/{src.Archivos.FirstOrDefault().TipoArchivo}/{src.Archivos.First().Id}/{src.Archivos.FirstOrDefault().NombreArchivo}"  )); ;
            CreateMap<VacanteIdiomaModel, VacanteIdiomaDTO>();

            CreateMap<VacanteEstadoModel, VacanteEstadoDTO>();
            CreateMap<VacanteUbicacionDTO, VacanteUbicacionModel>();
            CreateMap<VacanteUbicacionModel, VacanteUbicacionDTO>();

            CreateMap<string, VacanteConocimientoCompetenciaModel>()
                .ForMember(dest => dest.ConocimientoCompetenciaId, opt => opt.MapFrom(src => src));
            CreateMap<VacanteConocimientoCompetenciaModel, string>().ConvertUsing(source => source.ConocimientoCompetenciaId);

            CreateMap<Guid, VacantePrestadorAlternoModel>()
                .ForMember(dest => dest.PrestadorId, opt => opt.MapFrom(src => src));
            CreateMap<VacantePrestadorAlternoModel, Guid>().ConvertUsing(source => source.PrestadorId);


            CreateMap<int, VacanteDiscapacidadModel>()
                .ForMember(dest => dest.DiscapacidadId, opt => opt.MapFrom(src => src));

            CreateMap<VacanteDiscapacidadModel, int>().ConvertUsing(source => source.DiscapacidadId);

            CreateMap<int, VacanteMotivoExcepcionalidadModel>()
                .ForMember(dest => dest.MotivosExcepcionalidadId, opt => opt.MapFrom(src => src));


            CreateMap<VacanteMotivoExcepcionalidadModel, int>().ConvertUsing(source => source.MotivosExcepcionalidadId);



            CreateMap<VacantePoblacionVulnerableModel, int>().ConvertUsing(source => source.PoblacionVulnerableId);
            CreateMap<int, VacantePoblacionVulnerableModel>()
                .ForMember(dest => dest.PoblacionVulnerableId, opt => opt.MapFrom(src => src));
            
            CreateMap<VacanteGrupoEtnicoModel, int>().ConvertUsing(source => source.GrupoEtnicoId);
            CreateMap<int, VacanteGrupoEtnicoModel>()
                .ForMember(dest => dest.GrupoEtnicoId, opt => opt.MapFrom(src => src));
            
            CreateMap<VacanteCondicionSaludMentalModel, int>().ConvertUsing(source => source.CondicionSaludMentalId);
            CreateMap<int, VacanteCondicionSaludMentalModel>()
                .ForMember(dest => dest.CondicionSaludMentalId, opt => opt.MapFrom(src => src));

            CreateMap<VacanteTipoPoblacionModel, int>().ConvertUsing(source => source.TipoPoblacionId);
            CreateMap<int, VacanteTipoPoblacionModel>()
                .ForMember(dest => dest.TipoPoblacionId, opt => opt.MapFrom(src => src));







            CreateMap<string, VacanteHabilidadDestrezaModel>()
                .ForMember(dest => dest.HabilidadDestrezaId, opt => opt.MapFrom(src => src));
            CreateMap<VacanteHabilidadDestrezaModel, string>().ConvertUsing(source => source.HabilidadDestrezaId);

            CreateMap<string, VacanteDenominacionRelacionadaModel>()
                .ForMember(dest => dest.DenominacionRelacionadaId, opt => opt.MapFrom(src => src));
            CreateMap<VacanteDenominacionRelacionadaModel, string>().ConvertUsing(source => source.DenominacionRelacionadaId);


            CreateMap<int, VacanteZonaGeograficaModel>()
                .ForMember(dest => dest.VacanteZonaGeograficaId, opt => opt.MapFrom(src => src));
            CreateMap<VacanteZonaGeograficaModel, int>()
                .ConvertUsing(source => source.VacanteZonaGeograficaId);


            CreateMap<VacanteModel, VacanteInfoDTO>();
          

            CreateMap<EmpresaModel, EmpresaDetalleDTO>().ReverseMap();
            CreateMap<EmpresaModel, EmpresaDTO>().ReverseMap();
            CreateMap<EmpresaUsuarioModel, EmpresaUsuarioDTO>().ReverseMap();
            CreateMap<EmpresaSedeModel, EmpresaSedeDetalleDTO>().ReverseMap();
            CreateMap<EmpresaSedeModel, EmpresaSedeDTO>().ReverseMap();            
            CreateMap<EmpresaSedeUsuarioModel, EmpresaSedeResponsableDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.EmpresaUsuario.Id))
                .ForMember(dest => dest.TipoDocumentoId, opt => opt.MapFrom(src => src.EmpresaUsuario.TipoDocumentoId))
                .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(src => src.EmpresaUsuario.NumeroDocumento))
                .ForMember(dest => dest.PrimerNombre, opt => opt.MapFrom(src => src.EmpresaUsuario.PrimerNombre ))
                .ForMember(dest => dest.SegundoNombre, opt => opt.MapFrom(src => src.EmpresaUsuario.SegundoNombre))
                .ForMember(dest => dest.PrimerApellido, opt => opt.MapFrom(src => src.EmpresaUsuario.PrimerApellido))
                .ForMember(dest => dest.SegundoApellido, opt => opt.MapFrom(src => src.EmpresaUsuario.SegundoApellido))
                .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.EmpresaUsuario.CorreoElectronico))
                .ReverseMap();

        }
    }
}
