using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas
{
    class ListaSimplementeEnlazada
    {
        public Nodo tope = null;

        public void InsertarPila(int x)
        {
            Nodo p;
            if (tope == null)
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

        public void EliminarPila()
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
