using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosOferta
{
    public class Edicion
    {
        public class Ejecuta : IRequest<ServiciosOfertaDTO>
        {
            public Guid Id { get; set; }
            public Guid CiudadanoId { get; set; }
            public int ServiciosOfertaId { get; set; }
            public string CodigoServiciosOferta { get; set; } = string.Empty;
            public string NombreServiciosOferta { get; set; } = string.Empty;
            public int BrechaServiciosOfertaId { get; set; }
            public string CodigoBrechaServiciosOferta { get; set; } = string.Empty;
            public string NombreBrechaServiciosOferta { get; set; } = string.Empty;
            public string? Seguimiento { get; set; } = string.Empty;
            public string? Observacion { get; set; } = string.Empty;
        }
        public class Manejador : IRequestHandler<Ejecuta, ServiciosOfertaDTO>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<ServiciosOfertaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var info = await _contexto.CiudadanoServiciosOferta.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

                var infoCiuRed = await _contexto.CiudadanoServiciosOferta
                    .Where(x =>
                        x.CiudadanoId == request.CiudadanoId &&
                        x.ServiciosOfertaId == request.ServiciosOfertaId &&
                        x.BrechaServiciosOfertaId == request.BrechaServiciosOfertaId &&
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
                        return _mapper.Map<CiudadanoServiciosOfertaModel, ServiciosOfertaDTO>(info);
                        //}

                        //throw new Exception("Error al editar");
                    }
                    throw new Exception("No existe Informacion a editar.");
                }
                throw new Exception("Servicio oferta ya registrada para el ciudadano.");
            }
        }

    }
}
