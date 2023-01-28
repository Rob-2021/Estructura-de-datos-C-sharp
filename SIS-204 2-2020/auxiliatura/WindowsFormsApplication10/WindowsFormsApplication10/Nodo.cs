using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication10
{
    class Nodo
    {
        public int numero;
        public Nodo izquierdo;
        public Nodo derecho;

        public Nodo() {
            izquierdo = null;
            derecho = null;
        }
    }
}
