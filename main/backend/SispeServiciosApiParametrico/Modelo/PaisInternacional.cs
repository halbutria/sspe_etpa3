using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class PaisInternacional : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public string Nacionalidad{ get; set; }
        public string Codigo { get; set; }
    }
}
