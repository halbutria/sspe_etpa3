using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServiciosApiParametrico.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudInactivacionCuenta
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public int? Meses { get; set; }
            public string? Descripcion { get; set; }
            public Guid? RolModelId { get; set; }
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
                var info = await _contexto.InactivacionCuenta
                            .Include(i => i.RolModel)
                            .FirstOrDefaultAsync(i => i.Id == Int32.Parse(request.Id), cancellationToken);
                if (info is not null)
                {
                    return _mapper.Map<Modelo.InactivacionCuenta, ParametricoDTO>(info);
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
