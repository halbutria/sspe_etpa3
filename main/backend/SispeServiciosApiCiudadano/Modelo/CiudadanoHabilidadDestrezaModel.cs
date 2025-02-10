using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoHabilidadDestrezaModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public string? HabilidadId { get; set; }
        public string? Nombre { get; set; }
        public CiudadanoModel Ciudadano { get; set; }

    }
}