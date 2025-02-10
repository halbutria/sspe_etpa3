using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCriterioMatch
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Descripcion { get; set; }
            public int TipoVacanteId { get; set; }
            public int Peso { get; set; }
            public bool Estado { get; set; }
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
                
                var info = new Modelo.CriterioMatch();
                //_mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.CriterioMatch));
                //var info = _mapper.Map<Ejecuta, Modelo.CriterioMatch>(request);
                info.Descripcion = request.Descripcion;
                info.TipoVacanteId = request.TipoVacanteId;
                info.Peso = request.Peso;
                info.Estado = request.Estado;

                _contexto.criterioMatch.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.CriterioMatch, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el Experiencia");
            }
        }
    }
}
