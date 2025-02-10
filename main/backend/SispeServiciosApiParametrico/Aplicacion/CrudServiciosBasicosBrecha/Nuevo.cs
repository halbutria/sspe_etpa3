using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosBasicosBrecha
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int BrechaServiciosBasicosId { get; set; }
            public int ServiciosBasicosId { get; set; }
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
                var info = new Modelo.ServiciosBasicosBrecha();
                info.BrechaServiciosBasicosId = request.BrechaServiciosBasicosId;
                info.ServiciosBasicosId = request.ServiciosBasicosId;
                _contexto.ServiciosBasicosBrecha.Add(info);
                var respuesta = await _contexto.SaveChangesAsync();
                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.ServiciosBasicosBrecha, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar servicios basicos");
            }
        }
    }
}
