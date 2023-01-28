using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSE_Pila
{
    class Nodo
    {
        private int info;
        private Nodo enlace;

        public int Info
        {
            get { return info; } //obtener el valor de info
            set { info = value; } //asignar un valor para info
        }

        public Nodo Enlace
        {
            get { return enlace; } //obtener el valor de enlace
            set { enlace = value; } //asignar un valor para enlace
        }
    }
}
