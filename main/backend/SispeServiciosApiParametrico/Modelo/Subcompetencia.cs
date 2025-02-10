using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Subcompetencia : EntidadBase
    {
        public int Id { get; set; }
        public string CompetenciaDuraId { get; set; }
        public string Nombre { get; set; }
        public string Sigla { get; set; }
        public CompetenciasDuras CompetenciasDuras { get; set; }
    }
}
