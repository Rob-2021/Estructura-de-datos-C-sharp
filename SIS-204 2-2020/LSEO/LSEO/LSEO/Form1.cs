using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSEO
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlazadaOrdenada lseo = new ListaSimplementeEnlazadaOrdenada();
     

        public void mostrarLista()
        {
            Nodo aux = lseo.primero;
            list.Clear();
            while (aux != null)
            {
                list.Items.Add(aux.Info.ToString());
                aux = aux.EnlaceDerecho;
            }
         
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenado_Click(object sender, EventArgs e)
        {
            
            lseo.insertar_ordenado(Int32.Parse(txtElement.Text));
            txtElement.Text = "";
            txtElement.Focus();
            mostrarLista();
        }
    }
}
