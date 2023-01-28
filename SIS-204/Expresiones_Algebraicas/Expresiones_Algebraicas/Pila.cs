using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expresiones_Algebraicas
{
    class Pila
    {
        public int maxpila = 50;
        public int tope;
        public char[] lista;

        public Pila()
        {
            tope = -1;
            lista = new char[maxpila];
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
                lista[tope] = x;
            }
        }
        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("La pila esta vacia, no se puede eliminar mas elementos");
            else
            {
                MessageBox.Show("Elemento eliminado es: " + lista[tope]);
                tope--;
            }
        }
    }
}
