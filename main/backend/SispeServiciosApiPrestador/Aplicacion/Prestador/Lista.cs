using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Prestador.DTOs;
using SispeServicios.Api.Prestador.Modelo;
using SispeServicios.Api.Prestador.Persistencia;

namespace SispeServicios.Api.Prestador.Aplicacion.Prestador;

public class Lista
{
    public class Ejecuta : IRequest<List<PrestadorDTO>>
    {
        public string DepartamentoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, List<PrestadorDTO>>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<List<PrestadorDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var info = await _contexto.Prestador.OrderBy(z => z.Nombre).ToListAsync();

            if (request.DepartamentoId != "0")
            {
                info = await _contexto.Prestador.Where(x => x.DepartamentoId == request.DepartamentoId).OrderBy(z => z.Nombre).ToListAsync();
            }            
            //Where(x => x.CiudadanoId == request.CiudadanoId)

            if (info.Count() > 0)
            {
                return _mapper.Map<List<PrestadorModel>, List<PrestadorDTO>>(info);
            }
            throw new Exception("No existe Informacion a editar.");
        }
    }
}

