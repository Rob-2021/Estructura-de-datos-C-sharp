using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    class Cola
    {
        static int maxcola = 7;
        public int primero;
        public int ultimo;
        public int[] cola;

        public Cola()
        {
            primero = 0;
            ultimo = -1;
            cola = new int[maxcola];
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

        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("Error, la cola esta vacia, no se pueden eliminar mas elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es: " + cola[primero]);
                for(int i = 0; i <= ultimo-1; i++)
                {
                    cola[i] = cola[i + 1];
                }
                ultimo--;
            }
        }
    }
}
