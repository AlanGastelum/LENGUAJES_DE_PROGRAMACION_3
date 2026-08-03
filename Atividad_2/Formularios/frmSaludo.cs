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
    public partial class frmSaludo : Form
    {
        public frmSaludo()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Formularios.frmMenu menu = new Formularios.frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            Clases.clsSaludo saludo = new Clases.clsSaludo();
            string MiSaludo = saludo.Saludar(txtNombre.Text);
            MessageBox.Show(MiSaludo);
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void frmSaludo_Load(object sender, EventArgs e)
        {

        }
    }
}
