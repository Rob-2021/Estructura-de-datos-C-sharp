using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas_1
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();

        public void mostrarPila()
        {
            lstViewPila.Clear();
            for(int i = 0; i <= pila.tope; i++)
            {
                lstViewPila.Items.Add(pila.pila[i].ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            pila.Insertar(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarPila();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pila.Eliminar();
            mostrarPila();
        }
    }
}
