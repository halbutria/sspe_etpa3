using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.Modelo;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudEncuestaSistema
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public string? Nombre { get; set; }
            public ModuloModel? Modulos { get; set; }
            public string? Descripcion { get; set; }
            public List<Preguntas>? Preguntas { get; set; }

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
                            .Include(m => m.Modulo)
                            .FirstOrDefaultAsync(e => e.Id == Int32.Parse(request.Id), cancellationToken);

                if (info is not null)
                {
                    var dto = _mapper.Map<EncuestaSistema, ParametricoDTO>(info);
                    dto.Preguntas = info.Preguntas.Select(p => new Preguntas
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        EncuestaSistemaId = p.EncuestaSistemaId,
                        TipoPreguntasId = p.TipoPreguntasId,
                        Opciones = p.Opciones,
                        //Opciones = Regex.Matches(p.Opciones, @"\[(.*?)\]").Cast<Match>().Select(m => m.Groups[1].Value).ToList(),
                        TipoPreguntas = p.TipoPreguntas
                    }).ToList();

                    
                    return dto;
                    
                }

                throw new Exception("No existe Información.");
            }
        }
    }
}
