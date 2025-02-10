using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosAsociados;

public class Lista
{
    public class Ejecuta : IRequest<List<ServiciosAsociadosDTO>>
    {
        public Guid CiudadanoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<ServiciosAsociadosDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<ServiciosAsociadosDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.CiudadanoServiciosAsociados.Where(x => x.CiudadanoId == request.CiudadanoId).ToListAsync();
            if (info.Count() > 0)
            {
                return _mapper.Map<List<CiudadanoServiciosAsociadosModel>, List<ServiciosAsociadosDTO>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

