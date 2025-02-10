using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;

namespace SispeServicios.Api.Parametrico.Aplicacion.CrudPasosRutaEmpleabilidad
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ParametricoDTO>
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public string? Descripcion { get; set; }
            public List<string> Direccionamientos { get; set; }

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
                var info = await _contexto.PasosRutaEmpleabilidad
                            .Include(e => e.Direccionamientos)
                            .FirstOrDefaultAsync(e => e.Id == Int32.Parse(request.Id), cancellationToken);
                if (info is not null)
                {
                    _mapper.Map(request, info, typeof(Ejecuta), typeof(Modelo.PasosRutaEmpleabilidad));

                    _contexto.PasosRutaEmpleabilidad.Update(info);

                    await _contexto.SaveChangesAsync();

                    return _mapper.Map<Modelo.PasosRutaEmpleabilidad, ParametricoDTO>(info);

                }
                throw new Exception("No existe Informacion a editar.");
            }
        }
    }
}
