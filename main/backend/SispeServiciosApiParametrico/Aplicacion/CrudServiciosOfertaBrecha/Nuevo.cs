using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosOfertaBrecha
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int BrechaServiciosOfertaId { get; set; }
            public int ServiciosOfertaId { get; set; }
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
                var info = new Modelo.ServiciosOfertaBrecha();
                info.BrechaServiciosOfertaId = request.BrechaServiciosOfertaId;
                info.ServiciosOfertaId = request.ServiciosOfertaId;
                _contexto.ServiciosOfertaBrecha.Add(info);
                var respuesta = await _contexto.SaveChangesAsync();
                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.ServiciosOfertaBrecha, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar servicios basicos");
            }
        }
    }
}
