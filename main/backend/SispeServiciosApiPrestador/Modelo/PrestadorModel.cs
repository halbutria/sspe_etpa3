using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Prestador.Modelo
{
    [Table("Prestador")]
    public class PrestadorModel : EntidadBase
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string DepartamentoId { get; set; }
        public string MunicipioId { get; set; }
        public bool CoberturaNacional { get; set; }
        public int? IdCarga { get; set; }
        //public Municipio Municipio { get; set; }
    }
}

