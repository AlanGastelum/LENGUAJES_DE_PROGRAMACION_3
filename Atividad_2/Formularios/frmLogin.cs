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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                MessageBox.Show("Debe de ingresar contraseña.");
            }
            else if (txtContrasena.Text == "12345")
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }
    }
}
