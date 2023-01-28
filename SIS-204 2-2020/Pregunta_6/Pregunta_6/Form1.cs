using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta_6
{
    public partial class Form1 : Form
    {
        ListaEnlazada lsec = new ListaEnlazada();

        public void mostrarLista()
        {
            NodoDoble p;
            p = lsec.primero;
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

        private void btninsertarcabeza_Click(object sender, EventArgs e)
        {
            lsec.insertar_ordenado(Int32.Parse(txtElementoCabeza.Text));
            txtElementoCabeza.Text = "";
            txtElementoCabeza.Focus();
            mostrarLista();
        }
    }
}
