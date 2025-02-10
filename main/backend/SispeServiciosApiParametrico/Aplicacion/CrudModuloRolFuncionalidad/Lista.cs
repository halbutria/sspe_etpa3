using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServiciosApiParametrico.Aplicacion.ModuloRolFuncionalidad
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<ModuloRolFuncionalidadDTO>>
        {
            public string? tipo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<ModuloRolFuncionalidadDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<List<ModuloRolFuncionalidadDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                List<ModuloRolFuncionalidadDTO> outPut = new();
                switch (request.tipo)
                {
                    case "ModuloRolFuncionalidad":
                        var moduloRolFuncionalidad = await _contexto.ModuloRolFuncionalidad.ToListAsync(cancellationToken);
                        outPut = _mapper.Map<List<ModuloRolFuncionalidadModel>, List<ModuloRolFuncionalidadDTO>>(moduloRolFuncionalidad);
                        break;

                    default:
                        throw new Exception($"{request.tipo} tipo no valido");
                }
                return outPut;
            }

        }
    }
}
