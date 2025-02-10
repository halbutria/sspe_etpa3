using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;
using SispeServiciosApiParametrico.Modelo;

namespace SispeServiciosApiParametrico.Aplicacion.Rol
{
    public class Lista
    {
        public class Ejecuta : IRequest<List<RolDTO>>
        {
            public string? tipo { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, List<RolDTO>>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<List<RolDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                List<RolDTO> outPut = new List<RolDTO>();
                switch (request.tipo)
                {
                    case "Rol":
                        var rol = await _contexto.Rol.ToListAsync(cancellationToken: cancellationToken);
                        outPut = _mapper.Map<List<RolModel>, List<RolDTO>>(rol);
                        break;

                    default:
                        throw new Exception($"{request.tipo} tipo no valido");
                }
                return outPut;
            }

        }
    }
}
