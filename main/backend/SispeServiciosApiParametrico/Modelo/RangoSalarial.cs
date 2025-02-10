using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class RangoSalarial : EntidadBase
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? ValorInicial { get; set; }
        public int? ValorFinal { get; set; }
    }
}
