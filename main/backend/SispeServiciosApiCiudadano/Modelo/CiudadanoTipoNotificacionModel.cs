using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoTipoNotificacionModel : EntidadBase
    {
        public Guid CiudadanoId { get; set; }
        public int tipoNotificacionId { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}
