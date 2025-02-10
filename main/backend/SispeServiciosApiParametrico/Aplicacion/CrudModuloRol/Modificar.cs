using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRol
{
    public class Modificar
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
                    var moduloRol = await _contexto.ModuloRol.FindAsync(Guid.Parse(request.Id));

                    if (moduloRol is not null)
                    {
                        moduloRol.IdModulo = Guid.Parse(request.IdModulo);
                        moduloRol.IdRol = Guid.Parse(request.IdRol);
                        _contexto.ModuloRol.Update(moduloRol);
                        await _contexto.SaveChangesAsync();
                        return _mapper.Map<Modelo.ModuloRolModel, ModuloRolDTO>(moduloRol);
                    }
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }
    }
}
