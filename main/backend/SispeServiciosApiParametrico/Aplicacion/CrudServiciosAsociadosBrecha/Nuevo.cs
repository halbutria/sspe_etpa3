using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosAsociadosBrecha
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int BrechaServiciosAsociadosId { get; set; }
            public int ServiciosAsociadosId { get; set; }
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
                var info = new Modelo.ServiciosAsociadosBrecha();
                info.BrechaServiciosAsociadosId = request.BrechaServiciosAsociadosId;
                info.ServiciosAsociadosId = request.ServiciosAsociadosId;
                _contexto.ServiciosAsociadosBrecha.Add(info);
                var respuesta = await _contexto.SaveChangesAsync();
                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.ServiciosAsociadosBrecha, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar servicios basicos");
            }
        }
    }
}
