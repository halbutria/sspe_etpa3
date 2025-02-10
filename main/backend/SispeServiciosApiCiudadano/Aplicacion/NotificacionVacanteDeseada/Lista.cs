using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.NotificacionVacanteDeseada;

public class Lista
{
    public class Ejecuta : IRequest<List<CiudadanoNotificacionVacanteDeseadaDto>>
    {
        public Guid CiudadanoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<CiudadanoNotificacionVacanteDeseadaDto>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<CiudadanoNotificacionVacanteDeseadaDto>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.CiudadanoNotificacionVacanteDeseada.Where(x => x.CiudadanoId == request.CiudadanoId)
                .Include(c => c.Criterios)
                .ToListAsync();
            if (info.Count() > 0)
            {
                return _mapper.Map<List<CiudadanoNotificacionVacanteDeseada>, List<CiudadanoNotificacionVacanteDeseadaDto>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

