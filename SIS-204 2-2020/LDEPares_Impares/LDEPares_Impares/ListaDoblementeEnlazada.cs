using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDEPares_Impares
{
    class ListaDoblementeEnlazada
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

        public void eliminar(int x)
        {
            Nodo p, q, r;
            if (vacia())
                MessageBox.Show("La lista esta vacía, no se puede eliminar el elemento");
            else
            {
                p = primero;
                while (p != null && p.Info != x)
                    p = p.EnlaceDerecho;

                if (p == null)
                    MessageBox.Show("El elemento no existe en la lista");
                else
                {
                    if (p == primero)
                    {
                        MessageBox.Show("El elemento encontrado es: " + p.Info);
                        if (primero.EnlaceDerecho != null)
                        {
                            primero = primero.EnlaceDerecho;
                            primero.EnlaceIzquierdo = null;
                        }
                        else
                        {
                            primero = null;
                        }
                        p.EnlaceDerecho = null;
                        p.EnlaceIzquierdo = null;
                        p = null;
                    }
                    else
                    {
                        MessageBox.Show("El elemento encontrado es: " + p.Info);
                        q = p.EnlaceDerecho;
                        r = p.EnlaceIzquierdo;
                        if (q != null)
                        {
                            q.EnlaceIzquierdo = r;
                            r.EnlaceDerecho = q;
                        }
                        else
                        {
                            r.EnlaceDerecho = null;
                        }
                        p.EnlaceDerecho = null;
                        p.EnlaceIzquierdo = null;
                        p = null;
                    }
                }
            }
        }

        public void insertar_ordenado(int x)
        {
            Nodo p, r, q;
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
