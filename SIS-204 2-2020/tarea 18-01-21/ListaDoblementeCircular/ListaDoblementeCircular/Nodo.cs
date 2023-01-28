using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeCircular
{
    class Nodo
    {
        private int informacion;
        private Nodo EnlaseDerecho;
        private Nodo EnlaseIzquierdo;

        public int Informacion
        {
            get { return informacion; }
            set { informacion = value; }
        }

        public Nodo enlasederecho
        {
            get { return EnlaseDerecho; }
            set { EnlaseDerecho = value; }
        }

        public Nodo enlaseizquierdo
        {
            get { return EnlaseIzquierdo; }
            set { EnlaseIzquierdo = value; }
        }
    }
}
