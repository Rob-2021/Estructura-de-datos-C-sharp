using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Grafo
    {
        public Vertice grafo;
        Vertice vertice;

        public void insertarVertice(int x)
        {
            Vertice p;
            if(grafo == null)
            {
                grafo = new Vertice();
                grafo.Info = x;
                grafo.EnlaceIzquierdo = null;
                grafo.EnlaceDerecho = null;
                grafo.EnlaceArco = null;
                vertice = grafo;
            }
            else
            {
                p = new Vertice();
                p.Info = x;
                p.EnlaceIzquierdo = vertice;
                p.EnlaceDerecho = null;
                p.EnlaceArco = null;
                vertice.EnlaceDerecho = p;
                vertice = p;
            }
        }

        public Vertice buscarVertice(int x)
        {
            Vertice p;
            p = grafo;
            while (p != null || p.Info != x)
                p = p.EnlaceDerecho;
            return p;
        }

        public void insertarArco(int x, int y)
        {
            Vertice p, q;
            Arco r, s;
            p = buscarVertice(x);
            q = buscarVertice(y);

            if(p.EnlaceArco == null)
            {
                r = new Arco();
                r.EnlaceVertice = q;
                r.EnlaceArco = null;
                p.EnlaceArco = r;
            }
            else
            {
                s = p.EnlaceArco;
                while (s.EnlaceArco != null)
                    s = s.EnlaceArco;
                r = new Arco();
                r.EnlaceVertice = q;
                r.EnlaceArco = null;
                s.EnlaceArco = r;
            }
        }


    }
}
