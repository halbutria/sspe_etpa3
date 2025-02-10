using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class MunicipioInternacional : EntidadBase
    {
        public int Id { get; set; }
        public int DepartamentoInternacionalId { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public DepartamentoInternacional DepartamentoInternacional { get; set; }
        public string DiviPolo { get; set; }
        public string Sigla { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Nombre { get; set; }
    }
}
