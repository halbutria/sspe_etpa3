using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudEncuestaSistema
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Nombre { get; set; }
            public Guid ModuloId { get; set; }
            public string? Descripcion { get; set; }
            public List<PreguntasNewDto> Preguntas { get; set; }

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
                
                var encuesta = new EncuestaSistema
                {
                    Nombre = request.Nombre,
                    ModuloId = request.ModuloId,
                    Descripcion = request.Descripcion,
                    Preguntas = request.Preguntas.Select(p => new Preguntas
                    {
                        Nombre = p.Nombre,
                        TipoPreguntasId = p.Tipo,
                        Opciones = p.Opciones != null && p.Opciones.Any() ? String.Join("", p.Opciones.Select(o => $"[{o}]")) : ""
                    }).ToList()
                };

                try
                {
                    _contexto.EncuestaSistema.Add(encuesta);
                    var respuesta = await _contexto.SaveChangesAsync(cancellationToken);

                    if (respuesta > 0)
                    {
                        var info = await _contexto.EncuestaSistema
                            .Include(e => e.Preguntas)
                            .Include(m => m.Modulo)
                            .FirstOrDefaultAsync(e => e.Id == encuesta.Id, cancellationToken);
                        var dto = _mapper.Map<EncuestaSistema, ParametricoDTO>(info);
                        return dto;
                    }
                }
                catch (Exception ex)
                {
                    var message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    throw new Exception(message);
                }

                throw new Exception("Error al guardar la encuesta del sistema");
            }



        }
    }
}
