using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSO
{
    class Nodo
    {
        private int info;
        private Nodo enlaceDerecho;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public Nodo EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
    }
}
