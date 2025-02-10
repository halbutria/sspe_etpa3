using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.Rol
{
    public class Ingresar
    {
        public class Ejecuta : IRequest<RolDTO>
        {
            public string? Id { get; set; }
            public string? Descripcion { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, RolDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<RolDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var rol = new Modelo.RolModel();

                if (request is not null)
                {
                    rol.Id = Guid.Parse(request.Id);
                    rol.Descripcion = request.Descripcion;
                    _contexto.Rol.Add(rol);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.RolModel, RolDTO>(rol);
                    }
                }
                throw new Exception("Error al registrar el rol");
            }
        }
    }
}
