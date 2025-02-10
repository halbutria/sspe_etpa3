using AutoMapper;
using MediatR;
using SispeServicios.Api.Ciudadano.DTOs;
using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.Api.Ciudadano.Persistencia;
using SispeServicios.Paginacion;

namespace SispeServicios.Api.Ciudadano.Aplicacion.ServiciosAsociados;

public class ListaPaginada
{
    public class Ejecuta : PaginacionDTO, IRequest<(string encabezado, List<ServiciosAsociadosDTO> registros)>
    {
        public Guid CiudadanoId { get; set; }
    }
    public class Manejador : IRequestHandler<Ejecuta, (string encabezado, List<ServiciosAsociadosDTO> registros)>
    {
        private Contexto _contexto;
        private IMapper _mapper;

        public Manejador(Contexto contexto, IMapper mapper)
        {
            _contexto = contexto;
            _mapper = mapper;
        }

        public async Task<(string encabezado, List<ServiciosAsociadosDTO> registros)> Handle(Ejecuta request, CancellationToken cancellationToken)
        {

            var query = _contexto.CiudadanoServiciosAsociados
                .AsQueryable();
            if (!String.IsNullOrEmpty(request.CiudadanoId.ToString()))
            {
                query = query.Where(x => x.CiudadanoId == request.CiudadanoId);
            }
            var pqrsPaginated = await ListaPaginada<CiudadanoServiciosAsociadosModel>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);

            var registrosDto = pqrsPaginated.Select(x => _mapper.Map<ServiciosAsociadosDTO>(x)).ToList();

            if (registrosDto.Count > 0)
            {
                return (pqrsPaginated.GetMetadata(), registrosDto);
            }
            throw new Exception("No existe Informacion.");
        }
    }
}

