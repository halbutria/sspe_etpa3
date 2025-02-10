using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.EducacionNoFormal
{
    public class Consulta
    {
        public class Ejecuta : IRequest<EducacionNoFormalDTO>
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, EducacionNoFormalDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<EducacionNoFormalDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoEducacionNoFormal.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<CiudadanoEducacionNoFormalModel, EducacionNoFormalDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
