using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoConocimientoCompetenciaModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public string? ConocimientoId { get; set; }
        public string? Nombre { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
        
    }
}