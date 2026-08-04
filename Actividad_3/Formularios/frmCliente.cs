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
    public partial class frmCliente : Form
    {

        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM cliente WHERE Dni = '" + txtDni.Text + "'", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtDni.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtFechaNac.Clear();
                txtTelefono.Clear();

                MessageBox.Show("El cliente ha sido eliminado exitosamente.");
            }
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
                SqlCommand cmd = new SqlCommand("INSERT INTO cliente (Dni, Nombre_cliente, Apellidos_cliente, Fecha_nac, Telefono_cliente) VALUES ('" + txtDni.Text + "','"
                    + txtNombre.Text + "','"
                    + txtApellidos.Text + "','"
                    + txtFechaNac.Text + "','"
                    + txtTelefono.Text + "')", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cliente agregado correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM cliente", cn);

                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvClientes.DataSource = dt;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection( "Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE cliente SET " +
                    "Nombre_cliente = '" + txtNombre.Text + "', " +
                    "Apellidos_cliente = '" + txtApellidos.Text + "', " +
                    "Fecha_nac = '" + txtFechaNac.Text + "', " +
                    "Telefono_cliente = '" + txtTelefono.Text + "' " +
                    "WHERE Dni = '" + txtDni.Text + "'", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtDni.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtFechaNac.Clear();
                txtTelefono.Clear();

                MessageBox.Show("El cliente ha sido modificado exitosamente.");
            }
        }
    }
}
