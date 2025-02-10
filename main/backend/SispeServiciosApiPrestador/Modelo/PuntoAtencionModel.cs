using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Prestador.Modelo
{
    [Table("PuntoAtencion")]
    public class PuntoAtencionModel : EntidadBase {
        public Guid PrestadorId { get; set; }
        public string DepartamentoId { get; set; }
        public string MunicipioId { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public int? IdCarga { get; set; }
        public PrestadorModel Prestador { get; set; }
    }
}
