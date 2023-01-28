using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta_6_ColaYPila
{
    class Cola
    {
        static int maxcola = 7;
        public int primero;
        public int ultimo;
        public int[] cola;


        public int maxPila = 7;
        public int tope;
        public int[] pila;


        public Cola()
        {
            primero = 0;
            ultimo = -1;
            cola = new int[maxcola];

            tope = -1;
            pila = new int[maxPila];
        }

        private bool vacia()
        {
            if (ultimo < primero)
                return true;
            else
                return false;
        }

        private bool llena()
        {
            if (ultimo == maxcola - 1)
                return true;
            else
                return false;
        }

        public void insertar(int x)
        {
            if (llena())
                MessageBox.Show("Error, la cola esta llena, no se pueden ingresar mas elementos");
            else
            {
                ultimo++;
                cola[ultimo] = x;
            }
        }

        public void eliminarAtras()
        {
            if (vacia())
                MessageBox.Show("La cola esta vacia");
            else
            {
                tope++;
                pila[tope] = cola[ultimo];
                MessageBox.Show("Elemento eliminado es: " + cola[ultimo]);
                ultimo--;
            }
        }
    }
}
