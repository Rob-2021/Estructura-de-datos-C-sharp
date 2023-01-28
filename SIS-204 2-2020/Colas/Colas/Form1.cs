using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();

        public void mostrar()
        {
            lstElementos.Clear();
            for (int i = 0; i <= cola.ultimo; i++)
            {
                lstElementos.Items.Add(cola.cola[i].ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            cola.insertar(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cola.eliminar();
            mostrar();
        }
    }
}
