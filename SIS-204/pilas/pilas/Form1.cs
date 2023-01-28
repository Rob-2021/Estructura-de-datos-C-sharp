using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pilas
{
    public partial class Form1 : Form
    {
        Pila _pila = new Pila();

        public void mostrasPila()
        {
            lstPila.Clear();
            for(int i = 0; i <= _pila.tope; i++)
            {
                lstPila.Items.Add(_pila.lista[i].ToString());
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            _pila.Insertar(int.Parse(txtElemento.Text));
            mostrasPila();
        }
    }
}
