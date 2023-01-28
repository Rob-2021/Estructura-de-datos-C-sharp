using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaCircular
{
    public partial class Form1 : Form
    {
        ColasCirculares cola = new ColasCirculares();
        
        public void mostrar()
        {
            lstColaCircular.Clear();
            for(int i = 0; i <= cola.maxcola-1; i++)
            {
                lstColaCircular.Items.Add(cola.cola[i]);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            cola.insertar(txtElemento.Text);
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
