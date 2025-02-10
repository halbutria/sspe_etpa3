using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosBasicos
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ServiciosBasicosDTO>
        {
            public Guid Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public int ServiciosBasicosId { get; set; }
            public string CodigoServiciosBasicos { get; set; } = string.Empty;
            public string NombreServiciosBasicos { get; set; } = string.Empty;
            public int BrechaServiciosBasicosId { get; set; }
            public string CodigoBrechaServiciosBasicos { get; set; } = string.Empty;
            public string NombreBrechaServiciosBasicos { get; set; } = string.Empty;
            public string? Seguimiento { get; set; } = string.Empty;
            public string? Observacion { get; set; } = string.Empty;
        }
        public class Manejador : IRequestHandler<Ejecuta, ServiciosBasicosDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ServiciosBasicosDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoServiciosBasicosBrecha.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                var infoCiuRed = await _contexto.CiudadanoServiciosBasicosBrecha
                    .Where(x =>
                        x.CiudadanoId == request.CiudadanoId &&
                        x.ServiciosBasicosId == request.ServiciosBasicosId &&
                        x.BrechaServiciosBasicosId == request.BrechaServiciosBasicosId &&
                        x.Id != request.Id
                    ).FirstOrDefaultAsync();

                if (infoCiuRed is null)
                {
                    if (info is not null)
                    {
                        info.Seguimiento = request.Seguimiento;
                        info.Observacion = request.Observacion;
                        var respuesta = await _contexto.SaveChangesAsync();
                        //if (respuesta > 0)
                        //{
                        return _mapper.Map<CiudadanoServiciosBasicosBrechaModel, ServiciosBasicosDTO>(info);
                        //}

                        //throw new Exception("Error al editar");
                    }
                    throw new Exception("No existe Informacion a editar.");
                }
                throw new Exception("Servicio basico ya registrada para el ciudadano.");
            }
        }

    }
}
