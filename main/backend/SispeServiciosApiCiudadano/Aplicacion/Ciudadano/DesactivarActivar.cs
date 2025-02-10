using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using System;

namespace SispeServicios.Api.Ciudadano.Aplicacion.Ciudadano
{
    public class DesactivarActivar
    {
        public class Ejecuta : IRequest<CiudadanoExisteDTO>
        {

            public Guid Id { get; set; }
            public bool Activar { get; set; }
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
                try
                {
                    var ciudadano = await _contexto.Ciudadano.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                    if (ciudadano is not null)
                    {
                        ciudadano.Activo = !request.Activar; 
                        ciudadano.Eliminado = ciudadano.Activo.Value;
                        respuesta.activo = ciudadano.Activo;
                        respuesta.existe = true;
                        await _contexto.SaveChangesAsync();
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
