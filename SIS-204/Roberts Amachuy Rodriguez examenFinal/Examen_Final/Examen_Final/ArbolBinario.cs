using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Final
{
    class ArbolBinario
    {
        public Nodo raiz;
        public int topeRecorrido = 0;
        public int[] recorrido = new int[50];
        public void crearArbolLexicografico(int x)
        {
            Nodo p, q;
            Nodo aux = new Nodo();

            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.Info = x;
                raiz.EnlaceIzquierdo = null;
                raiz.EnlaceDerecho = null;
            }
            else
            {
                p = raiz;
                while (p != null)
                {
                    if (x < p.Info)
                    {
                        aux = p;
                        p = p.EnlaceIzquierdo;
                    }
                    else
                    {
                        if (x > p.Info)
                        {
                            aux = p;
                            p = p.EnlaceDerecho;
                        }
                    }
                }
                if (x < aux.Info)
                {
                    q = new Nodo();
                    q.Info = x;
                    q.EnlaceIzquierdo = null;
                    q.EnlaceDerecho = null;
                    aux.EnlaceIzquierdo = q;
                }
                else
                {
                    if (x > aux.Info)
                    {
                        q = new Nodo();
                        q.Info = x;
                        q.EnlaceIzquierdo = null;
                        q.EnlaceDerecho = null;
                        aux.EnlaceDerecho = q;
                    }
                }
            }
        }

        public void preOrden(Nodo raiz)
        {
            Nodo p;
            Nodo[] pila = new Nodo[30];
            int tope = 0;

            if (raiz != null)
            {
                p = raiz;
                while (p != null || tope > 0)
                {
                    while (p != null)
                    {
                       // MessageBox.Show(p.Info.ToString());
                        //
                        recorrido[topeRecorrido] = p.Info;
                        topeRecorrido++;
                        //
                        tope++;
                        pila[tope] = p;
                        p = p.EnlaceIzquierdo;
                    }
                    p = pila[tope].EnlaceDerecho;
                    tope--;
                }
            }
        }
    }
}
