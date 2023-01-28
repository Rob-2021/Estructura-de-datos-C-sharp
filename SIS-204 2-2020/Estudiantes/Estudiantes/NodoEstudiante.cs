using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes
{
    class NodoEstudiante
    {
        private string nombreCompleto;
        private string edad;
        private string sexo;
        private NodoEstudiante enlaceEstudiante;


        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public NodoEstudiante EnlaceEstudiante
        {
            get { return enlaceEstudiante; }
            set { enlaceEstudiante = value; }
        }
    }
}
