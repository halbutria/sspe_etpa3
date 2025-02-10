using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class Existe
    {
        public class Ejecuta : IRequest<CiudadanoExisteDTO>
        {

            public string NumeroDocumento { get; set; }
            public int TipoDocumentoId { get; set; }
        }

        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            public EjecutaValidacion()
            {
                RuleFor(x => x.NumeroDocumento).NotEmpty();
                RuleFor(x => x.TipoDocumentoId).NotEmpty();
            }
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoExisteDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<CiudadanoExisteDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CiudadanoExisteDTO respuesta = new CiudadanoExisteDTO() { activo = false, existe = false };

                //var results = _contexto.CiudadanoPersona.ToList();

                try
                {
                    var ciudadano = await _contexto.Ciudadano.Where(x => x.TipoDocumentoId == request.TipoDocumentoId && x.NumeroDocumento == request.NumeroDocumento).FirstOrDefaultAsync();
                    //var ciudadano = await _contexto.CiudadanoPersona.Where(x => x.TipoDocumentoId == request.TipoDocumentoId && x.NumeroDocumento == request.NumeroDocumento).FirstOrDefaultAsync();                    
                    if (ciudadano is not null)
                    {
                        respuesta.activo = ciudadano.Activo;
                        respuesta.existe = true;
                    }
                    return respuesta;
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }

            }

        }
    }
}
