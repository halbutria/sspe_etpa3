using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCFuncion:EntidadBase
    {
        public int Id { get; set; }
        public string CUOCOcupacionId { get; set; }
        public string ConsecutivoFuncion { get; set; }
        public string Nombre { get; set; }
        public string FuenteCIOU { get; set; }
        public string FuenteCNO { get; set; }
        public CUOCOcupacion CUOCOcupacion { get; set; }
    }
}
