using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Prestador.DTOs;
using SispeServicios.Api.Prestador.Modelo;
using SispeServicios.Api.Prestador.Persistencia;
using System;

namespace SispeServicios.Api.Prestador.Aplicacion.PuntoAtencion;

public class Lista
{
    public class Ejecuta : IRequest<List<PuntoAtencionDTO>>
    {
        public Guid PrestadorId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<PuntoAtencionDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<PuntoAtencionDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.PuntoAtencion.OrderBy(z => z.Nombre).ToListAsync();

            if (request.PrestadorId != Guid.Empty)
            {
                info = await _contexto.PuntoAtencion.Where(x => x.PrestadorId == request.PrestadorId).OrderBy(z => z.Nombre).ToListAsync();
            }
            
            //Where(x => x.CiudadanoId == request.CiudadanoId)

            if (info.Count() > 0)
            {
                return _mapper.Map<List<PuntoAtencionModel>, List<PuntoAtencionDTO>>(info);
            }
            throw new Exception("No existe Informacion a editar.");
        }
    }
}

