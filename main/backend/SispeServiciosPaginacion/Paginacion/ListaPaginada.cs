using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace SispeServicios.Paginacion
{
    public class ListaPaginada<T> : List<T>
    {
        public int? PaginaActual { get; private set; }
        public int CandidadPagina { get; private set; }
        public int RegistrosPorPagina { get; private set; }
        public int TotalRegistros { get; private set; }
        public bool Anterior => (PaginaActual > 1 && CandidadPagina >= PaginaActual);
        public bool Siguiente => PaginaActual < CandidadPagina;
        public ListaPaginada(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalRegistros = count;
            RegistrosPorPagina = pageSize;
            PaginaActual = pageNumber;
            CandidadPagina = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        public string GetMetadata()
        {
            var metadata = new
            {
                TotalRegistros,
                RegistrosPorPagina,
                PaginaActual,
                CandidadPagina,
                Siguiente,
                Anterior
            };

            return JsonConvert.SerializeObject(metadata);
        }
        public static async Task<ListaPaginada<T>> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            return new ListaPaginada<T>(items, count, pageNumber, pageSize);
        }
    }
}
