using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.Modulo
{
    public class Ingresar
    {
        public class Ejecuta : IRequest<ModuloDTO>
        {
            public string? Id { get; set; }
            public string? Descripcion { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ModuloDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ModuloDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var modulo = new Modelo.ModuloModel();

                if(request is not null)
                {
                    modulo.Id = Guid.Parse(request.Id);
                    modulo.Descripcion = request.Descripcion;
                    _contexto.Modulo.Add(modulo);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.ModuloModel, ModuloDTO>(modulo);
                    }
                }
                throw new Exception("Error al registrar el modulo");
            }
        }
    }
}
