using System.Text.RegularExpressions;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCOcupacion
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string CUOCGrupoPrimarioId { get; set; }
        public string OcupacionNueva { get; set; }
        public string? Descripcion { get; set; }
        public int NivelCompetencia { get; set; }
        public ICollection<CUOCDenominacion>? CUOCDenominaciones { get; set; }
        public ICollection<CUOCConocimientoOcupacion> CUOCConocimientoOcupacion { get; set; }
        public ICollection<CUOCDestrezaOcupacion> CUOCDestrezaOcupacion { get; set; }
        public ICollection<CUOCFuncion> CUOCFuncion { get; set; }
        public CUOCGrupoPrimario CUOCGrupoPrimario { get; set; }
    }
}
