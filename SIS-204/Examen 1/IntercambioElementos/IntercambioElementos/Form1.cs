using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntercambioElementos
{
    public partial class Form1 : Form
    {
        Pila _pila1 = new Pila();
        Pila _pila2 = new Pila();
        Pila pila_aux = new Pila();

        public void mostrarPila1()
        {
            lstViewPila.Clear();
            for (int i = 0; i <= _pila1.tope; i++)
            {
                lstViewPila.Items.Add(_pila1.lista[i].ToString());
            }
        }

        public void mostrarPila2()
        {
            lstViewPila2.Clear();
            for (int i = 0; i <= _pila2.tope; i++)
            {
                lstViewPila2.Items.Add(_pila2.lista[i].ToString());
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            _pila1.insertar(Int32.Parse(txtElemento1.Text));
            txtElemento1.Text = "";
            mostrarPila1();
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            _pila2.insertar(Int32.Parse(txtElemento2.Text));
            txtElemento2.Text = "";
            mostrarPila2();
        }

        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            pila_aux = _pila1;
            _pila1 = _pila2;
            _pila2 = pila_aux;
            mostrarPila1();
            mostrarPila2();
        }
    }
}
