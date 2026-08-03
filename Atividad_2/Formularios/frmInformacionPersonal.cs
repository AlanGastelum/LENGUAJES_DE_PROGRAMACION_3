using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2.Formularios
{
    public partial class frmInformacionPersonal : Form
    {
        public frmInformacionPersonal()
        {
            InitializeComponent();
        }

        private void tabDatosPersonales_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Formularios.frmMenu menu = new Formularios.frmMenu();
            menu.Show();
            this.Hide();
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbEnfermedadSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEnfermedadSi.Checked)
            {
                cmbEnfermedad.Enabled = true;
            }
        }

        private void rdbEnfermedadNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEnfermedadNo.Checked)
            {
                cmbEnfermedad.SelectedIndex = -1;
                cmbEnfermedad.Enabled = false;
            }
        }

        private void rdbAlergiaNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlergiaNo.Checked)
            {
                cmbAlergia.SelectedIndex = -1;
                cmbAlergia.Enabled = false;
            }
        }

        private void rdbOperacionNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOperacionNo.Checked)
            {
                cmbOperacion.SelectedIndex = -1;
                cmbOperacion.Enabled = false;
            }
        }

        private void rdbEjercicioNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEjercicioNo.Checked)
            {
                cmbEjercicio.SelectedIndex = -1;
                cmbEjercicio.Enabled = false;
            }
        }

        private void rdbAlergiaSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlergiaSi.Checked)
            {
                cmbAlergia.Enabled = true;
            }
        }

        private void rdbOperacionSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOperacionSi.Checked)
            {
                cmbOperacion.Enabled = true;
            }
        }

        private void rdbEjercicioSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEjercicioSi.Checked)
            {
                cmbEjercicio.Enabled = true;
            }
        }
    }
}
