using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class EducacionNoFormalDTO
    {
        public Guid Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public int? TipoCertificadoCapacitacionId { get; set; }
        public string? NombrePrograma { get; set; }
        public string? Institucion { get; set; }
        public int? PaisId { get; set; }
        public int? EstadoId { get; set; }
        public int? Duracion { get; set; }
        public DateTime? FechaCertificacion { get; set; }
        public string? TipoCertificacionCapacitacion { get; set; }
        public string? Pais { get; set; }
    }
}
