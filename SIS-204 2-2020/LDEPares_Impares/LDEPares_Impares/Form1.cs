using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDEPares_Impares
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlazada lde = new ListaDoblementeEnlazada();

        public void mostrarLista()
        {
            Nodo aux = lde.primero;
            int pares = 0;
            int impares = 0;
            lstElemento.Clear();
            while (aux != null)
            {
                lstElemento.Items.Add(aux.Info.ToString());
                if (aux.Info % 2 == 0)
                {
                    pares++;
                    txtPar.Text = pares.ToString();
                }
                else
                {
                    impares++;
                    txtImpar.Text = impares.ToString();
                }
                aux = aux.EnlaceDerecho;
            }
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
