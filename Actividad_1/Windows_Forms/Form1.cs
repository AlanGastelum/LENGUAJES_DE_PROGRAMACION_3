using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expediente_de_Alumno
{
    public partial class frmExpediente : Form
    {
        public frmExpediente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmExpediente_Load(object sender, EventArgs e)
        {

        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             "Nombre: " + txtNombre.Text +
             "\nFecha de nacimiento: " + txtFechaNacimiento.Text +
             "\nDirección: " + txtDireccion.Text +
             "\nEstado: " + lstEstados.Text +
             "\nHorario: " + (rbMatutino.Checked ? "Matutino" : "Vespertino"),
             "Expediente guardado");

            txtNombre.Clear();
            txtFechaNacimiento.Clear();
            txtDireccion.Clear();
            lstEstados.ClearSelected();
            rbMatutino.Checked = false;
            rbVespertino.Checked = false;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
