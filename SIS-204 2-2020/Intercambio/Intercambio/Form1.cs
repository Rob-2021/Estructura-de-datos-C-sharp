using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intercambio
{
    public partial class Form1 : Form
    {
        Pila pila1 = new Pila();
        Pila pila2 = new Pila();

        public void mostrarP2()
        {
            lstView2.Clear();
            for(int i =0; i <= pila2.tope; i++)
            {
                lstView2.Items.Add(pila2.pila[i].ToString());
            }
        }

        public void mostrarP1()
        {
            lstView.Clear();
            for (int i = 0; i <= pila1.tope; i++)
            {
                lstView.Items.Add(pila1.pila[i].ToString());
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar1_Click(object sender, EventArgs e)
        {
            pila1.Insertar(Int32.Parse(txtElemento1.Text));
            txtElemento1.Text = "";
            txtElemento1.Focus();
            mostrarP1();
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            pila2.Insertar(Int32.Parse(txtElemento2.Text));
            txtElemento2.Text = "";
            txtElemento2.Focus();
            mostrarP2();
        }

        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            IntercambioPilas operacion = new IntercambioPilas();
            operacion.intercambiar(pila1, pila2);
            mostrarP1();
            mostrarP2();
        }
    }
}
