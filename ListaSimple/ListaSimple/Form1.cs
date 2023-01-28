using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaSimple
{
    public partial class Form1 : Form
    {
        ListaSimple lsecc = new ListaSimple();

        //public void mostrarListaCabeza()
        //{
        //    Nodo p;
        //    lstListaCabeza.Clear();
        //    p = lsecc.cabeza.Enlace;
        //    while (p != null)
        //    {
        //        lstListaCabeza.Items.Add(p.Info.ToString());
        //        p = p.Enlace;
        //    }
        //}

        public void mostrarLista()
        {
            Nodo p = new Nodo();

            lstListaCabeza.Clear();
            p = lsecc.lista;
            do
            {
                lstListaCabeza.Items.Add(p.Info.ToString());
                p = p.Enlace;
            } while (p != lsecc.lista);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btninsertarcabeza_Click(object sender, EventArgs e)
        {
            lsecc.insertar1(Convert.ToChar(txtElementoCabeza.Text.Substring(0, 1)));
            txtCabeza.Text = lsecc.cabeza.Info.ToString();
            txtElementoCabeza.Text = "";
            txtElementoCabeza.Focus();
            mostrarLista();
        }
    }
}
