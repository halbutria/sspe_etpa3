using AutoMapper;
using MediatR;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoEncuentasIes
{
    public class Nuevo
    {

        public class Ejecuta : IRequest<CiudadanoEncuentasIesDTO>
        {
            public CiudadanoEncuentasIesDTO CiudadanoEncuentasIes { get; set; } = new CiudadanoEncuentasIesDTO();
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoEncuentasIesDTO>
        {

            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<CiudadanoEncuentasIesDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var ciudadanoEncuentasIes = _mapper.Map<CiudadanoEncuentasIesDTO, CiudadanoEncuentasIesModel>(request.CiudadanoEncuentasIes);
                await _contexto.CiudadanoEncuentasIes.AddAsync(ciudadanoEncuentasIes);

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    var resp = _mapper.Map<CiudadanoEncuentasIesModel, CiudadanoEncuentasIesDTO>(ciudadanoEncuentasIes);
                    return resp;
                }

                throw new Exception("Error al gurdar barrera de empleo");
            }
        }
    }
}
