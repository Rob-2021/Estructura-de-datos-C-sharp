using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaEnlazadas2Jueves
{
    public partial class Form1 : Form
    {
        ListaEnlazada lista = new ListaEnlazada();
        public Form1()
        {
            InitializeComponent();
        }

        public void mostrarLista() {
            listaEnlazadaBox.Items.Clear();
            Nodo mostrar = new Nodo();
            mostrar=lista.primero;
            while (mostrar != null) {
                listaEnlazadaBox.Items.Add(mostrar.nombre+"\t"+mostrar.horas);
                mostrar = mostrar.enlace;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtHoras.Text))
            {
                MessageBox.Show("Ingrese los valores");
            }

            else {
                string nombre = txtNombre.Text;
                int horas = Convert.ToInt16(txtHoras.Text);
                lista.insertar(nombre, horas);
                mostrarLista();
                txtNombre.Clear();
                txtHoras.Clear();
                txtNombre.Focus();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
                MessageBox.Show("Ingrese un nombre para eliminar");
            else {
                string nombre = txtNombre.Text;
                Nodo eliminado = lista.eliminar(nombre);
                if (eliminado.nombre == null)
                    MessageBox.Show("No se encontro a ese empleado");
                else
                    MessageBox.Show("Usted elimino al empleado : \n Nombre: "+eliminado.nombre+"\n Horas: "+eliminado.horas);
                    mostrarLista();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primer Empleado \n Nombre :"+lista.primero.nombre+"\n Horas : "+lista.primero.horas);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ultimo Empleado \n Nombre :" + lista.ultimo.nombre + "\n Horas : " + lista.ultimo.horas);
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            Nodo mayor = lista.getMayor();
            MessageBox.Show("Nombre: "+mayor.nombre+"\n Horas: "+mayor.horas);
        }
    }
}
