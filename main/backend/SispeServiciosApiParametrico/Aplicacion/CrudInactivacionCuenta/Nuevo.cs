using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudInactivacionCuenta
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int Meses { get; set; }
            public string? Descripcion { get; set; }
            public Guid RolModelId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, ParametricoDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<ParametricoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                
                var info = new Modelo.InactivacionCuenta();
                info.Meses = request.Meses;
                info.Descripcion = request.Descripcion;
                info.RolModelId = request.RolModelId;

                _contexto.InactivacionCuenta.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.InactivacionCuenta, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar la inactivación de cuenta");
            }
        }
    }
}
