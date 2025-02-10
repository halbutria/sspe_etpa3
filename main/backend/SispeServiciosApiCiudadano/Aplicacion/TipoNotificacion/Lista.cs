using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.TipoNotificacion
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<TipoNotificacionDTO>>
        {
            public Guid CiudadanoId { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, List<TipoNotificacionDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<TipoNotificacionDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoTipoNotificacion.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();
                if (info is not null)
                {
                    return _mapper.Map<List<CiudadanoTipoNotificacionModel>, List<TipoNotificacionDTO>>(info);
                }
                throw new Exception("No existe Informacion.");
            }
        }
    }
}
