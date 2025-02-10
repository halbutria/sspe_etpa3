using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SispeServicios.Control.Exepcion.Exceptions
{
    public class NotImplementedException : Exception
    {
        public NotImplementedException(string message) : base(message)
        { }
    }
}
