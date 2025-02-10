using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class TipoVacante : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
