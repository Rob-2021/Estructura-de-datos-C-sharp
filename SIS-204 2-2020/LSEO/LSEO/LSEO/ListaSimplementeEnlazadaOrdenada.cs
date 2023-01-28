using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSEO
{
    class ListaSimplementeEnlazadaOrdenada
    {
        public Nodo primero;
        private bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar_ordenado(int x)
        {
            Nodo p, q, r;
            if (vacia())
            {
                primero = new Nodo();
                primero.Info = x;
                primero.EnlaceIzquierdo = null;
                primero.EnlaceDerecho = null;
            }
            else
            {
                if (x < primero.Info)
                {
                    p = new Nodo();
                    p.Info = x;
                    p.EnlaceIzquierdo = null;
                    p.EnlaceDerecho = primero;
                    primero.EnlaceIzquierdo = p;
                    primero = p;
                }
                else
                {
                    r = primero;
                    q = primero.EnlaceDerecho;
                    while (q != null && x > q.Info)
                    {
                        r = q;
                        q = q.EnlaceDerecho;
                    }
                    if (q != null)
                    {
                        p = new Nodo();
                        p.Info = x;
                        r.EnlaceDerecho = p;
                        p.EnlaceIzquierdo = r;
                        p.EnlaceDerecho = q;
                        q.EnlaceIzquierdo = p;
                    }
                    else
                    {
                        p = new Nodo();
                        p.Info = x;
                        p.EnlaceDerecho = null;
                        p.EnlaceIzquierdo = r;
                        r.EnlaceDerecho = p;
                    }
                }
            }
        }
    }
}
