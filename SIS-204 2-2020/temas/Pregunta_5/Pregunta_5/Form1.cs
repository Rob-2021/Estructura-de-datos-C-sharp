using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta_5
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlazada lde = new ListaDoblementeEnlazada();

        public void mostrarLista()
        {
            Nodo p;
            p = lde.primero;
            lstElemento.Clear();
            while (p != null)
            {
                lstElemento.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
        }

        public void mostrarListaGenerada()
        {
            Nodo p = lde.primero;
            lstGenerarLista.Clear();
            //aux=p + p.info;
            //aux=aux/cont;

            //while (p != null)
            //{
            //    lstGenerarLista.Items.Add(p.Info.ToString());
            //    p = p.EnlaceDerecho;
            //}
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            lde.insertar_ordenado(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }
    }
}
