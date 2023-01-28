using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPer_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String ci = txtCI.Text;
            Persona persona = new Persona(nombre, apellido, ci);
            MessageBox.Show("Nombre : " + persona.getNombre() + "\n Apellido : " + persona.getApellido() + "\n Ci:" + persona.getCi());
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String ci = txtCI.Text;
            Cliente cliente = new Cliente(nombre, apellido, ci);
            cliente.setCategoria("VIP");
            MessageBox.Show("Nombre : " + cliente.getNombre() + "\n Apellido : " + cliente.getApellido() + "\n Ci:" + cliente.getCi() + "\n Categoria :" + cliente.getCategoria() + "\n Codigo :" + cliente.getCodigo());
        }

        private void btnAgregarEmpl_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String ci = txtCI.Text;
            Empleado empleado = new Empleado(nombre, apellido, ci);
            empleado.setContrato(txtContrato.Text);
            empleado.setSueldo(double.Parse(txtsueldo.Text));
            MessageBox.Show("Nombre : " + empleado.getNombre() + "\n Apellido : " + empleado.getApellido() + "\n Ci:" + empleado.getCi() + "\n Contrato :" + empleado.getContrato() + "\n Sueldo :" + empleado.getSueldo());
        }
    }
}
