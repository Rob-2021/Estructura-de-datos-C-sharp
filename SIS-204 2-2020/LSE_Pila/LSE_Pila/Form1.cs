using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSE_Pila
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazada lse = new ListaSimplementeEnlazada();

        public void mostrarPila()
        {
            Nodo p;
            p = lse.tope;
            lstElemento.Clear();
            while(p != null)
            {
                lstElemento.Items.Add(p.Info.ToString());
                p = p.Enlace;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            lse.insertarPila(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarPila();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lse.eliminarPila();
            mostrarPila();
        }

        private void lstElemento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
