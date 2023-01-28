using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class ListaSimple
    {
        public NodoCabeza cabeza;
        public Nodo lista;
        public Nodo ultimo;

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

        public void insertar1(char x)
        {
            Nodo p;
            if (vacia())
            {
                crearCabeza();
                lista = new Nodo();
                lista.Info = x;
                lista.Enlace = lista;
                ultimo = lista;
                cabeza.Info++;
                cabeza.Enlace = lista;
            }
            else
            {
                p = new Nodo();
                p.Info = x;
                p.Enlace = ultimo.Enlace;
                ultimo.Enlace = p;
                ultimo = p;
                cabeza.Info++;
            }
        }
    }
}
