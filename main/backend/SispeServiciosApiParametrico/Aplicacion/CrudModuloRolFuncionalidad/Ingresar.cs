using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRolFuncionalidad
{
    public class Ingresar
    {
        public class Ejecuta : IRequest<ModuloRolFuncionalidadDTO>
        {
            public string? Id { get; set; }
            public string? IdModulo { get; set; }
            public string? IdRol { get; set; }
            public string Funcionalidad { get; set; }
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

                var moduloRolFuncionalidad = new Modelo.ModuloRolFuncionalidadModel();

                if (request is not null)
                {
                    moduloRolFuncionalidad.Id = Guid.Parse(request.Id);
                    moduloRolFuncionalidad.IdModulo = Guid.Parse(request.IdModulo);
                    moduloRolFuncionalidad.IdRol = Guid.Parse(request.IdRol);
                    moduloRolFuncionalidad.Funcionalidad = request.Funcionalidad;

                    _contexto.ModuloRolFuncionalidad.Add(moduloRolFuncionalidad);
                    var respuesta = await _contexto.SaveChangesAsync();
                    if (respuesta > 0)
                    {
                        return _mapper.Map<Modelo.ModuloRolFuncionalidadModel, ModuloRolFuncionalidadDTO>(moduloRolFuncionalidad);
                    }
                }
                throw new Exception("Error al registrar el modulo por rol y funcionalidad");
            }
        }
    }
}
