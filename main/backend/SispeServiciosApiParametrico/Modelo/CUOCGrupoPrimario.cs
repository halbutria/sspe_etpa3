using System.Text.RegularExpressions;
using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCGrupoPrimario:EntidadBase
    {
        public string Id { get; set; }
        public string CUOCGranGrupoId { get; set; }
        public string Nombre { get; set; }
        public string? NotaExplicativa { get; set; }
        public string? NotaAclaratoria { get; set; }
        public CUOCGranGrupo CUOCGranGrupo { get; set; }
        ICollection<CUOCOcupacion> CUOCOcupaciones { get; set; }
    }
}
