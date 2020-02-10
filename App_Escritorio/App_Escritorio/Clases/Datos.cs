using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Escritorio
{
    class Datos
    {
       internal double primer_numero;
       internal double segundo_numero;
       internal double resultado;

        public double p_primer_numero
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
        public double p_resultado
        {
            get
            {
                return resultado;
            }
        }
       


    }
}
