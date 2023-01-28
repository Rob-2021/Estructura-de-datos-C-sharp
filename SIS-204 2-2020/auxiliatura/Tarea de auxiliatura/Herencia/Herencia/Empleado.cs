using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Empleado:Persona
    {
        private String tipoContrato;
        private double sueldo;

        public Empleado(String nombres, String apellidos, String carnet) : base(nombres, apellidos, carnet)
        {
            this.tipoContrato = "--------";
        }

        public void setContrato(String t_con)
        {
            this.tipoContrato = t_con;
        }

        public String getContrato()
        {
            return tipoContrato;
        }

        public void setSueldo(double x)
        {
            this.sueldo = x;
        }

        public double getSueldo()
        {
            return sueldo;
        }

    }
}
