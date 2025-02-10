using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Aplicacion.Utils;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteService;
using SispeServiciosApiCiudadano.DTOs;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class CambioTieneExperienciaPrevia
    {
        public class Ejecuta : IRequest<CiudadanoTieneExperienciaPreviaDTO>
        {
            public Guid CiudadanoId { get; set; }
            public bool TieneExperienciaLaboral { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoTieneExperienciaPreviaDTO>
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
                }
            }

            public async Task<CiudadanoTieneExperienciaPreviaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var ciudadano = await _contexto.Ciudadano.Where(x => x.Id == request.CiudadanoId).FirstOrDefaultAsync();

                if (ciudadano is not null)
                {
                    /*var avance = await CalculoAvanceHojaVida.procesarAsync(_contexto, ciudadano, "EducacionNoFormal");
                    ciudadano.PorcentajeEduNoFormal = avance.Avance;
                    ciudadano.PorcentajeHv = avance.AvanceTotal;
                    ciudadano.HojaVidaCompleta = avance.HojaVidaCompleta;*/

                    ciudadano.TieneExperienciaLaboral = request.TieneExperienciaLaboral;
                    _contexto.Ciudadano.Update(ciudadano);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        return _mapper.Map<CiudadanoModel, CiudadanoTieneExperienciaPreviaDTO>(ciudadano);
                    }

                    throw new Exception("Error al cambiar el estado del Ciudadano");
                }

                throw new Exception("No existe Ciudadano.");
            }
        }

    }
}
