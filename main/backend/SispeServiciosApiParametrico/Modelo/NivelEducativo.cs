using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class NivelEducativo : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public int Orden { get; set; }
        public bool RegistraInstitucion { get; set; }
    }
}
