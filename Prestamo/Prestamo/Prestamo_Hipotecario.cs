using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo
{
    class Prestamo_Hipotecario : InterfazPrestamo
    {
        public Prestamo_Hipotecario()
        {


        }
        public Prestamo_Hipotecario(double Monto, String tipo)
        {

            this.MontoPrestamo = Monto;
            this.TipoPrestamo = tipo;
        }

        public double MontoPrestamo { get; set; }
        public String TipoPrestamo { get; set; }

        public Boolean ValidarPrestamo(){
            if (MontoPrestamo < 1000)
                return false;

            return true;
    }
        public double CalcularInteres()
        {
            double interes = MontoPrestamo * 0.12;
            return Convert.ToInt16(interes);
        }
    }
}
