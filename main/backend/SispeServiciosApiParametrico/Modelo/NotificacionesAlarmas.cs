using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class NotificacionesAlarmas : EntidadBase
    {
        public int Id { get; set; }
        public int Grupo { get; set; }
        public string Nombre { get; set; }
        public int Tamanio { get; set; }
        [MaxLength(60)]
        public string? Descripcion { get; set; }
        public int EstadoNotificacion { get; set; }
    }
}
