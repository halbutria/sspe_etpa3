using MediatR;
using AutoMapper;
using SispeServiciosApiCiudadano.DTOs;
using SispeServiciosApiCiudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using Microsoft.EntityFrameworkCore;
using SispeServiciosApiCiudadano.Aplicacion.VerificarCuenta;

namespace SispeServicios.Api.Ciudadano.Aplicacion.CiudadanoServiciosBasicos
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<CiudadanoServiciosBasicosDTO>
        {
            public CiudadanoServiciosBasicosDTO CiudadanoServiciosBasicos { get; set; } = new CiudadanoServiciosBasicosDTO();
        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoServiciosBasicosDTO>
        {

            private readonly Contexto _contexto;
            private readonly IMapper _mapper;
            private readonly IEmailService _email;

            public Manejador(Contexto contexto, IMapper mapper, IEmailService email)
            {
                _contexto = contexto;
                _mapper = mapper;
                _email = email;
            }

            public async Task<CiudadanoServiciosBasicosDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                CiudadanoServiciosBasicosModel? CiudadanoServiciosBasicos = await _contexto.CiudadanoServiciosBasicos.Where(x => x.CiudadanoId == request.CiudadanoServiciosBasicos.CiudadanoId
                                                                                            && x.CodigoServicio == request.CiudadanoServiciosBasicos.CodigoServicio)
                                                                                        .FirstOrDefaultAsync();
                if (CiudadanoServiciosBasicos is not null)
                {
                    CiudadanoServiciosBasicos.Fecha = request.CiudadanoServiciosBasicos.Fecha;
                    CiudadanoServiciosBasicos.EstadoServicio = request.CiudadanoServiciosBasicos.EstadoServicio;
                    _contexto.CiudadanoServiciosBasicos.Update(CiudadanoServiciosBasicos);
                }
                else
                {
                    CiudadanoServiciosBasicos = _mapper.Map<CiudadanoServiciosBasicosDTO, CiudadanoServiciosBasicosModel>(request.CiudadanoServiciosBasicos);
                    await _contexto.CiudadanoServiciosBasicos.AddAsync(CiudadanoServiciosBasicos);
                }

                var respuesta = await _contexto.SaveChangesAsync();

                if (respuesta > 0)
                {
                    if (request.CiudadanoServiciosBasicos.CodigoServicio == 3 || request.CiudadanoServiciosBasicos.CodigoServicio == 4)
                    {
                        await SendMail(request);
                    }
                    var resp = _mapper.Map<CiudadanoServiciosBasicosModel, CiudadanoServiciosBasicosDTO>(CiudadanoServiciosBasicos);
                    return resp;
                }

                throw new Exception("Error al gurdar barrera de empleo");
            }

            private async Task SendMail(Ejecuta request) {
                var ciudadano = await _contexto.Ciudadano.Where(x => x.Id == request.CiudadanoServiciosBasicos.CiudadanoId).FirstOrDefaultAsync();
                string asunto = "Gestión y administración de servicios de orientación ocupacional";
                if (ciudadano is not null)
                {
                    string mensaje = @$"Hola {ciudadano?.PrimerNombre} {ciudadano?.PrimerApellido}, <br/> <br/> 
                                    El Servicio Público de Empleo le informa que debe realizar el proceso
                                    <b> {request.CiudadanoServiciosBasicos.NombreServicio} </b> lo mas pronto posible <br/>";

                    _email.Send(ciudadano?.CorreoElectronico ?? string.Empty, asunto, mensaje);
                }

            }
        }
    }
}
