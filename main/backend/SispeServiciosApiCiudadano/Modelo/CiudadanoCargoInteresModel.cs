using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoCargoInteresModel : EntidadBase
    {

        public Guid CiudadanoId { get; set; }
        public string? CargoInteresId { get; set; }
        public string? CargoIntertesAnteriorId { get; set; }
        public int? IdCarga { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}
