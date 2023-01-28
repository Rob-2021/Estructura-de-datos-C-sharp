using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesBinarios
{
    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();

        void MostrarRecorrido()
        {
            lstViewArbol.Clear();
            for (int i = 0; i <= arbol.topeRecorrido - 1; i++)
                lstViewArbol.Items.Add(arbol.recorrido[i].ToString());
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLexicografico_Click(object sender, EventArgs e)
        {
            arbol.crearArbolLexicografico(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
        }

        private void btnPreordenRecursivo_Click(object sender, EventArgs e)
        {
            arbol.preOrdenRecursivo(arbol.raiz);
            MostrarRecorrido();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            arbol.preOrden(arbol.raiz);
            MostrarRecorrido();
        }
    }
}
