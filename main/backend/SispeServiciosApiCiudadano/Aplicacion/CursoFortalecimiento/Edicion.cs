using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Migrations;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CursoFortalecimiento
{
    public class Edicion
    {

        public class Ejecuta : IRequest<CiudadanoCursoFortalecimientoRespDTO>
        {
            public int Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public int CursoFortalecimientoId { get; set; }
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
                var info = await _contexto.CiudadanoCursoFortalecimiento.Where(x => x.Id == request.Id)
                    //.Include(c => c.CursoFortalecimiento)
                    .FirstOrDefaultAsync();
                
                var infoCiuIdio = await _contexto.CiudadanoCursoFortalecimiento
                    .Where(x => x.CiudadanoId == request.CiudadanoId && x.CursoFortalecimientoId == request.CursoFortalecimientoId && x.Id != request.Id)
                    .FirstOrDefaultAsync();

                if (infoCiuIdio is null)
                {

                    if (info is not null)
                    {
                        info.CiudadanoId = request.CiudadanoId;
                        info.EstadoCurso = request.EstadoCurso;
                        info.CursoFortalecimientoId = request.CursoFortalecimientoId;
                        info.FechaInscripcion = request.FechaInscripcion;
                        info.ObtuvoCertificado = request.ObtuvoCertificado;

                        var respuesta = await _contexto.SaveChangesAsync();
                        if (respuesta > 0)
                        {
                            return _mapper.Map<CiudadanoCursoFortalecimiento, CiudadanoCursoFortalecimientoRespDTO>(info);
                        }

                        throw new Exception("Error al editar");
                    }
                    throw new Exception("No existe Informacion a editar.");
                }
                throw new Exception("Idioma ya registrado para el ciudadano.");
            }
        }

    }
}
