using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Intermediacion.DTOs;
using SispeServicios.Api.Intermediacion.Modelo;
using SispeServicios.Api.Intermediacion.Persistencia;
using SispeServicios.Paginacion;
using System.Linq;

namespace SispeServicios.Api.Intermediacion.Aplicacion.Vacante
{
    public class Lista
    {
        public class Ejecuta : PaginacionDTO, IRequest<(string encabezado, List<VacanteInfoDTO> vacantes)>
        {
            public int? SedeId { get; set; }
            public int? EstadoId { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta, (string encabezado, List<VacanteInfoDTO> vacantes)>
        {
            private Contexto _contexto;
            private IMapper _mapper;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<(string encabezado ,List<VacanteInfoDTO> vacantes)> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var query  =  _contexto.Vacantes.AsQueryable();
               
                if (request.SedeId is not null)
                {
                    query = query.Where(x => x.SedeId == request.SedeId);
                }
                if (request.EstadoId is not null)
                {
                    query = query.Where(x => x.EstadoId == request.EstadoId);
                }
                query = query
                    .Include(i => i.Estado)
                    .Include(i => i.Ubicaciones)
                    .OrderByDescending(x => x.FechaCreacion);

                var info = await ListaPaginada<VacanteModel>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
  
                if (info is not null)
                {
                    return (info.GetMetadata(),_mapper.Map<List<VacanteModel>, List<VacanteInfoDTO>>(info));
                }
                throw new Exception("No existe Información.");
            }
        }
    }
}
