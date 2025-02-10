using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Paginacion;

namespace SispeServicios.Api.Ciudadano.Aplicacion.PQRSDF;

public class Lista
{
    public class Ejecuta : PaginacionDTO, IRequest<(string encabezado, List<CiudadanoPQRSDFResponseDto> registros)>
    {
        public string? Prestador { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string? TipoIdentificacionPrestador { get; set; }
        public string? IdentificacionPrestador { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }
        public string? SegundoApellido { get; set; }
        public int? TipoDocumentoId { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public int? TipoPQRSDFId { get; set; }
        public string? Radicado { get; set; }

    }
    public class Manejador : IRequestHandler<Ejecuta, (string encabezado, List<CiudadanoPQRSDFResponseDto> registros)>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<(string encabezado, List<CiudadanoPQRSDFResponseDto> registros)> Handle(Ejecuta request, CancellationToken cancellationToken)
        {
            var query = _contexto.CiudadanoPQRSDF
                .Include(c => c.TipoPQRSDF)
                .AsQueryable();

            if (!String.IsNullOrEmpty(request.Prestador))
            {
                query = query.Where(x => x.Prestador == request.Prestador);
            }

            if (request.FechaRegistro.HasValue)
            {
                query = query.Where(x => x.FechaRegistro.Date == request.FechaRegistro.Value.Date);
            }

            if (!String.IsNullOrEmpty(request.PrimerNombre))
            {
                query = query.Where(x => x.PrimerNombre.Contains(request.PrimerNombre));
            }

            if (!String.IsNullOrEmpty(request.SegundoNombre))
            {
                query = query.Where(x => x.SegundoNombre.Contains(request.SegundoNombre));
            }

            if (!String.IsNullOrEmpty(request.PrimerApellido))
            {
                query = query.Where(x => x.PrimerApellido.Contains(request.PrimerApellido));
            }

            if (!String.IsNullOrEmpty(request.SegundoApellido))
            {
                query = query.Where(x => x.SegundoApellido.Contains(request.SegundoApellido));
            }

            if (request.TipoDocumentoId.HasValue)
            {
                query = query.Where(x => x.TipoDocumentoId == request.TipoDocumentoId.Value);
            }

            if (!String.IsNullOrEmpty(request.NumeroDocumento))
            {
                query = query.Where(x => x.NumeroDocumento == request.NumeroDocumento);
            }

            if (!String.IsNullOrEmpty(request.Telefono))
            {
                query = query.Where(x => x.Telefono.Contains(request.Telefono));
            }

            if (!String.IsNullOrEmpty(request.CorreoElectronico))
            {
                query = query.Where(x => x.CorreoElectronico.Contains(request.CorreoElectronico));
            }

            if (request.TipoPQRSDFId.HasValue)
            {
                query = query.Where(x => x.TipoPQRSDFId == request.TipoPQRSDFId.Value);
            }

            if (!String.IsNullOrEmpty(request.Radicado))
            {
                query = query.Where(x => x.Radicado == request.Radicado);
            }

            var pqrsPaginated = await ListaPaginada<CiudadanoPQRSDF>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
            foreach (var item in pqrsPaginated)
            {
                item.Radicado = "Sr Usuario su solicitud quedó radicada bajo el No. " + item.Radicado;
            }
            var registrosDto = pqrsPaginated.Select(x => _mapper.Map<CiudadanoPQRSDFResponseDto>(x)).ToList();

            if (registrosDto.Count > 0)
            {
                return (pqrsPaginated.GetMetadata(), registrosDto);
            }


            throw new Exception("No existe Informacion.");
        }
    }

    public class PQRSPaginatedResponse
    {
        public string Encabezado { get; set; }
        public List<CiudadanoPQRSDFResponseDto> Registros { get; set; }

        public PQRSPaginatedResponse(string encabezado, List<CiudadanoPQRSDFResponseDto> registros)
        {
            Encabezado = encabezado;
            Registros = registros;
        }
    }
}

