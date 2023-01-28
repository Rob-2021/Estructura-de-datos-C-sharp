using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario
{
    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();

        void MostrarSuma()
        {
            int suma = 0;

            lstViewArbol.Clear();
            for (int i = 0; i <= arbol.topeRecorrido - 1; i++)
            {
                if (arbol.recorrido[i] % 7 == 0)
                {
                    suma = suma + arbol.recorrido[i];

                }
            }

            lstViewArbol.Items.Add(suma.ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearLexicografico_Click(object sender, EventArgs e)
        {
            arbol.crearArbolLexicografico(int.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            arbol.preOrden(arbol.raiz);
            MostrarSuma();
        }
    }
}
