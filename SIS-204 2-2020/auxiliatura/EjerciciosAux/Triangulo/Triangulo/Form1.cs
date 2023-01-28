using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            //INSTANCIACION
            AreaPerimetro tri3 = new AreaPerimetro();
            double ar = tri3.calcular(a,b);
            MessageBox.Show("El area es : " + ar);
            /*AreaPerimetro tri1 = new AreaPerimetro(a,b,c);
            double ar = tri1.area();
            MessageBox.Show("El area es : "+ar);
            */
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);

            AreaPerimetro tri3 = new AreaPerimetro();
            double per = tri3.calcular(a, b,c);
            MessageBox.Show("El perimetro es : " + per);

            //INSTANCIACION
           // AreaPerimetro tri2 = new AreaPerimetro(a, b, c);
            //double per = tri2.perimetro();
            //MessageBox.Show("El perimetro es : " + per);
        }
    }
}
