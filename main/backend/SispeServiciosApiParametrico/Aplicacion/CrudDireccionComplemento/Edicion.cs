using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudDireccionComplemento
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string? Id { get; set; }
            public string? Nombre { get; set; }
            public string? Sigla { get; set; }

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
                var info = await _contexto.direccionComplemento.FindAsync(Int32.Parse(request.Id));

                if (info is not null)
                {
                    _mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.DireccionComplemento));

                    _contexto.direccionComplemento.Update(info);

                    await _contexto.SaveChangesAsync();

                    return _mapper.Map<Modelo.DireccionComplemento, ParametricoDTO>(info);
           
                }
                throw new Exception("No existe Informacion a editar.");
            }
        }

    }
}
