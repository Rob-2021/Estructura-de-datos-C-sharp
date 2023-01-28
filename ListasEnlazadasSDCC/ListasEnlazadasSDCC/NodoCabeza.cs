using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasSDCC
{
    class NodoCabeza
    {
        private int info;
        private Nodo enlace;

        public int Info
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
