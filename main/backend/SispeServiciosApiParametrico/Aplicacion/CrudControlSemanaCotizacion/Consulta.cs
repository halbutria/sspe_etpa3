using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudControlSemanaCotizacion
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public int? EdadHombre { get; set; }
            public int? EdadMujer { get; set; }
            public int? SemanaCotizarHombre { get; set; }
            public int? SemanaCotizarMujer { get; set; }
            public string? Descripcion { get; set; }

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
                var info = await _contexto.ControlSemanaCotizacion.FindAsync(Int32.Parse(request.Id));
                if (info is not null)
                {
                    return _mapper.Map<Modelo.ControlSemanaCotizacion, ParametricoDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
