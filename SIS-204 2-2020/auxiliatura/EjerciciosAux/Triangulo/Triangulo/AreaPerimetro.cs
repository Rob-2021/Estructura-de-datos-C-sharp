using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class AreaPerimetro
    {
        
        //Atributos
        private double a;
        private double b;
        private double c;
        
        //CONSTRUCTORES

       /* public AreaPerimetro(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        //funciones

        public double area() {
            double ar = a * b / 2;
            return ar;
        }

        public double perimetro() {
            double per = a + b + c;
            return per;
        }*/


        //CALCULAR AREA
        public double calcular(double a, double b){
            double ar = a * b / 2;
            return ar;
        }

        //PERIMETRO
        public double calcular(double a, double b, double c){
            double per = a + b + c;
            return per;

        }

    }

}
