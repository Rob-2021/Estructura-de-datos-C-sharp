using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSECircular
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazadaCircular lsec = new ListaSimplementeEnlazadaCircular();

        public void mostrarLista()
        {
            Nodo p = new Nodo();

            lstListaCircular.Clear();
            p = lsec.lista;
            do
            {
                lstListaCircular.Items.Add(p.Info.ToString());
                p = p.Enlace;
            } while (p != lsec.lista);
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar1_Click(object sender, EventArgs e)
        {
            lsec.insertar1(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            lsec.insertar2(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lsec.eliminar();
            mostrarLista();
        }
    }
}
