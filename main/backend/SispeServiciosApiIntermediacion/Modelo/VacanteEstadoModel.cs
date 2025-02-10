using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Intermediacion.Modelo
{
    public class VacanteEstadoModel:EntidadBase
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String? Sigla { get; set; }
        public List<VacanteModel> Vacantes { get; set; }
        public List<VacanteCambioEstadoModel> VacantesCambioEstados { get; set; }

    }
}
