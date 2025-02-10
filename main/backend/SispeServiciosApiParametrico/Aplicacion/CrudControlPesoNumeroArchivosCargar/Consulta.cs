using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudControlPesoNumeroArchivosCargar
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Id { get; set; } = null!;          
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
                var info = await _contexto.ControlPesoNumeroArchivosCargar.FindAsync(Int32.Parse(request.Id));
                if (info is not null)
                {
                    return _mapper.Map<ControlPesoNumeroArchivosCargar, ParametricoDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
