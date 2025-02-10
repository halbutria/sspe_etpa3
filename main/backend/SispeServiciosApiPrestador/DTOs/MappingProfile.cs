using AutoMapper;
using SispeServicios.Api.Prestador.Modelo;

using PrestadorApp = SispeServicios.Api.Prestador.Aplicacion.Prestador;
using PuntoAtencionApp = SispeServicios.Api.Prestador.Aplicacion.PuntoAtencion;

namespace SispeServicios.Api.Prestador.DTOs
{
    public class MappingProfile : Profile
    {       
        public MappingProfile()
        {
            // Mapeo Prestador
            CreateMap<PrestadorModel, PrestadorDTO>();
            CreateMap<PrestadorApp.Nuevo.Ejecuta, PrestadorModel>()
                .ForMember(dest => dest.DepartamentoId, opt => opt.MapFrom(src => new ParametricoIntDTO() { Id = src.DepartamentoId }));

            // Mapeo Punto Atencion
            CreateMap<PuntoAtencionModel, PuntoAtencionDTO>();
            CreateMap<PuntoAtencionApp.Nuevo.Ejecuta, PuntoAtencionModel>()
                .ForMember(dest => dest.DepartamentoId, opt => opt.MapFrom(src => new ParametricoIntDTO() { Id = src.DepartamentoId }))
                .ForMember(dest => dest.MunicipioId, opt => opt.MapFrom(src => new ParametricoIntDTO() { Id = src.MunicipioId }));

        }
    }
}
