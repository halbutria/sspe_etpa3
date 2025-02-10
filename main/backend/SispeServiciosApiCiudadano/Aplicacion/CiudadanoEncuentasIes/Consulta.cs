using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.DTOs;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoEncuentasIes
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<CiudadanoEncuentasIesDTO>>
        {
            public FiltrosCiudadanoEncuentasIesDTO Filtros { get; set; } = new FiltrosCiudadanoEncuentasIesDTO();
        }

        public class Manejador : IRequestHandler<Ejecuta, List<CiudadanoEncuentasIesDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<CiudadanoEncuentasIesDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {


                var litaCiudadanoEncuentasIes = await _contexto.CiudadanoEncuentasIes.Where(x => x.Programa == (request.Filtros.Programa == null ? x.Programa : request.Filtros.Programa)
                                                        && x.FechaFinPrograma.Value.Year == (request.Filtros.AnioTerminacionPrograma == null ? x.FechaFinPrograma.Value.Year : request.Filtros.AnioTerminacionPrograma)
                                                        && x.TieneEmpleoId.Value == (request.Filtros.TieneEmpleoId == null ? x.TieneEmpleoId : request.Filtros.TieneEmpleoId)
                                                    ).ToListAsync();
                
                if (litaCiudadanoEncuentasIes is not null)
                {
                    return _mapper.Map<List<CiudadanoEncuentasIesModel>, List<CiudadanoEncuentasIesDTO>>(litaCiudadanoEncuentasIes);
                }
                throw new Exception("No existe Información.");
            }

        }
    }
}
