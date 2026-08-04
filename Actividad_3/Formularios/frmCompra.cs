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
    public partial class frmCompra : Form
    {
        public frmCompra()
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
                SqlCommand cmd = new SqlCommand("INSERT INTO compra (Codigo_compra, Fecha_compra, Total_compra, Dni, Codigo_producto) VALUES (" + txtCodigoCompra.Text + ",'"
                    + txtFechaCompra.Text + "',"
                    + txtTotalCompra.Text + ",'"
                    + txtDni.Text + "',"
                    + txtCodigoProducto.Text + ")", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Compra agregada correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM compra", cn);

                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvCompras.DataSource = dt;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE compra SET " + "Fecha_compra = '" + txtFechaCompra.Text + "', "
                    + "Total_compra = " + txtTotalCompra.Text + ", "
                    + "Dni = '" + txtDni.Text + "', "
                    + "Codigo_producto = " + txtCodigoProducto.Text + " "
                    + "WHERE Codigo_compra = " + txtCodigoCompra.Text, cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtCodigoCompra.Clear();
                txtFechaCompra.Clear();
                txtTotalCompra.Clear();
                txtDni.Clear();
                txtCodigoProducto.Clear();

                MessageBox.Show("La compra ha sido modificada exitosamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM compra WHERE Codigo_compra = " + txtCodigoCompra.Text, cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtCodigoCompra.Clear();
                txtFechaCompra.Clear();
                txtTotalCompra.Clear();
                txtDni.Clear();
                txtCodigoProducto.Clear();

                MessageBox.Show("La compra ha sido eliminada exitosamente.");
            }
        }
    }
}
