using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Prestador.DTOs;
using SispeServicios.Api.Prestador.Modelo;
using SispeServicios.Api.Prestador.Persistencia;

namespace SispeServicios.Api.Prestador.Aplicacion.Prestador
{
    public class Consulta
    {
        public class Ejecuta : IRequest<PrestadorDTO>
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, PrestadorDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<PrestadorDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.Prestador.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<PrestadorModel, PrestadorDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
