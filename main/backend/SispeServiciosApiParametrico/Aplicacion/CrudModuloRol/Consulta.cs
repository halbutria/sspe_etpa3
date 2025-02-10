using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRol
{
    public class Consulta
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
                if (request is not null)
                {
                    var moduloRol = _contexto.ModuloRol.Where(a => a.IdModulo.Equals(Guid.Parse(request.IdModulo)) && a.IdRol.Equals(Guid.Parse(request.IdRol))).FirstOrDefault();

                    if (moduloRol is not null)
                    {
                        return _mapper.Map<Modelo.ModuloRolModel, ModuloRolDTO>(moduloRol);
                    }
                }

                throw new Exception("No existe Información.");
            }
        }
    }
}
