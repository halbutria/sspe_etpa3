using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudControlSemanaCotizacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int EdadHombre { get; set; }
            public int EdadMujer { get; set; }
            public int SemanaCotizarHombre { get; set; }
            public int SemanaCotizarMujer { get; set; }
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
                
                var info = new Modelo.ControlSemanaCotizacion();
                info.EdadHombre = request.EdadHombre;
                info.EdadMujer = request.EdadMujer;
                info.SemanaCotizarHombre = request.SemanaCotizarHombre;
                info.SemanaCotizarMujer = request.SemanaCotizarMujer;
                info.Descripcion = request.Descripcion;

                _contexto.ControlSemanaCotizacion.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.ControlSemanaCotizacion, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el control de la semana de cotización");
            }
        }
    }
}
