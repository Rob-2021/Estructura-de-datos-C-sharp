using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleNodoCabeza
{
    class Nodo
    {
        private int Informacion;
        private Nodo EnlaseDerecho;
        private Nodo EnlaseIzquierdo;

        public int informacion
        {
            get { return Informacion; }
            set { Informacion = value; }
        }

        public Nodo Enlasederecho
        {
            get { return EnlaseDerecho; }
            set { EnlaseDerecho = value; }
        }

        public Nodo Enlaseizquierdo
        {
            get { return EnlaseIzquierdo; }
            set { EnlaseIzquierdo = value; }
        }
    }
}
