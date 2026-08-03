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
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "" ||
                txtNumero3.Text == "" || txtNumero4.Text == "" ||
                txtNumero5.Text == "" || txtNumero6.Text == "")
            {
                MessageBox.Show("Ingresa los seis números antes de realizar la operación.");
                return;
            }
            int resultado;
            Clases.clsOperaciones clsOperacion = new Clases.clsOperaciones();

            resultado = clsOperacion.Sumar(
                int.Parse(txtNumero1.Text),
                int.Parse(txtNumero2.Text),
                int.Parse(txtNumero3.Text),
                int.Parse(txtNumero4.Text),
                int.Parse(txtNumero5.Text),
                int.Parse(txtNumero6.Text));

            txtResultado.Text = resultado.ToString();
            txtResultado.BackColor = Color.Gold;
            txtResultado.ForeColor = Color.Black;
            txtResultado.Focus();
            txtResultado.SelectAll();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "" ||
        txtNumero3.Text == "" || txtNumero4.Text == "" ||
        txtNumero5.Text == "" || txtNumero6.Text == "")
            {
                MessageBox.Show("Ingresa los seis números antes de realizar la operación.");
                return;
            }
            int resultado;
            Clases.clsOperaciones clsOperacion = new Clases.clsOperaciones();

            resultado = clsOperacion.Restar(
                int.Parse(txtNumero1.Text),
                int.Parse(txtNumero2.Text),
                int.Parse(txtNumero3.Text),
                int.Parse(txtNumero4.Text),
                int.Parse(txtNumero5.Text),
                int.Parse(txtNumero6.Text));

            txtResultado.Text = resultado.ToString();
            txtResultado.BackColor = Color.Gold;
            txtResultado.ForeColor = Color.Black;
            txtResultado.Focus();
            txtResultado.SelectAll();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "" ||
        txtNumero3.Text == "" || txtNumero4.Text == "" ||
        txtNumero5.Text == "" || txtNumero6.Text == "")
            {
                MessageBox.Show("Ingresa los seis números antes de realizar la operación.");
                return;
            }
            int resultado;
            Clases.clsOperaciones clsOperacion = new Clases.clsOperaciones();

            resultado = clsOperacion.Multiplicar(
                int.Parse(txtNumero1.Text),
                int.Parse(txtNumero2.Text),
                int.Parse(txtNumero3.Text),
                int.Parse(txtNumero4.Text),
                int.Parse(txtNumero5.Text),
                int.Parse(txtNumero6.Text));

            txtResultado.Text = resultado.ToString();
            txtResultado.BackColor = Color.Gold;
            txtResultado.ForeColor = Color.Black;
            txtResultado.Focus();
            txtResultado.SelectAll();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "" ||
        txtNumero3.Text == "" || txtNumero4.Text == "" ||
        txtNumero5.Text == "" || txtNumero6.Text == "")
            {
                MessageBox.Show("Ingresa los seis números antes de realizar la operación.");
                return;
            }
            int resultado;
            Clases.clsOperaciones clsOperacion = new Clases.clsOperaciones();

            resultado = clsOperacion.Dividir(
                int.Parse(txtNumero1.Text),
                int.Parse(txtNumero2.Text),
                int.Parse(txtNumero3.Text),
                int.Parse(txtNumero4.Text),
                int.Parse(txtNumero5.Text),
                int.Parse(txtNumero6.Text));

            txtResultado.Text = resultado.ToString();
            txtResultado.BackColor = Color.Gold;
            txtResultado.ForeColor = Color.Black;
            txtResultado.Focus();
            txtResultado.SelectAll();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            txtNumero4.Clear();
            txtNumero5.Clear();
            txtNumero6.Clear();
            txtResultado.Clear();

            txtResultado.BackColor = Color.White;
            txtResultado.ForeColor = Color.Black;
            txtNumero1.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Formularios.frmMenu menu = new Formularios.frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
