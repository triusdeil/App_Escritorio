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
        Operacion Obj_Operaciones = new Operacion();
        private void btn_Suma_Click(object sender, EventArgs e)
        {
            Obj_Operaciones.p_primer_numero = double.Parse(txtNumero1.Text);
            Obj_Operaciones.s_segundo_numero = double.Parse(txtNumero2.Text);
            Obj_Operaciones.Sumar();
            txtResultado.Text = Obj_Operaciones.resultado + "";
        }

        
        private void btn_Resta_Click(object sender, EventArgs e)
        {
            Obj_Operaciones.p_primer_numero = int.Parse(txtNumero1.Text);
            Obj_Operaciones.s_segundo_numero = int.Parse(txtNumero2.Text);
            Obj_Operaciones.Restar();
            txtResultado.Text = Obj_Operaciones.resultado + "";
        }
        

        private void btn_Multiplicacion_Click(object sender, EventArgs e)
        {
            int uno = int.Parse(txtNumero1.Text);
            int dos = int.Parse(txtNumero2.Text);
            Obj_Operaciones.Multiplicar(uno, dos);
            txtResultado.Text = Obj_Operaciones.resultado + "";
        }

        
        private void btn_Division_Click(object sender, EventArgs e)
        {
            Obj_Operaciones.Dividir(txtNumero1, txtNumero2);
            txtResultado.Text = Obj_Operaciones.resultado + "";
        }
    }
}
