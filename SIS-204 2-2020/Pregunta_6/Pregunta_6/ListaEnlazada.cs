using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_6
{
    class ListaEnlazada
    {
        public NodoDoble primero;
        public NodoDoble ultimo;

        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar_ordenado(int x)
        {
            NodoDoble p, r, q;
            if (vacia())
            {
                primero = new NodoDoble();
                primero.Info = x;
                primero.EnlaceIzquierdo = null;
                primero.EnlaceDerecho = null;
                ultimo = primero;
            }
            else
            {
                if (x < primero.Info)
                {
                    p = new NodoDoble();
                    p.Info = x;
                    p.EnlaceIzquierdo = null;
                    p.EnlaceDerecho = primero;
                    primero.EnlaceIzquierdo = p;
                    primero = p;
                    ultimo = primero;
                }
                else
                {
                    r = primero;
                    q = primero.EnlaceDerecho;
                    while (q != null && x > q.Info)
                    {
                        r = q;
                        q = q.EnlaceDerecho;
                        ultimo = primero;
                    }
                    if (q != null)
                    {
                        p = new NodoDoble();
                        p.Info = x;
                        r.EnlaceDerecho = p;
                        p.EnlaceIzquierdo = r;
                        p.EnlaceDerecho = q;
                        q.EnlaceIzquierdo = p;
                        ultimo = primero;
                    }
                    else
                    {
                        p = new NodoDoble();
                        p.Info = x;
                        p.EnlaceDerecho = null;
                        p.EnlaceIzquierdo = r;
                        r.EnlaceDerecho = p;
                        ultimo = primero;
                    }
                }
            }
        }
    }
}
