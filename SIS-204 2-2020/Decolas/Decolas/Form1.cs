using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decolas
{
    public partial class Form1 : Form
    {
        Decola decola = new Decola();

        public void mostrar()
        {
            lstElemento.Clear();
            for(int i=0; i <= decola.ultimo; i++)
            {
                lstElemento.Items.Add(decola.cola[i].ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarDelante_Click(object sender, EventArgs e)
        {
            decola.insertarDelante(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrar();
        }

        private void btnEliminarAtras_Click(object sender, EventArgs e)
        {
            decola.eliminarAtras();
            mostrar();
        }
    }
}
