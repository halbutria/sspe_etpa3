using SispeServicios.Api.Ciudadano.Modelo;
using SispeServicios.DbContextBase.Modelo;

namespace SispeServicios.Api.Ciudadano.DTOs
{
    public class CiudadanoNotificacionVacanteDeseadaDto
    {
        public int Id { get; set; }
        public Guid CiudadanoId { get; set; }
        public List<CiudadanoCriteriosNotificacionesRespDto> Criterios { get; set; }
    }

    public class CiudadanoCriteriosNotificacionesRespDto : EntidadBase
    {
        public int Id { get; set; }
        public string Filtro { get; set; }
        public string ValorId { get; set; }
        public string Valor { get; set; }
    }

    public class CiudadanoCriteriosNotificacionesPostDto
    {
        public string Filtro { get; set; }
        public string ValorId { get; set; }
        public string Valor { get; set; }
    }
    public class CiudadanoCriteriosNotificacionesUpdateDto
    {
        public int Id { get; set; }
        public string Filtro { get; set; }
        public string ValorId { get; set; }
        public string Valor { get; set; }
    }

}
