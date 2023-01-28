using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Cliente:Persona
    {
        private String categoria;
        private String codigo;

        public Cliente(String nombres, String apellidos, String carnet):base(nombres,apellidos,carnet){
            this.categoria = "Ninguno";
        }


        public void setCategoria(String cate) {
            this.categoria = cate;
        }

        public String getCategoria() {
            return categoria;
        }

        public String getCodigo() { 
            //CL-APELLIDO-01
            return generarCodigo();
        }

        public String generarCodigo() {
            return "CL-" + getApellido() + "-01";
        }

    }
}
