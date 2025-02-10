using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class DepartamentoInternacional : EntidadBase
    {
        public int Id { get; set; }
        public int PaisInternacionalId { get; set; }
        public string Codigo { get; set; }
        public PaisInternacional PaisInternacional { get; set; }
        public string DiviPolo { get; set; }
        public string Sigla { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Nombre { get; set; }
    }
}
