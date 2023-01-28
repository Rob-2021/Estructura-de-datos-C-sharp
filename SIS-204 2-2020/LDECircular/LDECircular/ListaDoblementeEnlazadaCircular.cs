using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDECircular
{
    class ListaDoblementeEnlazadaCircular
    {
        public NodoDoble primero;
        public NodoDoble ultimo;

        private bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar(int x)
        {
            NodoDoble p;
            if (vacia())
            {
                primero = new NodoDoble();
                primero.Info = x;
                primero.EnlaceDerecho = primero;
                primero.EnlaceIzquierdo = primero;
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble();
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
            NodoDoble p;
            if (vacia())
            {
                MessageBox.Show("La lista esta vacia , no se puede eliminar");
            }
            else
            {
                p = new NodoDoble();
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
