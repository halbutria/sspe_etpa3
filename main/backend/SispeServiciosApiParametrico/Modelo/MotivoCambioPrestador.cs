using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class MotivoCambioPrestador : EntidadBase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
