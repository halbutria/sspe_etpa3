using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class ZonaGeografica:EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int TipoZonaGeograficaId { get; set; }
        public string MunicipioId { get; set; }
        public string? IdAnterior { get; set; }
        public TipoZonaGeografica TipoZonaGeografica { get; set; }
        public Municipio Municipio { get; set; }

    }
}
