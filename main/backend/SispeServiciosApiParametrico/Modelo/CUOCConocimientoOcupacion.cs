using SispeServicios.DbContextBase.Modelo;
namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCConocimientoOcupacion:EntidadBase
    {
        public int Id { get; set; }
        public string CUOCOcupacionId { get; set; }
        public string CUOCConocimientoId { get; set; }
        public CUOCOcupacion CUOCOcupacion { get; set; }
        public CUOCConocimiento CUOCConocimiento { get; set; }
    }
}
