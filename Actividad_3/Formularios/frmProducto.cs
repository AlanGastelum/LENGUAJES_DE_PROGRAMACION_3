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
    public partial class frmProducto : Form
    {
        public frmProducto()
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
                SqlCommand cmd = new SqlCommand("INSERT INTO producto (Nombre_producto, Precio, Nif) VALUES ('" + txtNombreProducto.Text + "',"
                    + txtPrecio.Text + ","
                    + txtNif.Text + ")", cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Producto agregado correctamente");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM producto", cn);

                da.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                da.Fill(dt);

                dgvProductos.DataSource = dt;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE producto SET "+ "Nombre_producto = '" + txtNombreProducto.Text + "', "
                    + "Precio = " + txtPrecio.Text + ", "
                    + "Nif = " + txtNif.Text + " "
                    + "WHERE Codigo_producto = " + txtCodigoProducto.Text, cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                txtNif.Clear();

                MessageBox.Show("El producto ha sido modificado exitosamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection("Data Source=Alan\\SQLEXPRESS;Initial Catalog=zap_umi;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM producto WHERE Codigo_producto = " + txtCodigoProducto.Text, cn);

                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();

                txtCodigoProducto.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                txtNif.Clear();

                MessageBox.Show("El producto ha sido eliminado exitosamente.");
            }
        }
    }
}
