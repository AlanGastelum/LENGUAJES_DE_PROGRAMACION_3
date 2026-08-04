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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmCliente cliente = new Formularios.frmCliente();
            cliente.Show();
            this.Hide();
        }

        private void damasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmDamas damas = new Formularios.frmDamas();
            damas.Show();
            this.Hide();
        }

        private void caballerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmCaballeros caballeros = new Formularios.frmCaballeros();
            caballeros.Show();
            this.Hide();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmProveedor proveedor = new Formularios.frmProveedor();
            proveedor.Show();
            this.Hide();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmProducto producto = new Formularios.frmProducto();
            producto.Show();
            this.Hide();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.frmCompra compra = new Formularios.frmCompra();
            compra.Show();
            this.Hide();
        }

        private void quienesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapatería UMI es una empresa dedicada a ofrecer calzado para dama y caballero, buscando brindar calidad, comodidad y buen servicio.", "¿Quiénes somos?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void misiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ofrecer calzado de calidad que satisfaga las necesidades de nuestros clientes, mediante una atención amable y productos accesibles.",
                "Misión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void visiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ser una zapatería reconocida por la calidad de sus productos, su variedad y el buen servicio ofrecido a sus clientes.",
                "Visión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir del sistema?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
