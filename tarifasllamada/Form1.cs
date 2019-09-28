using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarifasllamada
{
    public partial class Form1 : Form
    {
        Tarifas tarifas = new Tarifas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(cbdestino.SelectedIndex.ToString());
            tarifas.setTiempo(double.Parse(txtduracion.Text));
            
            switch (cbdestino.SelectedIndex.ToString())
            {
                case "0":

                    lbltotal.Text ="Total:"+tarifas.calcularPrecioEEUU().ToString();
                    lbltotal.Visible = true;
                    break;

                case "1":

                    lbltotal.Text = "Total:" + tarifas.calcularPrecioCA().ToString();
                    lbltotal.Visible = true;
                    break;

                case "2":

                    lbltotal.Text = "Total:" + tarifas.calcularPrecioEU().ToString();
                    lbltotal.Visible = true;
                    break;

                case "3":

                    lbltotal.Text = "Total:" + tarifas.calcularPrecioRM().ToString();
                    lbltotal.Visible = true;
                    break;

                default:
                    MessageBox.Show("Elija una opción valida.");
                    break;
            }
        }
    }
}
