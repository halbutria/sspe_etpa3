using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class InformacionLaboral : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
