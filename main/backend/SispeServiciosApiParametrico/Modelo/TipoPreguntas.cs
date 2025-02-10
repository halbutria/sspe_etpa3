using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class TipoPreguntas : EntidadBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
