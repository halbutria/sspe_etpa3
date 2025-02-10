using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServiciosApiParametrico.Aplicacion.Modulo
{
    public class Modificar
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
                if (request is not null)
                {
                    var modulo = await _contexto.Modulo.FindAsync(Guid.Parse(request.Id));                    

                    if (modulo is not null)
                    {
                        modulo.Descripcion = request.Descripcion;
                        _contexto.Modulo.Update(modulo);
                        await _contexto.SaveChangesAsync();
                        return _mapper.Map<Modelo.ModuloModel, ModuloDTO>(modulo);
                    }
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }
    }
}
