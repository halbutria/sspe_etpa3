using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Departamento : EntidadBase
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public ICollection<Municipio> Municipios { get; set; }
    }
}
