using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDE
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlazada lde = new ListaDoblementeEnlazada();

        public void mostrarLista()
        {
            Nodo p;
            p = lde.primero;
            lstListaDoble.Clear();
            while (p != null)
            {
                lstListaDoble.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarCola_Click(object sender, EventArgs e)
        {
            lde.insertar_cola(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }

        private void btnInsertarOrdenado_Click(object sender, EventArgs e)
        {
            lde.insertar_ordenado(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lde.eliminar(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }
    }
}
