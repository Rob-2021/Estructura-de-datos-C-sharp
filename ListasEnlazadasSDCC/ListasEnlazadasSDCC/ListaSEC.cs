using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasSDCC
{
    class ListaSEC
    {
        public NodoSimple lista;
        public NodoSimple ultimo;

        public bool vacia()
        {
            if (lista == null)
                return true;
            else
                return false;
        }

        public void insertar(int x)
        {
            NodoSimple p;
            if (vacia())
            {
                lista = new NodoSimple();
                lista.Info = x;
                lista.Enlace = lista;
                ultimo = lista;
            }
            else
            {
                p = new NodoSimple();
                p.Info = x;
                p.Enlace = ultimo.Enlace;
                ultimo.Enlace = p;
                ultimo = p;
            }
        }

        public void eliminar()
        {
            NodoSimple p;
            if (vacia())
                MessageBox.Show("No se puede eliminar mas elementos, porque la lista esta vacia");
            else
            {
                MessageBox.Show("Elemento eliminado: " + lista.Info);
                p = new NodoSimple();
                p = ultimo;
                if(ultimo == lista)
                {
                    ultimo.Enlace = null;
                    ultimo = null;
                }
                //else
                //{
                //    ultimo = ultimo.Enlace;
                //    lista.Enlace = ultimo;
                //    ultimo.Enlace = p.Enlace;
                //    MessageBox.Show("El elemento eliminado es : " + p.Info);
                //    p = null;
                //}
                else
                {
                    p = lista;
                    lista = lista.Enlace;
                    p.Enlace = null;
                    p = null;
                    ultimo.Enlace = lista;
                }
            }
        }
    }
}
