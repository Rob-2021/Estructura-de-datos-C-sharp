using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpresionAlgebraica
{
    public partial class Form1 : Form
    {
        Expresion_Algebraica expresionAlgebraica = new Expresion_Algebraica();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expresionAlgebraica.evaluar_expresion(txtExpresion.Text);
            txtExpresion.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtExpresion.Clear();
            
        }
    }
}
