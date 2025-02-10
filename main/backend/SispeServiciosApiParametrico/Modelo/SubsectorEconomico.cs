using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class SubsectorEconomico : EntidadBase
    {
        public int Id { get; set; }
        public int SectorEconomicoId { get; set; }
        public string Nombre { get; set; }
        public SectorEconomico SectorEconomico { get; set; }
    }
}
