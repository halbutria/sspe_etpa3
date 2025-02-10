using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class CriterioMatch : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int TipoVacanteId { get; set; }
        public int Peso { get; set; }
        public bool Estado { get; set; }
        public virtual TipoVacante TipoVacante { get; set; }
    }
}
