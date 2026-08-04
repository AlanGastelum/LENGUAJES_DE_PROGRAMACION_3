using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad3_CRUD.Formularios
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Formularios.frmPrincipal principal = new Formularios.frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO proveedor (Nif, Nombre_proveedor, Direccion_proveedor, Telefono) VALUES (" + txtNif.Text + ",'"
                    + txtNombre.Text + "','"
                    + txtDireccion.Text + "','"
                    + txtTelefono.Text + "')", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Proveedor agregado correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM proveedor", cn);

                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvProveedores.DataSource = dt;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE proveedor SET " + "Nombre_proveedor = '" + txtNombre.Text + "', "
                    + "Direccion_proveedor = '" + txtDireccion.Text + "', "
                    + "Telefono = '" + txtTelefono.Text + "' "
                    + "WHERE Nif = " + txtNif.Text, cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtNif.Clear();
                txtNombre.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();

                MessageBox.Show("El proveedor ha sido modificado exitosamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM proveedor WHERE Nif = " + txtNif.Text, cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtNif.Clear();
                txtNombre.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();

                MessageBox.Show("El proveedor ha sido eliminado exitosamente.");
            }
        }
    }
}
