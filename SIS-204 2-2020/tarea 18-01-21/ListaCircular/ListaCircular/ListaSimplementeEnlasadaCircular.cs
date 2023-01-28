using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCircular
{
    class ListaSimplementeEnlasadaCircular
    {
        public Nodo primero = null;
        public Nodo ultimo = null;
        

        public bool vacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar(int x)
        {
            Nodo p;
            if (vacia())
            {
                primero = new Nodo();
                primero.Info = x;
                primero.Enlace = primero;
                ultimo = primero;
            }

            else
            {
                p = new Nodo();
                p.Info = x;
                p.Enlace = ultimo.Enlace;
                ultimo.Enlace = p;
                ultimo = p;

            }
        }

        public void eliminar()
        {
            Nodo p;
            if (vacia())
            {
                MessageBox.Show("La lista esta vacia,no se puede eliminar");
            }
            else
            {
                p = new Nodo();
                p = primero;
                MessageBox.Show("El elemento eliminado es : " + p.Info);
                primero = primero.Enlace;
                p.Enlace = null;
                p = null;
                ultimo.Enlace = primero;
                
                //while(p.Enlace == p)
                //{
                //    ultimo = primero;
                //    ultimo.Enlace = null;
                //    ultimo = null;
                //}
            }
        }
    }
}
