using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOTUTI
{
    public partial class FrmPedidos : Form
    {
        BaseDeDatos conSQL = new BaseDeDatos();
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = conSQL.retornaRegistros("Select * from Pedidos");
            cargarProveedores();
            cargarProductos();
            cmbProducto.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            int nuevoID = obtenerMaximoID("Pedidos", "IdPedido") + 1;
            txtNumPedido.Text = nuevoID.ToString();
            txtNumPedido.Enabled = false;
            CalcularSubtotal();
            lblTextoTotal.Text = "$0.00";
        }
 
        public int obtenerMaximoID(string tabla, string campoID)
        {
            DataTable dt = conSQL.retornaRegistros($"SELECT MAX({campoID}) FROM {tabla}");
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(dt.Rows[0][0]);
            return 0;
        }

        private void cargarProveedores()
        {
            string consulta = "SELECT Nombre FROM Proveedores1";
            DataTable dt = conSQL.retornaRegistros(consulta);

            cmbProveedor.DataSource = dt;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Nombre";
        }
        private void cargarProductos()
        {
            string consulta = "SELECT NombreProducto FROM Productos";
            DataTable dt = conSQL.retornaRegistros(consulta);
            cmbProducto.DataSource = dt;
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "NombreProducto";
        }

        private void tlsRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Selecciona un pedido para registrar.");
                    return;
                }

                int idPedidoSeleccionado = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["IdPedido"].Value);
                string consultaPedido = "SELECT * FROM Pedidos WHERE IdPedido = " + idPedidoSeleccionado;
                DataTable pedido = conSQL.retornaRegistros(consultaPedido);

                DataGridViewRow filaSeleccionada = dgvPedidos.SelectedRows[0];
                if (filaSeleccionada.Cells["Proveedor"].Value == null || filaSeleccionada.Cells["Producto"].Value == null)
                {
                    MessageBox.Show("Por favor, selecciona un pedido válido.");
                    return;
                }
                int idPedido = Convert.ToInt32(filaSeleccionada.Cells["IdPedido"].Value);
                string proveedor = filaSeleccionada.Cells["Proveedor"].Value.ToString();
                string producto = filaSeleccionada.Cells["Producto"].Value.ToString();
                int cantidad = Convert.ToInt32(filaSeleccionada.Cells["NuevaCant"].Value);
                decimal precioUnitario = Convert.ToDecimal(filaSeleccionada.Cells["PrecioUnitario"].Value);
                decimal subtotal = cantidad * precioUnitario;
                DateTime fechaHora = DateTime.Now;

                string consultaActualizarStock = "UPDATE Productos SET EnStock = EnStock + " + cantidad +
                " WHERE NombreProducto = '" + producto + "'";
                conSQL.ejecutarComando(consultaActualizarStock);

                string mensaje = conSQL.RegistrarHistorialPedido(proveedor, producto, cantidad, fechaHora, idPedido, precioUnitario, subtotal);
                MessageBox.Show(mensaje);

                string consultaEliminar = "DELETE FROM Pedidos WHERE IdPedido = " + idPedidoSeleccionado;
                conSQL.ejecutarComando(consultaEliminar);

                dgvPedidos.DataSource = conSQL.retornaRegistros("SELECT * FROM Pedidos");
                conSQL.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el pedido: " + ex.Message);
            }
        }

        private void tlsAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex == -1 || cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona un proveedor y un producto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNuevaCant.Text) || string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                MessageBox.Show("Por favor ingresa la cantidad y el precio unitario.");
                return;
            }

            if (!int.TryParse(txtNuevaCant.Text, out int nuevaCant) || nuevaCant <= 0)
            {
                MessageBox.Show("Cantidad inválida. Debe ser un número entero positivo.");
                return;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario) || precioUnitario <= 0)
            {
                MessageBox.Show("Precio unitario inválido. Debe ser un número positivo.");
                return;
            }

            string proveedor = cmbProveedor.Text;
            string producto = cmbProducto.Text;
            string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");
            string horaActual = DateTime.Now.ToString("HH:mm:ss");
            decimal subtotal = nuevaCant * precioUnitario;

            string mensaje = conSQL.AgregarPedido(proveedor, producto, nuevaCant, fechaActual, horaActual, precioUnitario, subtotal);
            MessageBox.Show(mensaje);

            dgvPedidos.DataSource = conSQL.retornaRegistros("SELECT * FROM Pedidos");

            CalcularSubtotal();

            LimpiarCampos();

            int nuevoID = obtenerMaximoID("Pedidos", "IdPedido") + 1;
            txtNumPedido.Text = nuevoID.ToString();
        }

        private void tlsVerPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidosRegistrados ventana = new FrmPedidosRegistrados();
            ventana.ShowDialog();
        }

        private void btnNuevProd_Click(object sender, EventArgs e)
        {
            FrmAgregarProduc nuevoProducto = new FrmAgregarProduc(1);
            nuevoProducto.txtbxStock.Text = "0";
            nuevoProducto.txtbxStock.Enabled = false;
            nuevoProducto.ShowDialog();
            cargarProductos();
        }

        private void btnNuevProv_Click(object sender, EventArgs e)
        {
            FrmProveedores nuevoProveedor = new FrmProveedores();
            nuevoProveedor.ShowDialog();
            cargarProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor selecciona un pedido para eliminar.");
                    return;
                }

                string idPedido = dgvPedidos.SelectedRows[0].Cells["IdPedido"].Value.ToString();

                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este pedido?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    string eliminarPedido = "DELETE FROM Pedidos WHERE IdPedido = '" + idPedido + "'";
                    conSQL.ejecutarComando(eliminarPedido);

                    dgvPedidos.DataSource = conSQL.retornaRegistros("SELECT * FROM Pedidos");

                    MessageBox.Show("Pedido eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {

                txtNumPedido.Text = dgvPedidos[0, dgvPedidos.CurrentRow.Index].Value.ToString();
                cmbProveedor.Text = dgvPedidos[1, dgvPedidos.CurrentRow.Index].Value.ToString();
                cmbProducto.Text = dgvPedidos[2, dgvPedidos.CurrentRow.Index].Value.ToString();
                txtNuevaCant.Text = dgvPedidos[3, dgvPedidos.CurrentRow.Index].Value.ToString();
                txtPrecioUnitario.Text = dgvPedidos[6, dgvPedidos.CurrentRow.Index].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selecciona un pedido para editar");
                return;
            }
            btnGuardar.Visible = true;
        }
        private decimal CalcularSubtotal()
        {
            if (string.IsNullOrWhiteSpace(txtNuevaCant.Text) || string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                lblTextoTotal.Text = "$0.00";
                return 0;
            }

            if (!int.TryParse(txtNuevaCant.Text, out int nuevaCant))
            {
                lblTextoTotal.Text = "$0.00";
                return 0;
            }

            if (!decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario))
            {
                lblTextoTotal.Text = "$0.00";
                return 0;
            }

            decimal subtotal = nuevaCant * precioUnitario;
            lblTextoTotal.Text = subtotal.ToString("C2"); // Muestra $ con dos decimales

            return subtotal;
        }
        private void LimpiarCampos()
        {
            txtNuevaCant.Clear();
            txtPrecioUnitario.Clear();
            cmbProducto.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            lblTextoTotal.Text = "$0.00";
        }

        private void txtNuevaCant_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }
        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularSubtotal();
        }

        private void btnGenerarFact_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("NuevaCant", typeof(int));
            dt.Columns.Add("PrecioUnitario", typeof(decimal));
            dt.Columns.Add("SubTotal", typeof(decimal));
            string proveedor = dgvPedidos.CurrentRow.Cells[1].Value.ToString();

            foreach (DataGridViewRow row in dgvPedidos.Rows)
            {
                if (row.Cells["Producto"].Value != null)
                {
                    dt.Rows.Add(
                        row.Cells["Producto"].Value.ToString(),
                        Convert.ToInt32(row.Cells["NuevaCant"].Value),
                        Convert.ToDecimal(row.Cells["PrecioUnitario"].Value),
                        Convert.ToDecimal(row.Cells["SubTotal"].Value)
                    );
                }
            }

            decimal subtotal = CalcularTotalCompra();
            decimal iva = subtotal * 0.15m;
            decimal totalAPagar = subtotal + iva;

            frmFacturaCompra frmFactura = new frmFacturaCompra();
            frmFactura.GenerarFacturaProv(
                GenerarNumeroFactura(),
                DateTime.Now.ToString("dd/MM/yyyy"),
                proveedor,
                dt, subtotal, iva, totalAPagar);

            frmFactura.Show();
        }
        private decimal CalcularTotalCompra()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow fila in dgvPedidos.Rows)
            {
                if (fila.Cells["SubTotal"].Value != null)
                {
                    subtotal += Convert.ToDecimal(fila.Cells["SubTotal"].Value);
                }
            }

            return subtotal;
        }


        private int secuencial = 1;

        public string GenerarNumeroFactura()
        {
            string establecimiento = "001";
            string puntoEmision = "001";

            string secuencialStr = secuencial.ToString().PadLeft(9, '0');

            string numeroFactura = $"{establecimiento}-{puntoEmision}-{secuencialStr}";

            secuencial++;

            return numeroFactura;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string precioUnitario = txtPrecioUnitario.Text.Replace(",", ".");
                string subTotal = lblTextoTotal.Text.Replace(",", ".");
                string idPedido = dgvPedidos.SelectedRows[0].Cells["IdPedido"].Value.ToString();
                string cadena = "Proveedor='" + cmbProveedor.Text +
                    "',Producto='" + cmbProducto.Text +
                    "',NuevaCant=" + txtNuevaCant.Text +
                    ",PrecioUnitario=" + precioUnitario +
                    ",SubTotal=" + subTotal;

                conSQL.actualizarDatos("Pedidos", cadena, "IdPedido=" + idPedido);
                conSQL.cerrarConexion();

                MessageBox.Show("Pedido editado correctamente");
                LimpiarCampos();

                dgvPedidos.DataSource = conSQL.retornaRegistros("select * from Pedidos");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al editar el pedido: " + ex.Message);
            }
        }
    }
}
