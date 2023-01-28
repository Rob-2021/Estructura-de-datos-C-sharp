using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            /*int numero = Convert.ToInt16(txtNumero.Text);
            arbol.insertar(numero);
            txtNumero.Clear();
            txtNumero.Focus();*/
            arbol.insertar(120);
            arbol.insertar(87);
            arbol.insertar(100);
            arbol.insertar(42);
            arbol.insertar(50);
            arbol.insertar(20);
            arbol.insertar(200);
            arbol.insertar(500);
            arbol.insertar(140);
            arbol.insertar(130);
            arbol.insertar(160);
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            arbol.preOrden(arbol.raiz);
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            int altura = arbol.altura(arbol.raiz,0);
            txtReco.Text=altura.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int busc = Convert.ToInt16(txtReco.Text);
            int eliminado=arbol.eliminar(busc);
            MessageBox.Show("Usted elimino el numero: "+eliminado.ToString());
        }

        private void btnPNodo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbol.bNodo.numero.ToString());
        }

        private void btnPNodoAnt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbol.bNodoAnterior.numero.ToString());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int busc = Convert.ToInt16(txtReco.Text);
            int num = arbol.buscar(arbol.raiz,busc);
            MessageBox.Show(num.ToString());
        }
    }
}
