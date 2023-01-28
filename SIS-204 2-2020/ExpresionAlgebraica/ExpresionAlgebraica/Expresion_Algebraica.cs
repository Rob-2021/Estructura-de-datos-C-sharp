using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionAlgebraica
{
    class Expresion_Algebraica
    {
        public void evaluar_expresion(String expresion)
        {
            Pila pila = new Pila();
            int contAbre = 0;
            int contCierra = 0;

            for (int i = 0; i <= expresion.Length - 1; i++)
            {
                if (expresion.Substring(i, 1) == "(")
                {
                    pila.insertar(Convert.ToChar(expresion.Substring(i, 1)));
                    contAbre++;
                }
                else
                {
                    if (expresion.Substring(i, 1) == ")")
                    {
                        pila.eliminar();
                        contCierra++;
                    }
                }
            }

            if (pila.vacia() && contAbre == contCierra)
                MessageBox.Show("Expresion ingresada correcta");
            else
                MessageBox.Show("Expresion ingresada incorrecta");
        }
    }
}
