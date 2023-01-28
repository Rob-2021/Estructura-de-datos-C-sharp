using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta_6_ColaYPila
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();

        public void mostrarCola()
        {
            lstElementos.Clear();
            for (int i = 0; i <= cola.ultimo; i++)
            {
                lstElementos.Items.Add(cola.cola[i].ToString());
            }
        }

        public void mostrarPila()
        {
            lstElementos2.Clear();
            for (int i = 0; i <= cola.tope; i++)
            {
                lstElementos2.Items.Add(cola.pila[i].ToString());
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarDelante_Click(object sender, EventArgs e)
        {
            cola.insertar(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarCola();
        }

        private void btnEliminarAtras_Click(object sender, EventArgs e)
        {
            cola.eliminarAtras();
            mostrarCola();
            mostrarPila();
        }
    }
}
