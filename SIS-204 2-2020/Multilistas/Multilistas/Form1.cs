using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilistas
{
    public partial class Form1 : Form
    {
        Multilista multilista = new Multilista();

        private DataTable dtMaterias;

        public void MostrarMaterias(DataTable dtMaterias)
        {
            NodoMateria p = multilista.carrera.EnlaceMateria;
            dtMaterias.Rows.Clear();
            while (p != null)
            {
                DataRow row = dtMaterias.NewRow();
                row["Sigla"] = p.Sigla;
                row["Materia"] = p.NombreMateria;

                dtMaterias.Rows.Add(row);

                p = p.EnlaceMateria;
            }
        }
        public Form1()
        {
            InitializeComponent();
            dtMaterias = new DataTable();
            dtMaterias.Columns.Add("Sigla");
            dtMaterias.Columns.Add("Materia");

            dGMaterias.DataSource = dtMaterias;
        }

        private void btnCrearCarrera_Click(object sender, EventArgs e)
        {
            multilista.crearCarrera(txtCarrera.Text);
        }

        private void btnInsertarMateria_Click(object sender, EventArgs e)
        {
            multilista.insertarMateria(txtSigla.Text, txtMateria.Text);
            txtSigla.Text = "";
            txtMateria.Text = "";
            txtSigla.Focus();
            txtCantidadMaterias.Text = multilista.carrera.CantidadMaterias.ToString();

        }

        private void btnMostrarMateria_Click(object sender, EventArgs e)
        {
            MostrarMaterias(dtMaterias);
        }
    }
}
