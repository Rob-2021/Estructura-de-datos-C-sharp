using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta_5_Lista_triple
{
    public partial class btnConcatenar : Form
    {
        ListaDoblementeEnlazada lde = new ListaDoblementeEnlazada();
        ListaDoblementeEnlazada lde2 = new ListaDoblementeEnlazada();
        ListaDoblementeEnlazada lde3 = new ListaDoblementeEnlazada();

        public void mostrarLista()
        {
            Nodo p;
            p = lde.primero;
            lstElemento1.Clear();
            while (p != null)
            {
                lstElemento1.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
        }

        public void mostrarLista2()
        {
            Nodo p;
            p = lde2.primero;
            lstElemento2.Clear();
            while (p != null)
            {
                lstElemento2.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
        }

        public void mostrarLista3()
        {
            Nodo p, q;
            p = lde.primero;
            lstElemento3.Clear();
            while (p != null)
            {
                lstElemento3.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }

            q = lde2.primero;
            while (q != null)
            {
                lstElemento3.Items.Add(q.Info.ToString());
                q = q.EnlaceDerecho;
            }
        }

        public btnConcatenar()
        {
            InitializeComponent();
        }

        private void btnInsertar1_Click(object sender, EventArgs e)
        {
            lde.insertar_ordenado(Int32.Parse(txtElemento1.Text));
            txtElemento1.Text = "";
            txtElemento1.Focus();
            mostrarLista();
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            lde2.insertar_ordenado(Int32.Parse(txtElemento2.Text));
            txtElemento2.Text = "";
            txtElemento2.Focus();
            mostrarLista2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarLista3();
            mostrarLista2();
        }
    }
}
