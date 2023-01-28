using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCCabeza
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazadaCircular lsec = new ListaSimplementeEnlazadaCircular();
        ListaDoblementeEnlazadaCabeza ldecabeza = new ListaDoblementeEnlazadaCabeza();

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

        public void mostrarListaCabeza()
        {
            NodoDoble p;
            lstListaCabeza.Clear();
            p = ldecabeza.cabeza.Enlace;
            while (p != null)
            {
                lstListaCabeza.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
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

        private void btninsertarcabeza_Click(object sender, EventArgs e)
        {
            ldecabeza.insertar(Convert.ToChar(txtElementoCabeza.Text.Substring(0,1)));
            txtCabeza.Text = ldecabeza.cabeza.Info.ToString();
            txtElementoCabeza.Text = "";
            txtElementoCabeza.Focus();
            mostrarListaCabeza();
        }

        private void txtCabeza_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
