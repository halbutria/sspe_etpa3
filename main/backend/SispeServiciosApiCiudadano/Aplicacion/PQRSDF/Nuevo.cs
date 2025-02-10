using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;

namespace SispeServicios.Api.Ciudadano.Aplicacion.PQRSDF
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<CiudadanoPQRSDFResponseDto>
        {
            public string Prestador { get; set; }
            public string PrimerNombre { get; set; }
            public string? SegundoNombre { get; set; }
            public string PrimerApellido { get; set; }
            public string? SegundoApellido { get; set; }
            public int TipoDocumentoId { get; set; }
            public string NumeroDocumento { get; set; }
            public string Telefono { get; set; }
            public string CorreoElectronico { get; set; }
            public int TipoPQRSDFId { get; set; }
            public string HechosPQR { get; set; }

        }

        public class Manejador : IRequestHandler<Ejecuta, CiudadanoPQRSDFResponseDto>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<CiudadanoPQRSDFResponseDto> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var pqr = _mapper.Map<Ejecuta, CiudadanoPQRSDF>(request);
                TimeZoneInfo zonaHorariaColombia = TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");
                DateTime fechaActual = TimeZoneInfo.ConvertTime(DateTime.Now, zonaHorariaColombia);

                var año = fechaActual.ToString("yyyy");
                var mes = fechaActual.ToString("MM");
                var dia = fechaActual.ToString("dd");
                pqr.FechaRegistro = fechaActual;


                var maxConsecutivo = await _contexto.CiudadanoPQRSDF
                    .Where(x => x.FechaRegistro.Year == fechaActual.Year &&
                                x.FechaRegistro.Month == fechaActual.Month &&
                                x.FechaRegistro.Day == fechaActual.Day)
                    .CountAsync();

                int nuevoConsecutivo = maxConsecutivo + 1;
                var consecutivoFormateado = nuevoConsecutivo.ToString("D5");
                pqr.Radicado = $"{año}{mes}{dia}{consecutivoFormateado}";

                try
                {
                    _contexto.CiudadanoPQRSDF.Add(pqr);
                    var respuesta = await _contexto.SaveChangesAsync();

                    if (respuesta > 0)
                    {
                        var resp = await _contexto.CiudadanoPQRSDF
                            .Include(x => x.TipoPQRSDF)
                            .FirstOrDefaultAsync(x => x.Id == pqr.Id);
                        resp.Radicado = "Sr Usuario su solicitud quedó radicada bajo el No. " + resp.Radicado;
                        return _mapper.Map<CiudadanoPQRSDF, CiudadanoPQRSDFResponseDto>(resp);
                    }
                }

                catch (Exception ex)
                {
                    var innerException = ex.InnerException?.Message ?? ex.Message;
                    throw new Exception($"Ocurrió un error al guardar los cambios en la entidad: {innerException}", ex);
                }

                throw new Exception("Error al guardar el PQRSDF.");
            }
        }

    }
}
