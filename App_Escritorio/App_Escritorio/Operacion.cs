using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Multiplicar()
        {
            resultado = primer_numero * segundo_numero;
        }
        public void Dividir()
        {
            resultado = primer_numero /  segundo_numero;
        }
    }
}
