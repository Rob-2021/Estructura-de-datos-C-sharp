using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionAlgebraica
{
    class Pila
    {
        public int maxpila = 50;
        public int tope;
        public char[] pila;

        public Pila()
        {
            tope = -1;
            pila = new char[maxpila];
        }

        public bool vacia()
        {
            if (tope == -1)
                return true;
            else
                return false;
        }

        private bool llena()
        {
            if (tope == maxpila - 1)
                return true;
            else
                return false;
        }

        public void insertar(char x)
        {
            if (llena())
                MessageBox.Show("La pila esta llena, no se puede insertar mas elementos");
            else
            {
                tope++;
                pila[tope] = x;
            }
        }
        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("La pila esta vacia, no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es: " + pila[tope]);
                tope--;
            }
        }
    }
}
