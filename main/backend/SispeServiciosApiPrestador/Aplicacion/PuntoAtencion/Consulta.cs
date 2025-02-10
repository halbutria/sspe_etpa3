using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Prestador.DTOs;
using SispeServicios.Api.Prestador.Modelo;
using SispeServicios.Api.Prestador.Persistencia;

namespace SispeServicios.Api.Prestador.Aplicacion.PuntoAtencion
{
    public class Consulta
    {
        public class Ejecuta : IRequest<PuntoAtencionDTO>
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, PuntoAtencionDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<PuntoAtencionDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.PuntoAtencion.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<PuntoAtencionModel, PuntoAtencionDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
