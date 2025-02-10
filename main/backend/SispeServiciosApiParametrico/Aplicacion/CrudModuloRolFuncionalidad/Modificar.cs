using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRolFuncionalidad
{
    public class Modificar
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
                if (request is not null)
                {
                    var moduloRolFuncionalidad = await _contexto.ModuloRolFuncionalidad.FindAsync(Guid.Parse(request.Id));

                    if (moduloRolFuncionalidad is not null)
                    {
                        moduloRolFuncionalidad.IdModulo = Guid.Parse(request.IdModulo);
                        moduloRolFuncionalidad.IdRol = Guid.Parse(request.IdRol);
                        moduloRolFuncionalidad.Funcionalidad = request.Funcionalidad;

                        _contexto.ModuloRolFuncionalidad.Update(moduloRolFuncionalidad);
                        await _contexto.SaveChangesAsync();
                        return _mapper.Map<Modelo.ModuloRolFuncionalidadModel, ModuloRolFuncionalidadDTO>(moduloRolFuncionalidad);
                    }
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }
    }
}
