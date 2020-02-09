using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Escritorio
{
    class Datos
    {
       internal int primer_numero;
       internal int segundo_numero;
       internal int resultado;

        public int p_primer_numero
        {
            set
            {
                primer_numero = value;
            }
        }
        public int s_segundo_numero
        {
            set
            {
                segundo_numero = value;
            }
        }
        public int p_resultado
        {
            get
            {
                return resultado;
            }
        }
        public void Suma()
        {
            resultado = primer_numero + segundo_numero; 
        }


    }
}
