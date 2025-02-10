using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudDepartamentoInternacional
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {

            public string? Id { get; set; }
            public int? PaisInternacionalId { get; set; }
            public string? Codigo { get; set; }
            public string? DiviPolo { get; set; }
            public string? Sigla { get; set; }
            public float? Latitud { get; set; }
            public float? Longitud { get; set; }
            public string? Nombre { get; set; }

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
                var info = await _contexto.DepartamentoInternacional.FindAsync(Int32.Parse(request.Id));
                if (info is not null)
                {
                    return _mapper.Map<Modelo.DepartamentoInternacional, ParametricoDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}