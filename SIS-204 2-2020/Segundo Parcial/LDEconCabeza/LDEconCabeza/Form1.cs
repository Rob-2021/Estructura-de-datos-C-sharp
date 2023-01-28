using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDEconCabeza
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlazada lsec = new ListaDoblementeEnlazada();

        public void mostrarListaCabeza()
        {
            NodoDoble p;
            int cont = 0;
            lstListaCabeza.Clear();
            p = lsec.cabeza.Enlace;
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
            lsec.insertar_ordenado(Int32.Parse(txtElementoCabeza.Text));
            txtElementoCabeza.Text = "";
            txtElementoCabeza.Focus();
            mostrarListaCabeza();
        }

        private void txtCabeza_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lstListaCabeza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtElementoCabeza_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
