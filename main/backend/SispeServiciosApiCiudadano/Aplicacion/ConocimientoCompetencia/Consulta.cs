using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ConocimientoCompetencia
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ConocimientoCompetenciaDTO>
        {
            public Guid Id { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, ConocimientoCompetenciaDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ConocimientoCompetenciaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoConocimientoCompetencia.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<CiudadanoConocimientoCompetenciaModel, ConocimientoCompetenciaDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
