using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudPasosRutaEmpleabilidad
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public string? Nombre { get; set; }
            public string? Descripcion { get; set; }
            public List<Direccionamiento>? Direccionamientos { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.PasosRutaEmpleabilidad
                            .Include(e => e.Direccionamientos)
                            .FirstOrDefaultAsync(e => e.Id == Int32.Parse(request.Id), cancellationToken);

                if (info is not null)
                {
                    var dto = _mapper.Map<PasosRutaEmpleabilidad, ParametricoDTO>(info);
                    dto.Direccionamientos = info.Direccionamientos.Select(p => p.Nombre).ToList();
                    return dto;
                }

                throw new Exception("No existe Información.");
            }
        }
    }
}
