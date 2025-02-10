using AutoMapper;
using MediatR;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;
namespace SispeServicios.Api.Parametrico.Aplicacion.CrudServiciosOfertaBrecha
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public int BrechaServiciosOfertaId { get; set; }
            public int ServiciosOfertaId { get; set; }
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
                var info = await _contexto.ServiciosOfertaBrecha.FindAsync(Int32.Parse(request.Id));
                if (info is not null)
                {
                    _mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.ServiciosOfertaBrecha));
                    _contexto.ServiciosOfertaBrecha.Update(info);
                    await _contexto.SaveChangesAsync();
                    return _mapper.Map<Modelo.ServiciosOfertaBrecha, ParametricoDTO>(info);
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}
