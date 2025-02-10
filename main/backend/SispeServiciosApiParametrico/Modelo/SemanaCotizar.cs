using SispeServicios.DbContextBase.Modelo;
using System.ComponentModel.DataAnnotations;

namespace SispeServicios.Api.Parametrico.Modelo
{
    public class SemanaCotizar : EntidadBase
    {
        public int Id { get; set; }
        public int Semana { get; set; }
    }
}
