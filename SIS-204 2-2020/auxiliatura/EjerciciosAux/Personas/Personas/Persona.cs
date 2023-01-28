using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Persona
    {
        //ATRIBUTOS

        private String nombre;
        private String apellido;
        private String ci;


        //CREAR UN CONSTRUCTOR
        public Persona(String nombre, String apellido, String ci) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.ci = ci;
        }

        //get-> devuelve valor set-> introducimos el valor

        public String getNombre() {
            return nombre;
        }

        public String getApellido() {
            return apellido;
        }

        public String getCi() {
            return ci;
        }
    }
}
