using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSO
{
    class ListaSimplementeOrdenada
    {
        public Nodo inicio = null;
        public Nodo fin = null;
        
       

        public bool vacia()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }

        public void insertar_ordenado(int x)
        {
            Nodo p,q,r;
            if (vacia())
            {
                inicio = new Nodo();
                inicio.Info = x;
                inicio.EnlaceDerecho = null;

            }
            else
            {
                if(x < inicio.Info)
                {
                    p = new Nodo();
                    p.Info = x;
                    p.EnlaceDerecho = inicio;
                    p = inicio;
                }
                else
                {
                   r = inicio;
                    q = inicio.EnlaceDerecho;
                    while(q != null && x> q.Info)
                    {
                        r = q;
                        q = q.EnlaceDerecho;
                    }
                    if(q != null)
                    {
                        p = new Nodo();
                        p.Info = x;
                        r.EnlaceDerecho = p;
                        p.EnlaceDerecho = q;
                        
                    }
                    else
                    {
                       p = new Nodo();
                        p.Info = x;
                        p.EnlaceDerecho = null;
                        r.EnlaceDerecho = p;
                       
                       
                    }
                }
            }
        }

        public void contar_pares()
        {
            Nodo p;
            int contador_pares = 0;
            for (p = inicio; p != null; p = p.EnlaceDerecho)
            {
                if (p.Info %2 == 0)
                {
                    contador_pares = contador_pares + 1;
                }
            }
            MessageBox.Show("la cantidad de numeros pares es: "+ contador_pares);
        }

        public void contar_impares()
        {
            Nodo p;
            int contador_impares = 0;
            for(p = inicio; p !=null;p= p.EnlaceDerecho)
            {
                if (p.Info % 2 == 1)
                {
                    contador_impares = contador_impares + 1;
                }
            }
            MessageBox.Show("la cantidad de numeros impares es: " + contador_impares);
        }
    }
}
