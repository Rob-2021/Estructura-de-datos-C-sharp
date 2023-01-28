using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasViernes
{
    public partial class Form1 : Form
    {
        //CREAR LOS ATRIBUTOS
        private const int maxPila = 5;
        private int tope = 0;
        private char[] pilaVec = new char[maxPila];

        //CREACION DE FUNCIONES O METODOS

        public bool vacia() {
            if (tope == 0)
                return true;
            else
                return false;
        }

        public bool llena() {
            if (tope == maxPila)
                return true;
            else
                return false;
        }

        public void insertar(char letra) {
            if (llena())
                MessageBox.Show("La pila esta llena");
            else {
                pilaVec[tope] = letra;
                tope++;
                listaPila.Items.Add(letra);
            }
        }

        public void eliminar() {
            if (vacia())
                MessageBox.Show("La pila esta vacia");
            else {
                tope--;
                pilaVec[tope] = '0';
               
                }
        }

        public void invertir() {
            char[] pilaInv = new char[maxPila];
            int aux = tope-1;
            for(int a = 0; a<tope;a++){
                pilaInv[a]=pilaVec[aux];
                aux--;
            }
            pilaVec = pilaInv;
        }

        public void mostrarPila() {
            listaPila.Items.Clear();
            for (int a = 0; a < tope; a++) {
                listaPila.Items.Add(pilaVec[a]);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLetra.Text))
            {
                MessageBox.Show("La pila esta vacia");
            }
            else
            {
                char letra = Convert.ToChar(txtLetra.Text);
                insertar(letra);
                lbTope.Text = tope.ToString();
                txtLetra.Clear();
                txtLetra.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lbTope.Text = tope.ToString();
            try
            {
                eliminar();
                listaPila.Items.RemoveAt(tope);
            }
            catch (Exception en) { }
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            invertir();
            mostrarPila();
        }
    }
}
