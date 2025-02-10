using SispeServicios.DbContextBase.Modelo;
namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CUOCDestrezaOcupacion : EntidadBase
    {
        public int Id { get; set; }
        public string CUOCOcupacionId { get; set; }
        public string CUOCDestrezaId { get; set; }
        public CUOCOcupacion CUOCOcupacion { get; set; }
        public CUOCDestreza CUOCDestreza { get; set; }

    }
}
