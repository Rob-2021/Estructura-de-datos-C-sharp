using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazada lse = new ListaSimplementeEnlazada();
        ListaSimplementeEnlazada lse2 = new ListaSimplementeEnlazada();

        public void MostrarPila()
        {
            Nodo p;
            p = lse.tope;
            lstViewPila.Clear();
            while (p != null)
            {
                lstViewPila.Items.Add((p.Info).ToString());
                p = p.Enlace;
            }
        }

        public void MostrarPila2()
        {
            Nodo p;
            p = lse2.tope;
            lstViewPila2.Clear();
            while (p != null)
            {
                lstViewPila2.Items.Add((p.Info).ToString());
                p = p.Enlace;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            lse.InsertarPila(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            MostrarPila();
        }
    }
}
