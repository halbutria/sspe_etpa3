using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Comuna : EntidadBase
    {
        public int Id { get; set; }
        public string MunicipioId { get; set; }
        public string Nombre { get; set; }
        public Municipio Municipio { get; set; }
    }
}
