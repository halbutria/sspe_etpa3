using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class DireccionCuadrante : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
    }
}
