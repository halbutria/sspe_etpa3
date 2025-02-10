using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCGranGrupo:EntidadBase
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public ICollection<CUOCGrupoPrimario> GruposPrimarios { get; set; }
    }
}
