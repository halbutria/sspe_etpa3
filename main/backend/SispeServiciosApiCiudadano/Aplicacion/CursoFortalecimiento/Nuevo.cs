using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteService;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CursoFortalecimiento
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<CiudadanoCursoFortalecimientoRespDTO>
        {
            public Guid CiudadanoId { get; set; }
            public int CursoFortalecimientoId { get; set; }
            //public Parametrico.Modelo.CursoFortalecimiento CursoFortalecimiento { get; set; }
            public DateTime FechaInscripcion { get; set; }
            public int ObtuvoCertificado { get; set; }
            public int EstadoCurso { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoCursoFortalecimientoRespDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<CiudadanoCursoFortalecimientoRespDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                var info = await _contexto.CiudadanoCursoFortalecimiento
                    .Where(x => x.CiudadanoId == request.CiudadanoId && x.CursoFortalecimientoId == request.CursoFortalecimientoId)
                    .FirstOrDefaultAsync();

                if (info is null)
                {
                    var curso = _mapper.Map<Ejecuta, CiudadanoCursoFortalecimiento>(request);
                    _contexto.CiudadanoCursoFortalecimiento.Add(curso);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        info = await _contexto.CiudadanoCursoFortalecimiento
                        .Where(x => x.CiudadanoId == request.CiudadanoId && x.CursoFortalecimientoId == request.CursoFortalecimientoId)
                        //.Include(c => c.CursoFortalecimiento)
                        .FirstOrDefaultAsync();

                        var ciudadanoCurso = new CiudadanoCursoFortalecimiento
                        {
                            Id = info.Id,
                            CiudadanoId = info.CiudadanoId,
                            CursoFortalecimientoId = info.CursoFortalecimientoId,
                            //CursoFortalecimiento = new Parametrico.Modelo.CursoFortalecimiento
                            //{
                            //    Id = info.CursoFortalecimiento.Id,
                            //    TipoCurso = info.CursoFortalecimiento.TipoCurso,
                            //    Duracion = info.CursoFortalecimiento.Duracion,
                            //    FechaInicio = info.CursoFortalecimiento.FechaInicio,
                            //    FechaFinalizacion = info.CursoFortalecimiento.FechaFinalizacion,
                            //    Nombre = info.CursoFortalecimiento.Nombre,
                            //    Descripcion = info.CursoFortalecimiento.Descripcion,
                            //    DescripcionComplementaria = info.CursoFortalecimiento.DescripcionComplementaria,
                            //    Estado = info.CursoFortalecimiento.Estado
                            //},
                            FechaInscripcion = DateTime.Now,
                            ObtuvoCertificado = 0,
                            EstadoCurso = 2
                        };
                        return _mapper.Map<CiudadanoCursoFortalecimiento, CiudadanoCursoFortalecimientoRespDTO>(ciudadanoCurso);
                    }
                    throw new Exception("Error al gurdar el curso de fortalecimiento.");
                }
                throw new Exception("Curso de fortalecimiento ya registrado para el ciudadano.");
            }
        }

    }
}
