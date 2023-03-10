using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSECircular
{
    class ListaSimplementeEnlazadaCircular
    {
        public Nodo lista;
        public Nodo ultimo;

        public bool vacia()
        {
            if (lista == null)
                return true;
            else
                return false;
        }

        public void insertar1(int x)
        {
            Nodo p;
            if (vacia())
            {
                lista = new Nodo();
                lista.Info = x;
                lista.Enlace = lista;
                ultimo = lista;
            }
            else
            {
                p = new Nodo();
                p.Info = x;
                p.Enlace = ultimo.Enlace;
                ultimo.Enlace = p;
                ultimo = p;
            }
        }

        public void insertar2(int x)
        {
            Nodo p, q;
            if (vacia())
            {
                lista = new Nodo();
                lista.Info = x;
                lista.Enlace = lista;
            }
            else
            {
                q = lista;
                while (q.Enlace != lista)
                    q = q.Enlace;
                p = new Nodo();
                p.Info = x;
                p.Enlace = q.Enlace;
                q.Enlace = p;
            }
        }

        public void eliminar()
        {
            Nodo p;
            if (lista == null)
                MessageBox.Show("No se puede eliminar mas elementos, porque la lista esta vacia");
            else
            {
                MessageBox.Show("Elemento eliminado: " + lista.Info);
                p = lista;
                lista = lista.Enlace;
                p.Enlace = null;
                p = null;
                ultimo.Enlace = lista;
                //if(p == ultimo)
                //{
                //    //ultimo.Enlace = null;
                //    //ultimo = null;
                //    lista.Enlace = null;
                //    lista = null;
                //}
            }
        }
    }
}
