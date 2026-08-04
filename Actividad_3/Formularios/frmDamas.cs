using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3_CRUD.Formularios
{
    public partial class frmDamas : Form
    {
        public frmDamas()
        {
            InitializeComponent();
        }

        private void gbModelos_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Formularios.frmPrincipal principal = new Formularios.frmPrincipal();
            principal.Show();
            this.Close();
        }
    }
}
