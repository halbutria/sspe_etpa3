using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServiciosApiCiudadano.DTOs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SispeServiciosApiCiudadano.Aplicacion.Ciudadano
{
    public class Certificado
    {
        public class EjecutaCertificado : IRequest<CertificadoInscripcionDTO>
        {
            public string Id { get; set; } = null!;
            public string? NumeroDocumento { get; set; }
            public int? TipoDocumentoId { get; set; }
            public int? TipoPersona { get; set; }
        }

        public class ManejadorCertificado : IRequestHandler<EjecutaCertificado, CertificadoInscripcionDTO>
        {
            private readonly Contexto _contexto;
            private readonly ContextoParametrico _contextoParametrico;
            private readonly IMapper _mapper;

            public ManejadorCertificado(Contexto contexto, ContextoParametrico contextoParametrico, IMapper mapper)
            {
                _contexto = contexto;
                _contextoParametrico = contextoParametrico;
                _mapper = mapper;
            }

            public async Task<CertificadoInscripcionDTO> Handle(EjecutaCertificado request, CancellationToken cancellationToken)
            {
                try
                {
                    CertificadoInscripcionDTO certificadoInscripcionDTO = new CertificadoInscripcionDTO();



                    var query = _contexto.PersonaModel.Where(x => x.TipoPersona == request.TipoPersona);

                    //var query = _contexto.Ciudadano.Include(i => i.CargoInteres);
                    var ciudadano = new Modelo.PersonaModel();
                    if (request.Id != "00000000-0000-0000-0000-000000000000")
                    {
                        ciudadano = await query
                            .Where(x => x.Id == request.Id)
                            .FirstOrDefaultAsync();
                    }
                    else if (request.TipoDocumentoId is not null && request.NumeroDocumento is not null)
                    {
                        ciudadano = await query
                            .Where(x => x.TipoDocumentoId == request.TipoDocumentoId && x.NumeroDocumento == request.NumeroDocumento && x.Activo == true)
                            .FirstOrDefaultAsync();
                    }

                    if (ciudadano is not null)
                    {
                        var queryTipoDocumento = await _contextoParametrico.tipoDocumento.Where(a => a.Id == ciudadano.TipoDocumentoId).FirstOrDefaultAsync();
                        var tipoDocumento = queryTipoDocumento != null ? queryTipoDocumento.Nombre : string.Empty;

                        certificadoInscripcionDTO.TipoIdentificacion = tipoDocumento;
                        certificadoInscripcionDTO.NumeroIdentificacion = ciudadano.NumeroDocumento;
                        certificadoInscripcionDTO.Nombre = string.Format("{0} {1} {2} {3} {4}", ciudadano.PrimerNombre, ciudadano.SegundoNombre, ciudadano.PrimerApellido, ciudadano.SegundoApellido,  ciudadano.RazonSocial);
                    }
                    else
                    {
                        throw new Exception("Ciudadano no encontrado");
                    }
                    

                    return certificadoInscripcionDTO;
                }
                catch (Exception ex)
                {
                    return null;
                    throw new Exception(ex.Message);
                }


            }
        }


    }
}
