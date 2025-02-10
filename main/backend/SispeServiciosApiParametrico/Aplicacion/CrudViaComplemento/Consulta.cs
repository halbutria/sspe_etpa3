using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.CrudViaComplemento
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ViaComplementoDTO>
        {
            public string? Id { get; set; }
            public string? Nombre { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, ViaComplementoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ViaComplementoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                if (request is not null)
                {
                    var viaComplemento = await _contexto.ViaComplemento.FindAsync(Guid.Parse(request.Id));
                    if (viaComplemento is not null)
                    {
                        return _mapper.Map<Modelo.ViaComplementoModel, ViaComplementoDTO>(viaComplemento);
                    }
                }

                throw new Exception("No existe Información.");
            }
        }
    }
}
