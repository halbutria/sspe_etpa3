using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Migrations;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.RedesSociales
{
    public class Edicion
    {

        public class Ejecuta : IRequest<RedesSocialesDTO>
        {
            public Guid Id { get; set; }
            public int RedSocialId { get; set; }
            public Guid CiudadanoId { get; set; }
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
                var info = await _contexto.CiudadanoRedesSociales.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                var infoCiuRed = await _contexto.CiudadanoRedesSociales
                    .Where(x => 
                        x.CiudadanoId == request.CiudadanoId && 
                        x.RedSocialId == request.RedSocialId &&
                        x.NombreUsuarioRedSocial == request.NombreUsuarioRedSocial &&
                        x.Id != request.Id
                    ).FirstOrDefaultAsync();

                if (infoCiuRed is null)
                {
                    if (info is not null)
                    {
                        info.RedSocialId = request.RedSocialId;
                        info.CiudadanoId = request.CiudadanoId;
                        info.NombreRedSocial = request.NombreRedSocial;
                        info.NombreUsuarioRedSocial = request.NombreUsuarioRedSocial;

                        var respuesta = await _contexto.SaveChangesAsync();
                        //if (respuesta > 0)
                        //{
                        return _mapper.Map<CiudadanoRedesSocialesModel, RedesSocialesDTO>(info);
                        //}

                        //throw new Exception("Error al editar");
                    }
                    throw new Exception("No existe Informacion a editar.");
                }
                throw new Exception("Red social ya registrada para el ciudadano.");
            }
        }

    }
}
