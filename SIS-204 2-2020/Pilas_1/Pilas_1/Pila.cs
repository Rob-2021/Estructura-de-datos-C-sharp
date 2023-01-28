using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_1
{
    class Pila
    {
        public int maxPila = 5;
        public int tope;
        public int[] pila;

        public Pila()
        {
            tope = -1;
            pila = new int[maxPila];
        }

        private bool Vacia()
        {
            if (tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Llena()
        {
            if (tope == maxPila - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar(int x)
        {
            if (Llena())
            {
                MessageBox.Show("La pila esta llena, no se puede insertar mas elementos");
            }
            else
            {
                tope++;
                pila[tope] = x;
            }
        }

        public void Eliminar()
        {
            if (Vacia())
            {
                MessageBox.Show("La pila esta vacia, no se puede eliminar mas elementos");
            }
            else
            {
                MessageBox.Show("Elemento eliminado es: " + pila[tope]);
                tope--;
            }
        }
    }
}
