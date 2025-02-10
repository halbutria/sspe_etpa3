using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Prestador.DTOs;
using SispeServicios.Api.Prestador.Persistencia;

namespace SispeServicios.Api.Prestador.Aplicacion.Prestador
{
    public class ConsultaFecha
    {
        public class Ejecuta : IRequest<List<PrestadorListDTO>>
        {
            public DateTime FechaInicial { get; set; }
            public DateTime FechaFinal { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, List<PrestadorListDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<PrestadorListDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                // Primero, obtienes los prestadores en el rango de fechas
                var prestadores = await _contexto.Prestador
                    .Where(x => x.FechaCreacion >= request.FechaInicial && x.FechaCreacion <= request.FechaFinal)
                    .ToListAsync();

                if (prestadores == null || !prestadores.Any())
                {
                    throw new Exception("No existe Información.");
                }

                var prestadorIds = prestadores.Select(p => p.Id).ToList();
                var puntosAtencion = await _contexto.PuntoAtencion
                    .Where(pa => prestadorIds.Contains(pa.PrestadorId))
                    .ToListAsync();

                var result = prestadores.Select(prestador => new PrestadorListDTO
                {
                    Id = prestador.Id,
                    Nombre = prestador.Nombre,
                    DepartamentoId = prestador.DepartamentoId,
                    MunicipioId = prestador.MunicipioId,
                    ClasePrestador = "",
                    Direccion = puntosAtencion.FirstOrDefault(pa => pa.PrestadorId == prestador.Id)?.Direccion ?? string.Empty,
                    Vigencia = "",
                    Estado = prestador.Eliminado ? "Inactivo" : "Activo"
                }).ToList();

                return result;
            }
        }
    }
}
