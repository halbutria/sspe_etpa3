using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteService;


namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class CambioEstado
    {
        public class Ejecuta : IRequest<CiudadanoCambioEstadoDTO>
        {
            public Guid Id { get; set; }
            public bool Activo { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoCambioEstadoDTO>
        {
            private readonly Contexto _contexto;
            private readonly IUsuarioService _usuarioService;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IUsuarioService usuarioService, IMapper mapper)
            {
                _contexto = contexto;
                _usuarioService = usuarioService;
                _mapper = mapper;
            }

            public class EjecutaValidacion : AbstractValidator<Ejecuta>
            {
                private readonly IHttpClientFactory _httpClient;

                public EjecutaValidacion(IHttpClientFactory httpClient, ILogger<UsuarioService> logger)
                {
                    _httpClient = httpClient;


                    //RuleFor(x => x.Id).NotEmpty();
                    //RuleFor(x => x.Activo).NotEmpty();

                }
            }

            public async Task<CiudadanoCambioEstadoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var ciudadano = await _contexto.Ciudadano.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
                if (ciudadano is not null)
                {

                    ciudadano.Eliminado = request.Activo;

                    _contexto.Ciudadano.Update(ciudadano);
                    
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<CiudadanoModel, CiudadanoCambioEstadoDTO>(ciudadano);
                    }

                    throw new Exception("Error al cambiar el estado del Ciudadano");
                }

                throw new Exception("No existe Ciudadano.");
            }
        }

    }
}
