using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDECCabeza
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlazada ldecc = new ListaDoblementeEnlazada();

        public void mostrarListaCabeza()
        {
            NodoDoble p;
            int cont = 0;
            lstListaCabeza.Clear();
            p = ldecc.cabeza.Enlace;
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
            ldecc.insertar(Int32.Parse(txtElementoCabeza.Text));
            txtElementoCabeza.Text = "";
            txtElementoCabeza.Focus();
            mostrarListaCabeza();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ldecc.eliminar();
            mostrarListaCabeza();
        }
    }
}
