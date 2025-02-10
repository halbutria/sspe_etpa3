using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCamposCreacionEmpresaExtrangera
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public int TipoPersona { get; set; }
            public int TipoDocumento { get; set; }
            public int Naturaleza { get; set; }
            public int TipoEmpresa { get; set; }
            public int TamanioPorNumeroEmpleados { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CamposCreacionEmpresaExtrangera.FindAsync(Int32.Parse(request.Id));
                if (info is not null)
                {
                    return _mapper.Map<Modelo.CamposCreacionEmpresaExtrangera, ParametricoDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
