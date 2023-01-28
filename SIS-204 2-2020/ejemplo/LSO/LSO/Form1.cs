using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSO
{
    public partial class Form1 : Form
    {
        ListaSimplementeOrdenada lseo = new ListaSimplementeOrdenada();

        public void mostrarLista()
        {
            Nodo aux = lseo.inicio;
            list.Clear();
            while(aux != null)
            {
                list.Items.Add(aux.Info.ToString());
                aux = aux.EnlaceDerecho;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            lseo.insertar_ordenado(Int32.Parse(txtElement.Text));
            txtElement.Text = "";
            txtElement.Focus();
            mostrarLista();
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            lseo.contar_pares();
        }

        private void btnImpar_Click(object sender, EventArgs e)
        {
            lseo.contar_impares();
        }
    }
}
