using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class Nodo
    {
        private char info;
        private Nodo enlace;

        public char Info
        {
            get { return info; }
            set { info = value; }
        }

        public Nodo Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
