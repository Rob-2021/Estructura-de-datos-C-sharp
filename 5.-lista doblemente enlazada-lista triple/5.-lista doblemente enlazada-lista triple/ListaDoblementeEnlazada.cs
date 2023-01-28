using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._lista_doblemente_enlazada_lista_triple
{
    class ListaDoblementeEnlazada
    {
        public Nodo primero;
        public Nodo ultimo;

        private bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar_ordenado(int x)
        {
            Nodo p;
            if (vacia())
            {
                primero = new Nodo();
                primero.Info = x;
                primero.EnlaceDerecho = null;
                primero.EnlaceIzquierdo = null;
                ultimo = primero;

            }
            else
            {
                p = new Nodo();
                p.Info = x;
                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = ultimo;
                ultimo.EnlaceDerecho = p;
                ultimo = p;
            }
        }
    }
}
