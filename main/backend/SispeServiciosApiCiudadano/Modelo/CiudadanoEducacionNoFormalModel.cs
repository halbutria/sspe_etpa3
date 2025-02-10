using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoEducacionNoFormalModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int TipoCertificadoCapacitacionId { get; set; }
        public string NombrePrograma { get; set; }
        public string Institucion { get; set; }
        public int PaisId { get; set; }
        public int EstadoId { get; set; }
       
        public int? Duracion { get; set; }
        public int? IdCarga { get; set; }
        public DateTime? FechaCertificacion { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}
