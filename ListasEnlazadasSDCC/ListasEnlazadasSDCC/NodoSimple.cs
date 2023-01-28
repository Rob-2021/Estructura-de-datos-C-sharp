using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadasSDCC
{
    class NodoSimple
    {
        private int info;
        private NodoSimple enlace;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public NodoSimple Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
