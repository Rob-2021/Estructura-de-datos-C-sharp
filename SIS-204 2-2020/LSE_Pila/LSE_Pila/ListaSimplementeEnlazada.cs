using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSE_Pila
{
    class ListaSimplementeEnlazada
    {
        public Nodo tope = null;

        private bool vacia()
        {
            if (tope == null)
                return true;
            else
                return false;
        }

        public void insertarPila(int x)
        {
            Nodo p;
            if (vacia())
            {
                tope = new Nodo();
                tope.Info = x;
                tope.Enlace = null;
            }
            else
            {
                p = new Nodo();
                p.Info = x;
                p.Enlace = tope;
                tope = p;
            }
        }

        public void eliminarPila()
        {
            Nodo p;
            if (tope == null)
                MessageBox.Show("No se puede eliminar mas elementos, porque la pila esta vacia");
            else
            {
                MessageBox.Show("Elemento eliminado: " + tope.Info);
                p = tope;
                tope = tope.Enlace;
                p.Enlace = null;
            }
        }
    }
}
