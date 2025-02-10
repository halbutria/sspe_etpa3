using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteService;

namespace SispeServicios.Api.Ciudadano.Aplicacion.RedesSociales
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<RedesSocialesDTO>
        {
            public Guid CiudadanoId { get; set; }
            public int RedSocialId { get; set; }
            public string NombreRedSocial { get; set; }
            public string NombreUsuarioRedSocial { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, RedesSocialesDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<RedesSocialesDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoRedesSociales
                    .Where(x => 
                        x.CiudadanoId == request.CiudadanoId && 
                        x.RedSocialId == request.RedSocialId && 
                        x.NombreUsuarioRedSocial == request.NombreUsuarioRedSocial
                    ).FirstOrDefaultAsync();
                if (info is null)
                {
                    var red = _mapper.Map<Ejecuta, CiudadanoRedesSocialesModel>(request);
                    _contexto.CiudadanoRedesSociales.Add(red);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<CiudadanoRedesSocialesModel, RedesSocialesDTO>(red);
                    }
                    throw new Exception("Error al gurdar la red social del ciudadano.");
                }
                throw new Exception("Red social ya registrada para el ciudadano.");
            }
        }

    }
}
