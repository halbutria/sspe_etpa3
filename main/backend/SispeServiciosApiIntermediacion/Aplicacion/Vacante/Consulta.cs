using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;

namespace SispeServicios.Api.Intermediacion.Aplicacion.Vacante
{
    public class Consulta
    {

        public class Ejecuta : IRequest<VacanteDetalleDTO>
        {
            public Guid Id { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, VacanteDetalleDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<VacanteDetalleDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.Vacantes
                    .Include(i => i.Estado)
                    .Include(i => i.Ubicaciones)
                    .Include(i => i.ConocimientosCompetencias)
                    .Include(i => i.HabilidadesDestrezas)
                    .Include(i => i.DenominacionesRelacionadas)
                    .Include(i => i.MotivosExcepcionalidad)
                    .Include(i => i.Discapacidades)
                    .Include(i => i.Idiomas)
                    .Include(i => i.PrestadoresAlternos)
                    .Include(i => i.Archivos)
                    .Include(i => i.TiposPoblacion)
                    .Include(i => i.CondicionesSaludMental)
                    .Include(i => i.GruposEtnicos)
                    .Include(i => i.PoblacionesVulnerables)
                    .Include(i => i.ZonasGeograficas)
                    .Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (info is not null)
                {
                    return _mapper.Map<VacanteModel, VacanteDetalleDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
