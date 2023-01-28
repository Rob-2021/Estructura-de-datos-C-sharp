using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadasSDCC
{
    public partial class Form1 : Form
    {
        ListasDE lse = new ListasDE();
        ListasDE lseM7 = new ListasDE();
        ListaSEC lsec = new ListaSEC();
        ListaDEC ldec = new ListaDEC();
        ListaDECC ldecc = new ListaDECC();

        public void mostrarLista()
        {
            Nodo p;
            p = lse.primero;
            lstListaDoble.Clear();
            while (p != null)
            {
                lstListaDoble.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
        }

        public void mostrarLista2()
        {
            Nodo p;
            int suma = 0;
            p = lseM7.primero;
            lstListas.Clear();
            while (p != null)
            {
                if (p.Info % 7 == 0)
                {
                    suma = suma + p.Info;
                }
                lstListas.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            }
            txtSuma.Text = suma.ToString();
        }

        public void mostrarLista3()
        {
            NodoSimple p = new NodoSimple();
          
            lstListaSEC.Clear();
            p = lsec.lista;

            do
            {
                lstListaSEC.Items.Add(p.Info.ToString());
                p = p.Enlace;
            } while (p != lsec.lista);
        }

        public void mostrarLista4()
        {
            Nodo p;
            p = ldec.primero;
            lstListaDEC.Clear();
            do
            {
                lstListaDEC.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
            } while (p != ldec.primero);
        }

        public void mostrarListaCabeza()
        {
            Nodo p;
            int cont = 0;
            lstListaDECC.Clear();
            p = ldecc.cabeza.Enlace;
            while (p != null)
            {
                lstListaDECC.Items.Add(p.Info.ToString());
                p = p.EnlaceDerecho;
                cont++;
                txtCabeza.Text = cont.ToString();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarOrdenado_Click(object sender, EventArgs e)
        {
            lse.insertar_ordenado(Int32.Parse(txtElemento.Text));
            txtElemento.Text = "";
            txtElemento.Focus();
            mostrarLista();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            lseM7.insertar_ordenado(Int32.Parse(txtElemento2.Text));
            txtElemento2.Text = "";
            txtElemento2.Focus();
            mostrarLista2();
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            lsec.insertar(Int32.Parse(txtElemento3.Text));
            txtElemento3.Text = "";
            txtElemento3.Focus();
            mostrarLista3();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lsec.eliminar();
            mostrarLista3();
        }

        private void btnInsertar3_Click(object sender, EventArgs e)
        {
            ldec.insertar(Int32.Parse(txtElemento4.Text));
            txtElemento4.Text = "";
            txtElemento4.Focus();
            mostrarLista4();
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            ldec.eliminar();
            mostrarLista4();
        }

        private void btnInsertar4_Click(object sender, EventArgs e)
        {
            ldecc.insertar(Int32.Parse(txtElemento5.Text));
            txtElemento5.Text = "";
            txtElemento5.Focus();
            mostrarListaCabeza();
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {
            ldecc.eliminar();
            mostrarListaCabeza();
        }
    }
}
