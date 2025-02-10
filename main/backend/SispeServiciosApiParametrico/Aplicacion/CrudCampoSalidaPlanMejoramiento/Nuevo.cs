using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCampoSalidaPlanMejoramiento
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int NombreCriterio { get; set; }
            public int RangoCriterio { get; set; }
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
                
                var info = new Modelo.CampoSalidaPlanMejoramiento();
                info.NombreCriterio = request.NombreCriterio;
                info.RangoCriterio = request.RangoCriterio;
                info.Descripcion = request.Descripcion;

                _contexto.CampoSalidaPlanMejoramiento.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.CampoSalidaPlanMejoramiento, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el campo de salida plan de mejoramiento");
            }
        }
    }
}
