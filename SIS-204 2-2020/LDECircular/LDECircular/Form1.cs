using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDECircular
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlazadaCircular lde = new ListaDoblementeEnlazadaCircular();

        public void mostrarLista()
        {
            NodoDoble p;
            p = lde.primero;
            lstListaDoble.Clear();
            do
            {
                lstListaDoble.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            } while (p != lde.primero);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarOrdenado_Click(object sender, EventArgs e)
        {
            lde.insertar(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lde.eliminar();
            mostrarLista();
        }
    }
}
