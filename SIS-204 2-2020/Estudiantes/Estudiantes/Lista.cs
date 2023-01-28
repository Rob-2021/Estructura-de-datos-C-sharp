using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    class Lista
    {
        public NodoEstudiante estudiante;

        public bool estudianteVacio()
        {
            if (estudiante == null)
                return true;
            else
                return false;
        }

        public void insertarEstudiante(string nombreCompleto, string edad, string sexo)
        {
            NodoEstudiante p;

            if (estudianteVacio())
            {
                estudiante = new NodoEstudiante();
                estudiante.NombreCompleto = nombreCompleto;
                estudiante.Edad = edad;
                estudiante.Sexo = sexo;
                estudiante.EnlaceEstudiante = null;
            }
            else
            {
                p = new NodoEstudiante();
                p.NombreCompleto = nombreCompleto;
                p.Edad = edad;
                p.Sexo = sexo;
                p.EnlaceEstudiante = estudiante;
                estudiante = p;
            }
            MessageBox.Show("Estudiante insertado");
        }

    }
}
