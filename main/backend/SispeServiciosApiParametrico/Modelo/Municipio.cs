using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Municipio : EntidadBase
    {
        public string Id { get; set; }
        public string DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public Departamento Departamento { get; set; }
    }
}
