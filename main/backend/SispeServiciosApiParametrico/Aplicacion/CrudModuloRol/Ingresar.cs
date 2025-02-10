using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRol
{
    public class Ingresar
    {
        public class Ejecuta : IRequest<ModuloRolDTO>
        {
            public string? Id { get; set; }
            public string? IdModulo { get; set; }
            public string? IdRol { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ModuloRolDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ModuloRolDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var moduloRol = new Modelo.ModuloRolModel();

                if (request is not null)
                {
                    moduloRol.Id = Guid.Parse(request.Id);
                    moduloRol.IdModulo = Guid.Parse(request.IdModulo);
                    moduloRol.IdRol = Guid.Parse(request.IdRol);
                    _contexto.ModuloRol.Add(moduloRol);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.ModuloRolModel, ModuloRolDTO>(moduloRol);
                    }
                }
                throw new Exception("Error al registrar el rol");
            }
        }
    }
}
