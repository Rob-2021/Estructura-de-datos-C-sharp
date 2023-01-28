using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleCabeza
{
    public partial class Form1 : Form
    {
        ListaDE lde = new ListaDE();

        public void mostrarListaCabeza()
        {
            NodoDoble p;
            int cont = 0;
            lstListaCabeza.Clear();
            p = lde.cabeza.Enlace;
            while (p != null)
            {
                lstListaCabeza.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
                cont++;
                txtCabeza.Text = cont.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btninsertarcabeza_Click(object sender, EventArgs e)
        {
            lde.insertar_ordenado(Int32.Parse(txtElementoCabeza.Text));
            txtElementoCabeza.Text = "";
            txtElementoCabeza.Focus();
            mostrarListaCabeza();
        }
    }
}
