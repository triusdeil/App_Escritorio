using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Escritorio;
namespace App_Escritorio
{
    public partial class Frm_Hotel : Form
    {
        public Frm_Hotel()
        {
            InitializeComponent();
        }
        Operacion Operacion_Suma = new Operacion();
        private void btn_Suma_Click(object sender, EventArgs e)
        {
            Operacion_Suma.p_primer_numero = int.Parse(txtNumero1.Text);
            Operacion_Suma.s_segundo_numero = int.Parse(txtNumero2.Text);
            Operacion_Suma.Sumar();
            txtResultado.Text = Operacion_Suma.resultado + "";
        }

        Operacion Operacion_Resta = new Operacion();
        private void btn_Resta_Click(object sender, EventArgs e)
        {
            Operacion_Resta.p_primer_numero = int.Parse(txtNumero1.Text);
            Operacion_Resta.s_segundo_numero = int.Parse(txtNumero2.Text);
            Operacion_Resta.Restar();
            txtResultado.Text = Operacion_Resta.resultado + "";
        }
        Operacion Operacion_Multiplicacion = new Operacion();

        private void btn_Multiplicacion_Click(object sender, EventArgs e)
        {
            Operacion_Multiplicacion.p_primer_numero = int.Parse(txtNumero1.Text);
            Operacion_Multiplicacion.s_segundo_numero = int.Parse(txtNumero2.Text);
            Operacion_Multiplicacion.Multiplicar();
            txtResultado.Text = Operacion_Multiplicacion.resultado + "";
        }

        Operacion Operacion_Dividir = new Operacion();
        private void btn_Division_Click(object sender, EventArgs e)
        {
            Operacion_Dividir.p_primer_numero = int.Parse(txtNumero1.Text);
            Operacion_Dividir.s_segundo_numero = int.Parse(txtNumero2.Text);
            Operacion_Dividir.Dividir();
            txtResultado.Text = Operacion_Dividir.resultado + "";
        }
    }
}
