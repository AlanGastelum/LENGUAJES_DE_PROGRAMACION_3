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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmSaludo saludo = new Formularios.frmSaludo();
            saludo.Show();
            this.Hide();
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmInformacionPersonal informacion = new Formularios.frmInformacionPersonal();
            informacion.Show();
            this.Hide();
        }

        private void operaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmOperaciones operaciones = new Formularios.frmOperaciones();
            operaciones.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea salir del sistema?", "Confirmar salida", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
