using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudDepartamentoInternacional;

public class Lista
{
    public class Ejecuta : IRequest<List<ParametricoDTO>>
    {
        public int PaisInternacionalId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<ParametricoDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<ParametricoDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.DepartamentoInternacional.Where(x => x.PaisInternacionalId == request.PaisInternacionalId)
                .ToListAsync();

            if (info.Count() > 0)
            {
                return _mapper.Map<List<DepartamentoInternacional>, List<ParametricoDTO>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

