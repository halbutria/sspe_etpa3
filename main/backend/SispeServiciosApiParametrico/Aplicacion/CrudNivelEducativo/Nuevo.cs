using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudNivelEducativo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Nombre { get; set; }
            public string? Sigla { get; set; }
            public int? Orden { get; set; }
            public bool? RegistraInstitucion { get; set; }
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
                
                var info = new Modelo.NivelEducativo();
                //_mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.NivelEducativo));
                //var info = _mapper.Map<Ejecuta, Modelo.NivelEducativo>(request);
                info.Nombre = request.Nombre;
                info.Sigla = request.Sigla;
                info.Orden = (int)request.Orden;
                info.RegistraInstitucion = (bool)request.RegistraInstitucion;

                _contexto.nivelEducativo.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.NivelEducativo, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el Experiencia");
            }
        }
    }
}
