using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadas2Jueves
{
    class ListaEnlazada
    {
        public Nodo primero;
        public Nodo ultimo;

        public ListaEnlazada() {
            primero = null;
            ultimo = null;
        }

        //DECLARANDO NUESTRAS FUNCIONES
        /* VACIA
         * INSERTAR POR DELANTE
         * ELIMINAR
         * MENOR 
         * MAYOR
         */

        public bool vacia() {
            return primero == null;
        }

        public void insertar(string nomb, int hs) {
            Nodo nuevo = new Nodo();
            nuevo.nombre = nomb;
            nuevo.horas = hs;
            nuevo.enlace = null;

            if (vacia())
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else {
                ultimo.enlace = nuevo;
                ultimo = nuevo;
            }
        }

        public Nodo eliminar(string nomb) {
            Nodo reco = new Nodo();
            Nodo recoAnterior = new Nodo();
            //Si quiero eliminar el primero
            if (primero.nombre == nomb)
            {
                reco = primero;
                primero = primero.enlace;
            }
            else {
                bool encontrado = false;
                reco = primero;
                while (reco != null && encontrado==false) {
                    if (reco.nombre == nomb)
                    {
                        encontrado = true;
                    }
                    else {
                        recoAnterior = reco;
                        reco = reco.enlace;
                    }
                }
                if (encontrado) {
                    //SI EL ELEMENTO QUE BUSCO ES EL ULTIMO
                    if (ultimo.nombre==nomb)
                    {
                        ultimo = recoAnterior;
                        ultimo.enlace = null;
                    }
                        //SI EL ELEMENTO QUE BUSCO ESTO POR EL MEDIO
                    else {
                        recoAnterior.enlace = reco.enlace;
                    }
                }
            }
            return reco;
        }

        public Nodo getMayor() {
            Nodo mayor = primero;
            Nodo sgte = new Nodo();
            /*sgte=primero.enlace;
            while (sgte != null) {
                if (sgte.horas > mayor.horas) {
                    mayor = sgte;
                }
                sgte = sgte.enlace;
            }*/
            for (sgte = primero.enlace; sgte != null; sgte = sgte.enlace) {
                if (sgte.horas > mayor.horas)
                    mayor = sgte;
            }
                return mayor;
        }

    }
}
