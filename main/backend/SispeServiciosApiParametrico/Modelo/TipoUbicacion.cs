using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class TipoUbicacion : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
    }
}
