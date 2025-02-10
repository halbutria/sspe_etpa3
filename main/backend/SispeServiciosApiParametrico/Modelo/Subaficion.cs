using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Subaficion : EntidadBase
    {
        public int Id { get; set; }
        public string ClaseAficionId { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public ClaseAficion ClaseAficion { get; set; }
    }
}
