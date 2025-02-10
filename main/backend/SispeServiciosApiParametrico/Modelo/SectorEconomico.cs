using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class SectorEconomico : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<SubsectorEconomico> SubsectorEconomico { get; set; }
    }
}
