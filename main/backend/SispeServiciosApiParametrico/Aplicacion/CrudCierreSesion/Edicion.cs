using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCierreSesion
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Id { get; set; } = null!;
            public string TiempoInactividad { get; set; } = null!;
            public string TiempoActividad { get; set; } = null!;
            public string? Descripcion { get; set; }

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
                var info = await _contexto.CierreSesion.FindAsync(Int32.Parse(request.Id));

                if (info is not null)
                {
                    _mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.CierreSesion));

                    _contexto.CierreSesion.Update(info);

                    await _contexto.SaveChangesAsync();
                    return _mapper.Map<CierreSesion, ParametricoDTO>(info);
           
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}
