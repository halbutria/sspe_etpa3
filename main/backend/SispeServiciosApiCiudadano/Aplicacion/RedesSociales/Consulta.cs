using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.RedesSociales
{
    public class Consulta
    {
        public class Ejecuta : IRequest<RedesSocialesDTO>
        {
            public Guid Id { get; set; }
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
                if (info is not null)
                {
                    return _mapper.Map<CiudadanoRedesSocialesModel, RedesSocialesDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
