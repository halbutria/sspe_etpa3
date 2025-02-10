
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.DTOs;

namespace SispeServicios.Api.Parametrico.Aplicacion
{
    public class ConsultaMinimo
    {
        public class ConsultaMinimoParametrico : IRequest<SalarioMinimoDTO>
        {
            //public string? Nombre { get; set; }
            //public int? Valor { get; set; }

        }
        public class Manejador : IRequestHandler<ConsultaMinimoParametrico, SalarioMinimoDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<SalarioMinimoDTO> Handle(ConsultaMinimoParametrico request, CancellationToken cancellationToken)
            {
                var salario = await _contexto.rangoSalarial.FindAsync(2);
                SalarioMinimoDTO? outPut = new SalarioMinimoDTO();
                outPut = _mapper.Map<RangoSalarial, SalarioMinimoDTO>(salario);

                if (outPut is null)
                {
                    throw new Exception($"no encontrado");
                }
                return outPut;

            }
        }
    }
}
