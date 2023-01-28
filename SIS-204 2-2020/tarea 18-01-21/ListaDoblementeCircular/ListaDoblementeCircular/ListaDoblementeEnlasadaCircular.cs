using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDoblementeCircular
{
    class ListaDoblementeEnlasadaCircular
    {
        public Nodo primero = null;
        public Nodo ultimo = null;

        public bool Vacio()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void Insertar(int x)
        {
            Nodo p;
            if (Vacio())
            {
                primero = new Nodo();
                primero.Informacion = x;
                primero.enlasederecho = primero;
                primero.enlaseizquierdo = primero;
                ultimo = primero;
            }
            else
            {
                p = new Nodo();
                p.Informacion = x;
                p.enlasederecho = ultimo.enlasederecho;
                ultimo.enlasederecho = p;
                p.enlaseizquierdo = ultimo;
                primero.enlaseizquierdo = p;
                ultimo = p;
            }
        }

        public void Eliminar()
        {
            Nodo p;
            if (Vacio())
            {
                MessageBox.Show("La lista esta vacia , no se puede eliminar");
            }
            else
            {
                p = new Nodo();
                p = ultimo;
                if(ultimo == primero)
                {
                    ultimo.enlasederecho = null;
                    ultimo.enlaseizquierdo = null;
                    ultimo = null;
                }
                else
                {
                    ultimo = ultimo.enlaseizquierdo;
                    primero.enlaseizquierdo = ultimo;
                    ultimo.enlasederecho = p.enlasederecho;
                    MessageBox.Show("El elemento eliminado es : " + p.Informacion);
                    p = null;
                }
             
            }
        }
    }
}
