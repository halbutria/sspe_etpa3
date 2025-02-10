using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.RedesSociales;

public class Lista
{
    public class Ejecuta : IRequest<List<RedesSocialesDTO>>
    {
        public Guid CiudadanoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<RedesSocialesDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<RedesSocialesDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.CiudadanoRedesSociales.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();
            if (info.Count() > 0)
            {
                return _mapper.Map<List<CiudadanoRedesSocialesModel>, List<RedesSocialesDTO>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

