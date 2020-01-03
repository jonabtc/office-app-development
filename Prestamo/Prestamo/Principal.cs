using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try{
            if (comboBox1.SelectedIndex == 0) //prestamos consumo
            {
                
                double a=Convert.ToDouble(txtMonto.Text);
                Prestamo_Consumo prcon = new Prestamo_Consumo(a,"Prestamo Consumo");
                if (prcon.ValidarPrestamo()==true){
                    this.info.Text = "El prestamo si es posible con interes= "+prcon.CalcularInteres();
                }
                if (prcon.ValidarPrestamo() == false)
                {
                    this.info.Text = "No es posible el préstamo";
                }
               
            }
            if (comboBox1.SelectedIndex == 1) //prestamos hipotecario
            {

                double a = Convert.ToDouble(txtMonto.Text);
                Prestamo_Hipotecario prhip = new Prestamo_Hipotecario(a, "Prestamo Hipotecario");
                if (prhip.ValidarPrestamo() == true)
                {
                    this.info.Text = "El prestamo si es posible con interes= " + prhip.CalcularInteres();
                }
                if (prhip.ValidarPrestamo() == false)
                {
                    this.info.Text = "No es posible el préstamo";
                }

            }
                //Tuve un error aqui, adjunto en un bloc de notas la clase descuento qeu hereda prestamo consumo

           /* if (comboBox1.SelectedIndex == 2) //prestamos consumo con descuento 
            {
              

                double a = Convert.ToDouble(txtMonto.Text);
                int b = Convert.ToInt16(textBox1.Text);
                Consumo_Descuento con = new Consumo_Descuento(a, "Consumo con descuento",b);
                if (con.ValidarPrestamo() == true)
                {
                    this.info.Text = "El prestamo si es posible con interes= " + con.CalcularInteres();
                }
                if (con.ValidarPrestamo() == false)
                {
                    this.info.Text = "No es posible el préstamo";
                }

            }*/
            }
            catch (FormatException) { this.info.Text = "Dato mal ingresado"; }
        }
    }
}
