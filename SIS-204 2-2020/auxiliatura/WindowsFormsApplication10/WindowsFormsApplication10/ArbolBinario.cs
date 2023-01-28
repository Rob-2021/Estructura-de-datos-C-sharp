using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication10
{
    class ArbolBinario
    {
        public Nodo raiz;
        public int altTotal = 0;

        public ArbolBinario() {
            raiz = null;
        }

        public bool vacio()
        {
            return raiz == null;
        }

        public void insertar(int num) {
            Nodo nuevo = new Nodo();
            nuevo.numero = num;
            nuevo.derecho = null;
            nuevo.izquierdo = null;
            Nodo q = nuevo;
            Nodo r = raiz;
            if (vacio())
            {
                raiz = nuevo;
            }
            else
            {
                while (r != null) {
                    q = r;
                    if (num > r.numero)
                        r = r.derecho;
                    else
                        r = r.izquierdo;
                }
                if (num > q.numero)
                    q.derecho = nuevo;
                else
                    q.izquierdo = nuevo;

            }
        }

        public void preOrden(Nodo puntRaiz) {
            string cadena;
            if (puntRaiz == null)
            {
                return ;
            }
            else
            {
                Console.WriteLine(puntRaiz.numero);
                preOrden(puntRaiz.izquierdo);
                preOrden(puntRaiz.derecho);
            }
        }

        public int altura(Nodo puntRaiz, int alt) {
            if (puntRaiz == null)
                return 0;
            else {
                alt = Math.Max(altura(puntRaiz.derecho,alt),altura(puntRaiz.izquierdo,alt))+1;
                return alt;
            }
        }

        public Nodo getSiguiente(Nodo nodo) {
            Nodo siguiente = new Nodo();
            if (siguiente.izquierdo != null)
            {
                siguiente = siguiente.izquierdo;
            }
            else
            {
                siguiente = siguiente.derecho;
            }
            return siguiente;
        }

        public bool esHoja(Nodo pNodo) {
            if (pNodo.derecho == null && pNodo.izquierdo == null)
                return true;
            else
                return false;
        }
        
        public  Nodo bNodo, bNodoAnterior = new Nodo();
        public int buscar(Nodo pNodo, int buscado) {
            int encontrado=0;
            
            if (pNodo==null)
                encontrado=0;
            else {
                if (pNodo.numero == buscado)
                    encontrado = 1;

                else {
                    if (pNodo.numero > buscado)
                    {
                        bNodoAnterior = pNodo;
                        pNodo = pNodo.izquierdo;
                        bNodo = pNodo;
                        buscar(pNodo, buscado);
                        
                    }
                    else {
                        bNodoAnterior = pNodo;
                            pNodo = pNodo.derecho;
                            bNodo = pNodo;
                            buscar(pNodo, buscado);
                            
                        
                    }
                }
            }
            return encontrado;
        }

        public int eliminar(int num) {
            int eliminado=0;
            buscar(raiz,num);
            if (esHoja(bNodo))
            {
                eliminado = bNodo.numero;
                
                if (bNodo.numero > bNodoAnterior.numero)
                {
                    bNodoAnterior.derecho = null;
                }
                else {
                    bNodoAnterior.izquierdo = null;
                }
                
            }
            else { 

            }
            return eliminado;
        }
    }
}
