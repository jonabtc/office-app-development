using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo
{
    interface InterfazPrestamo
    {
        
        double MontoPrestamo { get; set; }
        String TipoPrestamo { get; set; }

        Boolean ValidarPrestamo();
        double CalcularInteres();
    }
}
