using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServiciosApiParametrico.Aplicacion.Modulo
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<ModuloDTO>>
        {
            public string? tipo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<ModuloDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<List<ModuloDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                List<ModuloDTO> outPut = new List<ModuloDTO>();
                switch (request.tipo)
                {
                    case "Modulo":
                        var Modulos = await _contexto.Modulo.ToListAsync(cancellationToken: cancellationToken);
                        outPut = _mapper.Map<List<ModuloModel>, List<ModuloDTO>>(Modulos);
                        break;

                    default:
                        throw new Exception($"{request.tipo} tipo no valido");
                }
                return outPut;
            }

        }
    }
}
