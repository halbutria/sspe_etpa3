using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRolFuncionalidad
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ModuloRolFuncionalidadDTO>
        {
            public string? Id { get; set; }
            public string? IdModulo { get; set; }
            public string? IdRol { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, ModuloRolFuncionalidadDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ModuloRolFuncionalidadDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                if (request is not null)
                {
                    var moduloRolFuncionalidad = _contexto.ModuloRolFuncionalidad.Where(a => a.Id.Equals(Guid.Parse(request.Id))).FirstOrDefault();

                    if (moduloRolFuncionalidad is not null)
                    {
                        return _mapper.Map<Modelo.ModuloRolFuncionalidadModel, ModuloRolFuncionalidadDTO>(moduloRolFuncionalidad);
                    }
                }

                throw new Exception("No existe Información.");
            }
        }
    }
}
