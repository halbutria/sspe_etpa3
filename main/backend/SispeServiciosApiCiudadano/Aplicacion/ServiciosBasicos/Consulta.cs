using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosBasicos
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ServiciosBasicosDTO>
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, ServiciosBasicosDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ServiciosBasicosDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoServiciosBasicosBrecha.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<CiudadanoServiciosBasicosBrechaModel, ServiciosBasicosDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
