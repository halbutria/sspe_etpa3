using SispeServicios.Api.Ciudadano.Migrations;
using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoRedesSocialesModel : EntidadBase  
    {
        public Guid CiudadanoId { get; set; }
        public int RedSocialId { get; set; }
        public string NombreRedSocial { get; set; }
        public string NombreUsuarioRedSocial { get; set; }
        public bool Activo { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}
