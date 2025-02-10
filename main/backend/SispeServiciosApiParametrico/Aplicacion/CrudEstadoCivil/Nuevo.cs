using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudEstadoCivil
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Nombre { get; set; }
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
                
                var info = new Modelo.EstadoCivil();
                //_mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.EstadoEstadoCivil));
                //var info = _mapper.Map<Ejecuta, Modelo.EstadoEstadoCivil>(request);
                info.Nombre = request.Nombre;
                info.Descripcion = request.Descripcion;

                _contexto.estadoCivil.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.EstadoCivil, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el Experiencia");
            }
        }
    }
}
