using SispeServicios.DbContextBase.Modelo;

namespace SispeServiciosApiCiudadano.Modelo.Parametricos
{
    public class Genero : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
    }
}
