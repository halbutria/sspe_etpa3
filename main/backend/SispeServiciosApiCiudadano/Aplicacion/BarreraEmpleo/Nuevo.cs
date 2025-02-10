using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.BarreraEmpleo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<List<BarreraEmpleoDTO>>
        {
            public List<BarreraEmpleoDTO> BarrerasEmpleo { get; set; } = new List<BarreraEmpleoDTO>();
        }

        public class Manejador : IRequestHandler<Ejecuta, List<BarreraEmpleoDTO>>
        {

            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<BarreraEmpleoDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var barrerasEmpleo = _mapper.Map<List<BarreraEmpleoDTO>, List<BarreraEmpleoModel>>(request.BarrerasEmpleo);
                foreach (var barreraEmpleo in barrerasEmpleo)
                {

                    var barreraEmepleoRegistrada = await _contexto.BarreraEmpleo.Where(b => b.CiudadanoId == barreraEmpleo.CiudadanoId
                                                                                                && b.TipoBarrera == barreraEmpleo.TipoBarrera
                                                                                                && b.CodigoPregunta == barreraEmpleo.CodigoPregunta
                                                                                            ).AsNoTracking().FirstOrDefaultAsync();

                    if (barreraEmepleoRegistrada != null)
                    {
                        barreraEmpleo.Id = barreraEmepleoRegistrada.Id;
                        _contexto.BarreraEmpleo.Update(barreraEmpleo);
                    }
                    else
                    {
                        await _contexto.BarreraEmpleo.AddAsync(barreraEmpleo);
                    }
                }

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    var resp = _mapper.Map<List<BarreraEmpleoModel>, List<BarreraEmpleoDTO>>(barrerasEmpleo);
                    return resp;
                }
                throw new Exception("Error al gurdar barrera de empleo");
            }
        }
    }
}
