using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class Direccionamiento : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PasosRutaEmpleabilidadId { get; set; }
        public PasosRutaEmpleabilidad PasosRutaEmpleabilidad { get; set; }
    }
}
