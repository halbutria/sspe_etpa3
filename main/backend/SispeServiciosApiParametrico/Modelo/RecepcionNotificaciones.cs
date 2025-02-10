using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class RecepcionNotificaciones : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Notificaciones> Notificaciones { get; set; } = new List<Notificaciones>();
        [MaxLength(60)]
        public string? Descripcion { get; set; }
    }
}
