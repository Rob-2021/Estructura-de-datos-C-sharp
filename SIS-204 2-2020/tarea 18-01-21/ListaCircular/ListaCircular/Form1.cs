using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCircular
{
    public partial class Form1 : Form
    {
        ListaSimplementeEnlasadaCircular op1 = new ListaSimplementeEnlasadaCircular();

        public void MostrarLista()
        {
            Nodo p = new Nodo();
            listMOSTRAR.Clear();
            p = op1.primero;
            do
            {
                listMOSTRAR.Items.Add(p.Informacion.ToString());
                p = p.Enlace;
            } while (p != op1.primero);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnINSERTAR_Click(object sender, EventArgs e)
        {
            op1.Insertar(Convert.ToInt32(textELEMENTO.Text));
            textELEMENTO.Text = " ";
            textELEMENTO.Focus();
            MostrarLista();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            op1.Eliminar();
            MostrarLista();
        }
    }
}
