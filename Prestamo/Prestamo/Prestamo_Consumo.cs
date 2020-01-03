using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamo
{
    class Prestamo_Consumo : InterfazPrestamo
    {
       public double interes;
  
        public Prestamo_Consumo()
        {

 
        }
        public Prestamo_Consumo(double Monto, String tipo){

        this.MontoPrestamo = Monto;
            this.TipoPrestamo= tipo;
        }

        public double MontoPrestamo { get; set; }
        public String TipoPrestamo  { get; set; }

        public Boolean ValidarPrestamo()
        {
            if (MontoPrestamo>1000)
            return false;

            return true;
        }
         public double CalcularInteres()
        {
             interes = MontoPrestamo * 0.09;
            return interes;
        }

    }
}
