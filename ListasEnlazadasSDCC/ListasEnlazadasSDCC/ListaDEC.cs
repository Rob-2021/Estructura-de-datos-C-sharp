using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasSDCC
{
    class ListaDEC
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

        public void insertar(int x)
        {
            Nodo p;
            if (vacia())
            {
                primero = new Nodo();
                primero.Info = x;
                primero.EnlaceDerecho = primero;
                primero.EnlaceIzquierdo = primero;
                ultimo = primero;
            }
            else
            {
                p = new Nodo();
                p.Info = x;
                p.EnlaceDerecho = ultimo.EnlaceDerecho;
                ultimo.EnlaceDerecho = p;
                p.EnlaceIzquierdo = ultimo;
                primero.EnlaceIzquierdo = p;
                ultimo = p;
            }
        }

        public void eliminar()
        {
            Nodo p;
            if (vacia())
            {
                MessageBox.Show("La lista esta vacia , no se puede eliminar");
            }
            else
            {
                p = new Nodo();
                p = ultimo;
                if (ultimo == primero)
                {
                    ultimo.EnlaceDerecho = null;
                    ultimo.EnlaceIzquierdo = null;
                    ultimo = null;
                }
                else
                {
                    ultimo = ultimo.EnlaceIzquierdo;
                    primero.EnlaceIzquierdo = ultimo;
                    ultimo.EnlaceDerecho = p.EnlaceDerecho;
                    MessageBox.Show("El elemento eliminado es : " + p.Info);
                    p = null;
                }

            }
        }
    }
}
