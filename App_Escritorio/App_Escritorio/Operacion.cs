using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Escritorio
{
    class Operacion:Datos
    {
        public void Sumar()
        {
            resultado = primer_numero + segundo_numero;
        }
        public void Restar()
        {
            resultado = primer_numero - segundo_numero;
        }
        public void Multiplicar(int a, int b)
        {
            resultado = a * b;
        }
        public void Dividir(TextBox a, TextBox b)
        {
            int uno = int.Parse(a.Text);
            int dos = int.Parse(b.Text);
            resultado = uno /  dos;
        }
    }
}
