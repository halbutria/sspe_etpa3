using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.CrudViaPrincipal
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ViaPrincipalDTO>
        {
            public string? Id { get; set; }
            public string? Nombre { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, ViaPrincipalDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ViaPrincipalDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                if (request is not null)
                {
                    var viaPrincipal = await _contexto.ViaPrincipal.FindAsync(Guid.Parse(request.Id));
                    if (viaPrincipal is not null)
                    {
                        return _mapper.Map<Modelo.ViaPrincipalModel, ViaPrincipalDTO>(viaPrincipal);
                    }
                }

                throw new Exception("No existe Información.");
            }
        }
    }
}
