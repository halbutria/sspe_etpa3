using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudCursoFortalecimiento
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public int TipoCurso { get; set; }
            public string Duracion { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaFinalizacion { get; set; }
            public string Nombre { get; set; }
            public string? Descripcion { get; set; }
            public string? DescripcionComplementaria { get; set; }
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
                
                var info = new Modelo.CursoFortalecimiento();
                info.TipoCurso = request.TipoCurso;
                info.Duracion = request.Duracion;
                info.FechaInicio = request.FechaInicio;
                info.FechaFinalizacion = request.FechaFinalizacion;
                info.Nombre = request.Nombre;
                info.Descripcion = request.Descripcion;
                info.DescripcionComplementaria = request.DescripcionComplementaria;
                info.Estado = request.Estado;

                _contexto.CursoFortalecimiento.Add(info);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    return _mapper.Map<Modelo.CursoFortalecimiento, ParametricoDTO>(info);
                }
                throw new Exception("Error al guardar el curso de fortalecimento");
            }
        }
    }
}
