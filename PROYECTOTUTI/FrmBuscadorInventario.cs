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

namespace PROYECTOTUTI
{
    public partial class FrmBuscadorInventario : Form
    {
        public int IDSucursalSeleccionada { get; set; }
        public FrmBuscadorInventario()
        {
            InitializeComponent();
        }
        public string ProductoSeleccionado { get; set; }

        private void CargarProductos(string nombre, string marca, string color, string talla)
        {

            using (SqlConnection conn = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
            {
                conn.Open();
                string query = "SELECT Codigo, NombreProducto, EnStock, Marca, Color, Talla FROM Productos WHERE 1=1";

                if (IDSucursalSeleccionada > 0)
                {
                    query += " AND IDSucursal = @sucursal";
                }

                if (!string.IsNullOrEmpty(nombre))
                    query += " AND NombreProducto LIKE @nombre";

                if (!string.IsNullOrEmpty(marca))
                    query += " AND Marca LIKE @marca";

                if (!string.IsNullOrEmpty(color))
                    query += " AND Color LIKE @color";

                if (!string.IsNullOrEmpty(talla))
                    query += " AND Talla LIKE @talla";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (IDSucursalSeleccionada > 0)
                    {
                        cmd.Parameters.AddWithValue("@sucursal", IDSucursalSeleccionada);
                    }

                    if (!string.IsNullOrEmpty(nombre))
                        cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");

                    if (!string.IsNullOrEmpty(marca))
                        cmd.Parameters.AddWithValue("@marca", "%" + marca + "%");

                    if (!string.IsNullOrEmpty(color))
                        cmd.Parameters.AddWithValue("@color", "%" + color + "%");

                    if (!string.IsNullOrEmpty(talla))
                        cmd.Parameters.AddWithValue("@talla", "%" + talla + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProductos.DataSource = dt;
                }
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtNombreProducto.Text.Trim(), txtMarca.Text.Trim(), txtColor.Text.Trim(), txtTalla.Text.Trim());

        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtNombreProducto.Text.Trim(), txtMarca.Text.Trim(), txtColor.Text.Trim(), txtTalla.Text.Trim());

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtNombreProducto.Text.Trim(), txtMarca.Text.Trim(), txtColor.Text.Trim(), txtTalla.Text.Trim());

        }

        private void txtTalla_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtNombreProducto.Text.Trim(), txtMarca.Text.Trim(), txtColor.Text.Trim(), txtTalla.Text.Trim());

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                ProductoSeleccionado = dgvProductos.SelectedRows[0].Cells["NombreProducto"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
