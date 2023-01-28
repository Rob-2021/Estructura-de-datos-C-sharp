using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleNodoCabeza
{
    class ListaDoblementeEnlasadaNodoCabeza
    {
        public Nodo primero = null;
        public Nodo ultimo = null;
        public NodoCabeza cabeza;

        public void CrearCabeza()
        {
            cabeza = new NodoCabeza();
            cabeza.informacion = 0;
            cabeza.enlase = null;
        }

        public bool Vacio()
        {
            if (cabeza == null)
                return true;
            else
                return false;
        }

        public void Insertar(int x)
        {
            Nodo p;
            if (Vacio())
            {
                CrearCabeza();
                primero = new Nodo();
                primero.informacion = x;
                primero.Enlasederecho = null;
                primero.Enlaseizquierdo = null;
                cabeza.enlase = primero;
                ultimo = primero;

            }
            else
            {
                p = new Nodo();
                p.informacion = x;
                p.Enlasederecho = null;
                p.Enlaseizquierdo = ultimo;
                ultimo.Enlasederecho = p;
                ultimo = p;
             
            }
        }

        public void Eliminar()
        {
            Nodo p;
            if (Vacio())
            {
                MessageBox.Show("La lista esta vacia, no se puede eliminar mas elementos");
            }
            
            else
            {
               
                p = new Nodo();
                p = ultimo;
                ultimo = ultimo.Enlaseizquierdo;
                MessageBox.Show("El elemento eliminado es " + p.informacion);
                p.Enlasederecho = null;
                p = null;
                cabeza.informacion--;
              
            }
        }
    }
}
