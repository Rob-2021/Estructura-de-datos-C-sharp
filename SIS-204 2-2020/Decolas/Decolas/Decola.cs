using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decolas
{
    class Decola
    {
        static int maxcola = 5;
        public int primero;
        public int ultimo;
        public int[] cola;

        public Decola()
        {
            primero = 0;
            ultimo = -1;
            cola = new int[maxcola];
        }

        public bool vacia()
        {
            if (ultimo < primero)
                return true;
            else
                return false;
        }

        public bool llena()
        {
            if (ultimo == maxcola - 1)
                return true;
            else
                return false;
        }

        public void insertarDelante(int x)
        {
            if (llena())
                MessageBox.Show("La cola esta llena");
            else
            {
                ultimo++;
                if (ultimo == 0)
                    cola[ultimo] = x;

                for (int i = ultimo - 1; i>-1; i--)
                {
                    cola[i + 1] = cola[i];
                    cola[i] = x;
                }
            }
        }

        public void eliminarAtras()
        {
            if (vacia())
                MessageBox.Show("La cola esta vacia");
            else
            {
                MessageBox.Show("Elemento eliminado es: " + cola[ultimo]);
                ultimo--;
            }
        }
    }
}
