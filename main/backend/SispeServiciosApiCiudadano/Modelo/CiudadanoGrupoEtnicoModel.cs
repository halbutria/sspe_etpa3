using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoGrupoEtnicoModel:EntidadBase
    {
        public int GrupoEtnicoId { get; set; }
        public Guid CiudadanoId { get; set; }
        public int? IdCarga { get; set; }
        public CiudadanoModel Ciudadano { get; set; }
    }
}
