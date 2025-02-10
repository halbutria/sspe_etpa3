using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SispeServicios.DbContextBase.Modelo
{
    public class EntidadBase
    {
        [Column(Order = 0)]
        public Guid Id { get; set; }
        public string? UsuarioCreacion { get; set; }
        public DateTimeOffset? FechaCreacion { get; set; }
        public string? UsuarioModificacion { get; set; }
        public DateTimeOffset? FechaModificacion { get; set; }
        public bool Eliminado { get; set; }
    }
}
