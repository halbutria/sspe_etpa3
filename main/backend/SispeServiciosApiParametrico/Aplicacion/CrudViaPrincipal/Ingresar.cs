using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.CrudViaPrincipal
{
    public class Ingresar
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

                var viaPrincipal = new Modelo.ViaPrincipalModel();

                if (request is not null)
                {
                    viaPrincipal.Id = Guid.Parse(request.Id);
                    viaPrincipal.Nombre = request.Nombre;
                    _contexto.ViaPrincipal.Add(viaPrincipal);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.ViaPrincipalModel, ViaPrincipalDTO>(viaPrincipal);
                    }
                }
                throw new Exception("Error al registrar la via principal");
            }
        }
    }
}
