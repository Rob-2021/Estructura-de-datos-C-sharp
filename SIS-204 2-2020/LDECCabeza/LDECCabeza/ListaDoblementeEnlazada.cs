using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDECCabeza
{
    class ListaDoblementeEnlazada
    {
        public NodoCabeza cabeza;
        public NodoDoble primero;
        public NodoDoble ultimo;

        public bool vacia()
        {
            if (cabeza == null)
                return true;
            else
                return false;
        }

        private void crearCabeza()
        {
            cabeza = new NodoCabeza();
            cabeza.Enlace = null;
            cabeza.Info = 0;
        }

        public void insertar(int x)
        {
            NodoDoble p;
            if (vacia())
            {
                crearCabeza();
                primero = new NodoDoble();
                primero.Info = x;
                primero.EnlaceDerecho = null;
                primero.EnlaceIzquierdo = null;
                cabeza.Enlace = primero;
                ultimo = primero;

            }
            else
            {
                p = new NodoDoble();
                p.Info = x;
                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = ultimo;
                ultimo.EnlaceDerecho = p;
                ultimo = p;

            }
        }

        public void eliminar()
        {
            NodoDoble p;
            if (vacia())
            {
                MessageBox.Show("La lista esta vacia, no se puede eliminar mas elementos");
            }

            else
            {
                p = new NodoDoble();
                p = ultimo;
                ultimo = ultimo.EnlaceIzquierdo;
                MessageBox.Show("El elemento eliminado es " + p.Info);
                p.EnlaceDerecho = null;
                p = null;
                cabeza.Info--;

            }
        }

    }
}
