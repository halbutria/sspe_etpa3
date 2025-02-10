using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SispeServicios.Api.Parametrico.DTOs;
using SispeServicios.Api.Parametrico.Modelo;
using SispeServicios.Api.Parametrico.Persistencia;
using SispeServicios.Paginacion;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static SispeServicios.Api.Parametrico.Aplicacion.Consulta;

namespace SispeServicios.Api.Parametrico.Aplicacion
{
    public class Filtro
    {
        public class FiltroParametrico : PaginacionDTO, IRequest<(string encabezado, List<ParametricoDTO> parametricos)>
        {
            public string? Tipo { get; set; }
            public string? Busqueda { get; set; }
            public List<String>? BusquedaId { get; set; }
            public List<String>? PadreId { get; set; }
        }

        public class Manejador : IRequestHandler<FiltroParametrico, (string encabezado, List<ParametricoDTO> parametricos)>
        {
            private readonly Contexto _contexto;
            private readonly IMapper _mapper;
            private (string encabezado, List<ParametricoDTO> parametricos) outPut;

            public Manejador(Contexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<(string encabezado, List<ParametricoDTO> parametricos)> Handle(FiltroParametrico request, CancellationToken cancellationToken)
            {                
                switch (request.Tipo)
                {
                    case "CUOCDenominacion":
                        outPut=  await FiltroCUOCdenominacion(request);
                        break;
                    case "CUOCOcupacion":                       
                        outPut = await FiltroCUOCOcupacion(request);
                        break;
                    case "CUOCConocimientoBase":
                        outPut = await FiltroCUOCConocimientoBase(request);
                        break;
                    case "CUOCDestrezaBase":
                        outPut = await FiltroCUOCDestrezaBase(request);
                        break;
                    case "CUOCConocimiento":
                        outPut = await FiltroCUOCConocimiento(request);
                        break;
                    case "CUOCDestreza":                        
                        outPut = await FiltroCUOCDestreza(request);
                        break;
                }

                return outPut;
            }


            private async Task<(string encabezado, List<ParametricoDTO> parametricos)> FiltroCUOCDestreza(FiltroParametrico request)
            {

                var query = _contexto.CUOCdestreza
                      .Include(i => i.CUOCDestrezaOcupacion)
                          .ThenInclude(ti => ti.CUOCOcupacion.CUOCDenominaciones)
                      .AsQueryable();
                IQueryable<CUOCDestreza>? querymMerge = null;
                if (request.Busqueda is not null)
                {
                    query = query.Where(x => x.Nombre.ToLower().Contains(request.Busqueda.Trim().ToLower()));
                    //querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }

                if (request.BusquedaId is not null)
                {
                    var query2 = query;
                    query2 = query.Where(x => request.BusquedaId.Contains(x.Id.ToLower()));
                    querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }
                if (request.PadreId is not null)
                {
                    var query2 = query
                    .Where(x => x.CUOCDestrezaOcupacion.Any(x => x.CUOCOcupacion.CUOCDenominaciones.Any(z => request.PadreId.Contains(z.Id))));
                    querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }

                querymMerge = (querymMerge is null) ? query : querymMerge;
                query = querymMerge.OrderByDescending(x => x.Nombre);
                var info = await ListaPaginada<CUOCDestreza>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
                var outPut = _mapper.Map<List<CUOCDestreza>, List<ParametricoDTO>>(info);
                return (info.GetMetadata(), outPut);
            }


            private async Task<(string encabezado, List<ParametricoDTO> parametricos)> FiltroCUOCConocimiento(FiltroParametrico request)
            {
                var query = _contexto.CUOCconocimiento                    
                    .Include(i => i.CUOCConocimientoOcupacion)
                        .ThenInclude(ti => ti.CUOCOcupacion.CUOCDenominaciones)
                    .AsQueryable();
                IQueryable<CUOCConocimiento>? querymMerge = null;

                if (request.Busqueda is not null)
                {
                    query = query.Where(x => x.Nombre.ToLower().Contains(request.Busqueda.Trim().ToLower()));
                    //querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }

                if (request.BusquedaId is not null)
                {
                    var query2 = query;
                    query2 = query.Where(x => request.BusquedaId.Contains(x.Id.ToLower()));
                    querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }               
                if (request.PadreId is not null)
                {
                    var query2 = query
                    .Where(x => x.CUOCConocimientoOcupacion.Any(x => x.CUOCOcupacion.CUOCDenominaciones.Any(z => request.PadreId.Contains(z.Id))));
                   querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }
                
                querymMerge = (querymMerge is null) ? query : querymMerge;
                query = querymMerge.OrderByDescending(x => x.Nombre);
                var info = await ListaPaginada<CUOCConocimiento>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
                var outPut = _mapper.Map<List<CUOCConocimiento>, List<ParametricoDTO>>(info);
                return (info.GetMetadata(), outPut);
            }

            private async Task<(string encabezado, List<ParametricoDTO> parametricos)> FiltroCUOCDestrezaBase(FiltroParametrico request)
            {
                var query = _contexto.CUOCdestreza.AsQueryable();
                IQueryable<CUOCDestreza>? querymMerge = null;
                if (request.BusquedaId is not null)
                {
                    querymMerge = query.Where(x => request.BusquedaId.Contains(x.Id.ToLower()));
                }
                if (request.Busqueda is not null)
                {
                    var query2 = query.Where(x => x.Nombre.ToLower().Contains(request.Busqueda.Trim().ToLower()));
                    querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }
                querymMerge = (querymMerge is null) ? query : querymMerge;
                query = querymMerge.OrderByDescending(x => x.Nombre);
                query.Select(x => new { x.Id, x.Nombre });
                var info = await ListaPaginada<CUOCDestreza>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
                var outPut = _mapper.Map<List<CUOCDestreza>, List<ParametricoDTO>>(info);
                return (info.GetMetadata(), outPut);
            }


            private async Task<(string encabezado, List<ParametricoDTO> parametricos)> FiltroCUOCConocimientoBase(FiltroParametrico request)
            {
                var query = _contexto.CUOCconocimiento.AsQueryable();
                IQueryable<CUOCConocimiento>? querymMerge = null;
                if (request.BusquedaId is not null)
                {
                    querymMerge = query.Where(x => request.BusquedaId.Contains(x.Id.ToLower()));
                }
                if (request.Busqueda is not null)
                {
                    var query2 = query.Where(x => x.Nombre.ToLower().Contains(request.Busqueda.Trim().ToLower()));
                    querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }
                querymMerge = (querymMerge is null) ? query : querymMerge;
                query = querymMerge.OrderBy(x => x.Nombre);
                var info = await ListaPaginada<CUOCConocimiento>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
                var outPut = _mapper.Map<List<CUOCConocimiento>, List<ParametricoDTO>>(info);
                return (info.GetMetadata(), outPut);
            }


            private async Task<(string encabezado, List<ParametricoDTO> parametricos)> FiltroCUOCdenominacion(FiltroParametrico request)
            {
                var query = _contexto.CUOCdenominacion.AsQueryable();
                IQueryable<CUOCDenominacion>? querymMerge = null;
                if (request.BusquedaId is not null)
                {
                    querymMerge = query.Where(x => request.BusquedaId.Contains(x.Id.ToLower()));
                }
                if (request.Busqueda is not null)
                {
                    var query2 = query.Where(x => x.Nombre.ToLower().Contains(request.Busqueda.Trim().ToLower()));
                    querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }
                querymMerge = (querymMerge is null) ? query : querymMerge;
                query = querymMerge.OrderBy(x => x.Nombre);
                var info = await ListaPaginada<CUOCDenominacion>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
                var outPut = _mapper.Map<List<CUOCDenominacion>, List<ParametricoDTO>>(info);
                return (info.GetMetadata(), outPut);
            }

            private async Task<(string encabezado, List<ParametricoDTO> parametricos)> FiltroCUOCOcupacion(FiltroParametrico request)
            {
                var query = _contexto.CUOCocupacion.AsQueryable();
                IQueryable<CUOCOcupacion>? querymMerge = null;
                if (request.BusquedaId is not null)
                {
                    querymMerge = query.Where(x => request.BusquedaId.Contains(x.Id.ToLower()));
                }
                if (request.Busqueda is not null)
                {
                    var query2 = query.Where(x => x.Nombre.ToLower().Contains(request.Busqueda.Trim().ToLower()));
                    querymMerge = (querymMerge is null) ? query2 : querymMerge.Union(query2);
                }
                querymMerge = (querymMerge is null) ? query : querymMerge;
                query = querymMerge.OrderBy(x => x.Nombre);
                var info = await ListaPaginada<CUOCOcupacion>.ToPagedList(query, request.Pagina, request.RegistrosPorPagina);
                var outPut = _mapper.Map<List<CUOCOcupacion>, List<ParametricoDTO>>(info);
                return (info.GetMetadata(), outPut);
            }
        }
    }
}
