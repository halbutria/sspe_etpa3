using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoIdiomaModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int IdiomaId { get; set; }
        public string NivelEscrito { get; set; }
        public string NivelHablado { get; set; }
        public string NivelEscucha { get; set; }
        public string NivelLectura { get; set; }
        public int? IdCarga { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}