using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCDenominacion : EntidadBase
    {
        public string Id { get; set; }
        public string CUOCOcupacionId { get; set; }
        public string Nombre { get; set; }
        public string FuenteDenominacion { get; set; }
        public string CodigoCNO { get; set; }
        public string CodigoCIUO { get; set; }
        public CUOCOcupacion CUOCOcupacion { get; set; }
    }
}
