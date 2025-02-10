using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Ciudadano.Modelo
{
    public class CiudadanoNotificacionVacanteDeseada : EntidadBase
    {
        public int Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public List<CiudadanoCriteriosNotificaciones> Criterios { get; set; }
    }

    public class CiudadanoCriteriosNotificaciones : EntidadBase
    {
        public int Id { get; set; }
        public int CiudadanoNotificacionVacanteDeseadaId { get; set; }
        public CiudadanoNotificacionVacanteDeseada CiudadanoNotificacionVacanteDeseada { get; set; }
        public string Filtro { get; set; }
        public string ValorId { get; set; }
        public string Valor { get; set; }
    }
}