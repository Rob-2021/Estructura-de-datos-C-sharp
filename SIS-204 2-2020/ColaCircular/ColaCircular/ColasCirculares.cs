using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaCircular
{
    class ColasCirculares
    {
        public int maxcola = 5;
        public int primero;
        public int ultimo;
        public String[] cola;
        
        public ColasCirculares()
        {
            primero = -1;
            ultimo = -1;
            cola = new String[maxcola];
        }

        private bool vacia()
        {
            if (primero == -1 && ultimo == -1)
                return true;
            else
                return false;
        }

        private bool llena()
        {
            if ((ultimo == maxcola - 1 && primero == 0) || (ultimo + 1 == primero))
                return true;
            else
                return false;
        }

        public void insertar(String x)
        {
            if (llena())
                MessageBox.Show("Error, la cola circular esta llena");
            else
            {
                if (ultimo == maxcola - 1)
                    ultimo = 0;
                else
                    ultimo++;
                cola[ultimo] = x;

                if (primero == -1)
                    primero++;
            }
        }

        public void eliminar()
        {
            if (vacia())
                MessageBox.Show("Error, la cola circular esta vacia no se puede eliminar elementos");
            else
            {
                MessageBox.Show("El elemento eliminado es: " + cola[primero]);
                cola[primero] = "";

                if(primero == ultimo)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                {
                    if (primero == maxcola - 1)
                        primero = 0;
                    else
                        primero++;
                }
            }
        }
    }
}
