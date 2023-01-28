using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String ci = txtCi.Text;
            Persona pe1 = new Persona(nombre, apellido, ci);
            MessageBox.Show("Nombre : "+pe1.getNombre()+ "\n Apellido : "+pe1.getApellido()+"\n Ci:"+pe1.getCi());
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String ci = txtCi.Text;
            Cliente cli1 = new Cliente(nombre,apellido,ci);
            cli1.setCategoria("VIP");
            MessageBox.Show("Nombre : " + cli1.getNombre() + "\n Apellido : " + cli1.getApellido() + "\n Ci:" + cli1.getCi()+"\n Categoria :"+cli1.getCategoria()+"\n Codigo :"+cli1.getCodigo());
        }
    }
}
