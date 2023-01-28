using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDoblementeCircular
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlasadaCircular op = new ListaDoblementeEnlasadaCircular();

        public void Mostarlista()
        {
            Nodo p = new Nodo();
            listMOSTRAR.Clear();
            p = op.primero;
            do
            {
                listMOSTRAR.Items.Add(p.Informacion.ToString());
                p = p.enlasederecho;
            } while (p != op.primero);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnINSERTAR_Click(object sender, EventArgs e)
        {
            op.Insertar(Convert.ToInt32(textELEMENTO.Text));
            textELEMENTO.Text = " ";
            textELEMENTO.Focus();
            Mostarlista();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            op.Eliminar();
            Mostarlista();
        }
    }
}
