using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRol
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<ModuloRolDTO>>
        {
            public string? tipo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<ModuloRolDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<List<ModuloRolDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                List<ModuloRolDTO> outPut = new();
                switch (request.tipo)
                {
                    case "ModuloRol":
                        var moduloRol = await _contexto.ModuloRol.ToListAsync(cancellationToken);
                        outPut = _mapper.Map<List<ModuloRolModel>, List<ModuloRolDTO>>(moduloRol);
                        break;

                    default:
                        throw new Exception($"{request.tipo} tipo no valido");
                }
                return outPut;
            }

        }
    }
}
