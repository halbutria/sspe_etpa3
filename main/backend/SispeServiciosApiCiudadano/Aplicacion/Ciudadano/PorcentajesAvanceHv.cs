using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Api.Ciudadano.RemoteInterface;
using SispeServicios.Api.Ciudadano.RemoteModel;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class PorcentajeAvanceHV
    {
        public class Ejecuta : IRequest<PorcentajesAvanceDTO>
        {
            public Guid? CiudadanoId { get; set; }
        }

        //public class EjecutaValidacion : AbstractValidator<Ejecuta>
        //{
        //    public EjecutaValidacion()
        //    {
        //        RuleFor(x => x.CiudadanoId).NotEmpty();
        //    }
        //}

        public class Manejador : IRequestHandler<Ejecuta, PorcentajesAvanceDTO>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<PorcentajesAvanceDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var query = _contexto.Ciudadano;
                var ciudadano = new CiudadanoModel();

                try
                {
                    ciudadano = await query.Where(x => x.Id == request.CiudadanoId).FirstOrDefaultAsync();

                    if (ciudadano is not null)
                    {
                        var mapp = _mapper.Map<CiudadanoModel, PorcentajesAvanceDTO>(ciudadano);
                        return mapp;
                    }

                    throw new Exception("Ciudadano no encontrado");
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }

            }

        }
    }
}
