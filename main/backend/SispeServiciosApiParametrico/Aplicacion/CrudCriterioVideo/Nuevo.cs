using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCriterioVideo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public Guid ModuloId { get; set; }
            public string TiempoMaximo { get; set; }
            public string TipoFormato { get; set; }
            public string? Descripcion { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                
                var info = new Modelo.CriterioVideo();
                info.ModuloId = request.ModuloId;
                info.TiempoMaximo = request.TiempoMaximo;
                info.TipoFormato = request.TipoFormato;
                info.Descripcion = request.Descripcion;

                _contexto.CriterioVideo.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.CriterioVideo, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el criterio de video");
            }
        }
    }
}
