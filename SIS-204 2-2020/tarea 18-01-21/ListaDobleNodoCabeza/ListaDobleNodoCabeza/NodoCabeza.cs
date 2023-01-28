using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleNodoCabeza
{
    class NodoCabeza
    {
        private int Informacion;
        private Nodo Enlase;

        public int informacion
        {
            get { return Informacion; }
            set { Informacion = value; }
        }

        public Nodo enlase
        {
           get { return Enlase; }
           set { Enlase = value; }
        }
    }
}
