using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudEncuestaSistema
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public Guid ModuloId { get; set; }
            public string? Descripcion { get; set; }
            public List<PreguntasUpdDto> Preguntas { get; set; }

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
                var info = await _contexto.EncuestaSistema
                            .Include(e => e.Preguntas)
                            .Include(e => e.Modulo)
                            .FirstOrDefaultAsync(e => e.Id == Int32.Parse(request.Id), cancellationToken);

                if (info is not null)
                {
                    info.Nombre = request.Nombre;
                    info.Descripcion = request.Descripcion;
                    info.ModuloId = request.ModuloId;
                    _contexto.EncuestaSistema.Update(info);

                    var rmPreguntas = info.Preguntas
                    .Where(e => !request.Preguntas.Select(p => p.Id).Contains(e.Id))
                    .ToList();
                    _contexto.Preguntas.RemoveRange(rmPreguntas);
                    //_contexto.Preguntas.RemoveRange(info.Preguntas);

                    var updPreguntas = info.Preguntas.Where(e => request.Preguntas.Select(p => p.Id).Contains(e.Id)).ToList();
                    foreach (var pregunta in updPreguntas)
                    {
                        pregunta.Nombre = request.Preguntas.FirstOrDefault(e => e.Id == pregunta.Id).Nombre;
                        pregunta.TipoPreguntasId = request.Preguntas.FirstOrDefault(e => e.Id == pregunta.Id).Tipo;
                        var opciones = request.Preguntas.FirstOrDefault(e => e.Id == pregunta.Id).Opciones;
                        pregunta.Opciones = (opciones != null && opciones.Count > 0) ? string.Join("", opciones.Select(o => $"[{o}]")) : "";

                    }
                    _contexto.Preguntas.UpdateRange(updPreguntas);


                    //var newPreguntasDto = request.Preguntas.Select(p => new Preguntas
                    //{
                    //    Id = 0,
                    //    Nombre = p.Nombre
                    //}).ToList();
                    //var newPreguntas = _mapper.Map<List<Preguntas>>(newPreguntasDto);
                    var newPreguntasDto = request.Preguntas.Where(e => e.Id == 0).ToList();
                    var newPreguntas = new List<Preguntas>();

                    foreach (var preguntaDto in newPreguntasDto)
                    {
                        var pregunta = _mapper.Map<Preguntas>(preguntaDto);
                        pregunta.Id = 0;
                        pregunta.EncuestaSistemaId = info.Id;
                        pregunta.TipoPreguntasId = preguntaDto.Tipo;

                        var opciones = preguntaDto.Opciones;
                        pregunta.Opciones = (opciones != null && opciones.Count > 0)
                            ? string.Join("", opciones.Select(o => $"[{o}]"))
                            : "";

                        newPreguntas.Add(pregunta);
                    }

                    try
                    {
                        _contexto.Preguntas.AddRange(newPreguntas);
                        await _contexto.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        var message = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                        throw new Exception(message);
                    }

                    info.Preguntas = info.Preguntas.Where(e => e.Eliminado == false).ToList();
                    return _mapper.Map<EncuestaSistema, ParametricoDTO>(info);
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }
    }
}
