using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.PQRSDF;

public class ListaTipoPQR
{
    public class Ejecuta : IRequest<List<TipoPQRSDFResponseDto>>
    {
    }
    public class Manejador : IRequestHandler<Ejecuta, List<TipoPQRSDFResponseDto>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<TipoPQRSDFResponseDto>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.TipoPQRSDF
                .ToListAsync();
            if (info.Count() > 0)
            {
                return _mapper.Map<List<TipoPQRSDF>, List<TipoPQRSDFResponseDto>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

