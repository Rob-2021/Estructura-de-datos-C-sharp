using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        Lista estudiantes = new Lista();

        private DataTable dtEstudiantes;

        public void MostrarEstudiante(DataTable dtEstudiantes)
        {
            NodoEstudiante q;
            dtEstudiantes.Rows.Clear();
            q = estudiantes.estudiante;
            while(q != null)
            {
                DataRow rowEstudiante = dtEstudiantes.NewRow();
                rowEstudiante["Nombre"] = q.NombreCompleto;
                rowEstudiante["Edad"] = q.Edad;
                rowEstudiante["Sexo"] = q.Sexo;
                dtEstudiantes.Rows.Add(rowEstudiante);
                q = q.EnlaceEstudiante;
            }
        }

        public Form1()
        {
            InitializeComponent();

            dtEstudiantes = new DataTable();
            dtEstudiantes.Columns.Add("Nombre");
            dtEstudiantes.Columns.Add("Edad");
            dtEstudiantes.Columns.Add("Sexo");

            dgvEstudiantes.DataSource = dtEstudiantes;


        }

        private void btnInsertarEstudiante_Click(object sender, EventArgs e)
        {
            
            estudiantes.insertarEstudiante(txtNombre.Text, txtEdad.Text, txtSexo.Text);
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtSexo.Text = "";
        }

        private void btnMostrarEstudiante_Click(object sender, EventArgs e)
        {
            MostrarEstudiante(dtEstudiantes);
        }
    }
}
