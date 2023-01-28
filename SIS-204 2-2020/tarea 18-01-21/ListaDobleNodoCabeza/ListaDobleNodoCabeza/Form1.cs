using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleNodoCabeza
{
    public partial class Form1 : Form
    {
        ListaDoblementeEnlasadaNodoCabeza op = new ListaDoblementeEnlasadaNodoCabeza();

        public void MostrarLista()
        {
            Nodo p = new Nodo();
            int cont = 0;
            listMOSTRAR.Clear();
            p = op.cabeza.enlase;
            //do
            //{
            //    listMOSTRAR.Items.Add(p.informacion.ToString());
            //    p = p.Enlasederecho;
            //    cont++;
            //    textCABEZA.Text = cont.ToString();

            //} while (p != null);
            //for(p = op.primero; p!= null; p= p.Enlasederecho)
            //{
            //    listMOSTRAR.Items.Add(p.informacion.ToString());
            //}
            while(p != null)
            {
                listMOSTRAR.Items.Add(p.informacion.ToString());
                p = p.Enlasederecho;
                cont++;
                textCABEZA.Text = cont.ToString();
            }

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
            MostrarLista();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            op.Eliminar();
            MostrarLista();
        }
    }
}
