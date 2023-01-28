using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercambio
{
    class IntercambioPilas
    {
        public void intercambiar(Pila P1, Pila P2)
        {
            int cantidadIteraciones;
            int aux;
            int auxTope;

            P1.invertir();
            P2.invertir();

            if (P1.tope > P2.tope)
                cantidadIteraciones = P1.tope;
            else
                cantidadIteraciones = P2.tope;

            for(int i = 0; i <= cantidadIteraciones; i++)
            {
                aux = P1.pila[i];
                P1.pila[i] = P2.pila[i];
                P2.pila[i] = aux;
            }

            auxTope = P1.tope;
            P1.tope = P2.tope;
            P2.tope = auxTope;
        }
    }
}
