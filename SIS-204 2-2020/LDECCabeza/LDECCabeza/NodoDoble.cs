using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDECCabeza
{
    class NodoDoble
    {
        private int info;
        private NodoDoble enlaceDerecho;
        private NodoDoble enlaceIzquierdo;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public NodoDoble EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }

        public NodoDoble EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
    }
}
