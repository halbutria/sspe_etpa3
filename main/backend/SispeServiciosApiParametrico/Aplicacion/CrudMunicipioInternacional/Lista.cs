using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudMunicipioInternacional;

public class Lista
{
    public class Ejecuta : IRequest<List<ParametricoDTO>>
    {
        public int DepartamentoInternacionalId { get; set; }
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
            var info = await _contexto.MunicipioInternacional.Where(x => x.DepartamentoInternacionalId == request.DepartamentoInternacionalId)
                .ToListAsync();

            if (info.Count() > 0)
            {
                return _mapper.Map<List<MunicipioInternacional>, List<ParametricoDTO>>(info);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

