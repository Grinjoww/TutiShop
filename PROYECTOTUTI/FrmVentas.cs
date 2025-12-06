using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROYECTOTUTI.FrmVentas;

namespace PROYECTOTUTI
{
    public partial class FrmVentas : Form
    {
        public class Promocion
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public List<string> Subcategorias { get; set; } = new List<string>();
            public string Tipo { get; set; }
            public decimal Descuento { get; set; }
            public string DiasPromocion { get; set; }
            public DateTime? FechaInicio { get; set; }
            public DateTime? FechaFin { get; set; }
            public bool Activa { get; set; }
            public bool Acumulable { get; set; }
        }

        private List<Promocion> promociones = new List<Promocion>();
        private List<Promocion> promocionesAplicadas = new List<Promocion>();
        public FrmVentas()
        {
            InitializeComponent();
        }
        private void CargarPromociones()
        {
            string query = "SELECT * FROM Promociones WHERE Activa = 1";

            using (SqlConnection oCon = new SqlConnection("server= DESKTOP-95KD8UJ\\SQLEXPRESS02; database = TutiShop ; INTEGRATED SECURITY = true;"))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    promociones.Add(new Promocion
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Subcategorias = reader["Subcategorias"].ToString().Split(',').ToList(),
                        Tipo = reader["Tipo"].ToString(),
                        Descuento = Convert.ToDecimal(reader["Descuento"])
                    });
                }
            }
        }
        private void CargarPromocionesActivas()
        {
            promociones.Clear();
            string query = @"SELECT * FROM Promociones 
                           WHERE Activa = 1 
                           AND (FechaInicio IS NULL OR FechaInicio <= GETDATE()) 
                           AND (FechaFin IS NULL OR FechaFin >= GETDATE())";

            using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02;database=TutiShop;INTEGRATED SECURITY=true;"))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    promociones.Add(new Promocion
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Subcategorias = reader["Subcategorias"].ToString().Split(',').ToList(),
                        Tipo = reader["Tipo"].ToString(),
                        Descuento = Convert.ToDecimal(reader["Descuento"]),
                        DiasPromocion = reader["DiasPromocion"].ToString(),
                        FechaInicio = reader["FechaInicio"] as DateTime?,
                        FechaFin = reader["FechaFin"] as DateTime?,
                        Activa = Convert.ToBoolean(reader["Activa"]),
                        Acumulable = Convert.ToBoolean(reader["Acumulable"])
                    });
                }
            }
        }
        private void CargarClientes()
        {
            string query = "SELECT Nombre FROM Clientes";
            using (SqlConnection oCon = new SqlConnection("server= DESKTOP-95KD8UJ\\SQLEXPRESS02 ; database = TutiShop ; INTEGRATED SECURITY = true;"))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                SqlDataReader reader = cmd.ExecuteReader();
                AutoCompleteStringCollection clientes = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    clientes.Add(reader["Nombre"].ToString());
                }
                txtCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtCliente.AutoCompleteCustomSource = clientes;
                oCon.Close();
            }
        }
        private void CargarSucursales()
        {
            cmbSucursal.Items.Clear();

            string query = "SELECT IDSucursal, NombreSucursal FROM IdentSucursales";
            using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbSucursal.Items.Add(reader["NombreSucursal"].ToString());
                }
                oCon.Close();
            }
        }
        private int ObtenerIDSucursal()
        {
            if (cmbSucursal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una sucursal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }

            string nombreSucursal = cmbSucursal.SelectedItem.ToString();
            int idSucursal = 0;

            string query = "SELECT IDSucursal FROM IdentSucursales WHERE NombreSucursal = @nombre";
            using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                cmd.Parameters.AddWithValue("@nombre", nombreSucursal);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idSucursal = Convert.ToInt32(result);
                }
                oCon.Close();
            }
            return idSucursal;
        }
        private int ObtenerIDProducto(string nombreProducto)
        {
            int idSucursal = ObtenerIDSucursal();
            if (idSucursal == 0) return 0;

            int idProducto = 0;
            string query = "SELECT Codigo FROM Productos WHERE NombreProducto = @nombre AND IDSucursal = @idSucursal";

            using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                cmd.Parameters.AddWithValue("@nombre", nombreProducto);
                cmd.Parameters.AddWithValue("@idSucursal", idSucursal);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idProducto = Convert.ToInt32(result);
                }
                oCon.Close();
            }
            return idProducto;
        }

        private decimal ObtenerPrecioProducto(int idProducto)
        {
            try
            {
                string query = "SELECT PrecioUnitario FROM Productos WHERE Codigo = @id";
                using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
                {
                    oCon.Open();
                    using (SqlCommand cmd = new SqlCommand(query, oCon))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el precio del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private decimal ObtenerDescuentoProducto(int idProducto)
        {
            try
            {
                string query = "SELECT Descuento FROM Productos WHERE Codigo = @id";
                using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
                {
                    oCon.Open();
                    using (SqlCommand cmd = new SqlCommand(query, oCon))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            decimal descuento = Convert.ToDecimal(result);
                            return descuento / 100;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el descuento del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        private string ObtenerSubcategoriaProducto(string nombreProducto)
        {
            string subcategoria = "";
            string query = "SELECT Subcategoria FROM Productos WHERE NombreProducto = @nombre";

            using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                cmd.Parameters.AddWithValue("@nombre", nombreProducto);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    subcategoria = result.ToString();
                }
                oCon.Close();
            }
            return subcategoria;
        }
        private List<string> ObtenerSubcategoriasEnVenta()
        {
            var subcategorias = new List<string>();
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["NombreProducto"].Value != null)
                {
                    string subcategoria = ObtenerSubcategoriaProducto(row.Cells["NombreProducto"].Value.ToString());
                    if (!string.IsNullOrEmpty(subcategoria))
                        subcategorias.Add(subcategoria);
                }
            }
            return subcategorias.Distinct().ToList();
        }
        private int ObtenerStockProducto(int idProducto)
        {
            try
            {
                string query = "SELECT EnStock FROM Productos WHERE Codigo = @id";
                using (SqlConnection oCon = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
                {
                    oCon.Open();
                    using (SqlCommand cmd = new SqlCommand(query, oCon))
                    {
                        cmd.Parameters.AddWithValue("@id", idProducto);
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el stock del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void AplicarPromociones()
        {
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            promocionesAplicadas.Clear();
            var subcategoriasEnVenta = ObtenerSubcategoriasEnVenta();
            bool seAplicoAlgunaPromocion = false;

            foreach (var promocion in promociones)
            {
                if (!PromocionValidaParaHoy(promocion)) continue;

                if (promocion.Tipo == "DiaEspecial")
                {
                    AplicarPromocionDiaEspecial(promocion);
                    seAplicoAlgunaPromocion = true;
                }
                else if (promocion.Subcategorias.All(sub => subcategoriasEnVenta.Contains(sub)))
                {
                    switch (promocion.Tipo)
                    {
                        case "2x1":
                            AplicarPromocion2x1(promocion);
                            seAplicoAlgunaPromocion = true;
                            break;
                        case "Descuento":
                            AplicarPromocionDescuento(promocion);
                            seAplicoAlgunaPromocion = true;
                            break;
                        case "Combo":
                            AplicarPromocionCombo(promocion);
                            seAplicoAlgunaPromocion = true;
                            break;
                    }
                }
            }

            if (!seAplicoAlgunaPromocion)
            {
                MessageBox.Show("No se pudo aplicar ninguna promoción a los productos seleccionados.", "Promociones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MostrarPromocionesAplicadas();
            }

            CalcularTotalPagar();
        }

        private bool PromocionValidaParaHoy(Promocion promocion)
        {
            if (string.IsNullOrEmpty(promocion.DiasPromocion))
                return true;

            string diaActual = DateTime.Now.DayOfWeek.ToString();
            return promocion.DiasPromocion.Split(',').Select(d => d.Trim().ToLower()).Contains(diaActual.ToLower());
        }

        private void AplicarPromocionDiaEspecial(Promocion promocion)
        {
            decimal descuentoAAplicar = promocion.Descuento * 100;
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["NombreProducto"].Value == null) continue;

                decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal descuentoActual = Convert.ToDecimal(row.Cells["Descuento"].Value);
                decimal nuevoDescuento = Math.Min(promocion.Acumulable ? descuentoActual + descuentoAAplicar : descuentoAAplicar, 100);
                row.Cells["Descuento"].Value = nuevoDescuento;
                row.Cells["Total"].Value = Math.Round(precio * cantidad * (1 - (nuevoDescuento / 100)), 2);
                row.Cells["PromocionAplicada"].Value = promocion.Nombre;
            }
            promocionesAplicadas.Add(promocion);
            lblMensajePromo.Text = $"{promocion.Nombre} ({descuentoAAplicar}% OFF)";
        }

        private void AplicarPromocion2x1(Promocion promocion)
        {
            string subcategoria = promocion.Subcategorias[0];

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["NombreProducto"].Value != null)
                {
                    string nombreProducto = row.Cells["NombreProducto"].Value.ToString();
                    string subcategoriaProducto = ObtenerSubcategoriaProducto(nombreProducto);

                    if (subcategoriaProducto == subcategoria)
                    {
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        if (cantidad >= 2)
                        {
                            decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                            int pares = cantidad / 2;
                            int individuales = cantidad % 2;
                            decimal totalFila = (pares * precioUnitario) + (individuales * precioUnitario);
                            decimal descuentoEquivalente = 0.50m * 100;

                            row.Cells["Descuento"].Value = descuentoEquivalente;
                            row.Cells["Total"].Value = totalFila;
                            row.Cells["PromocionAplicada"].Value = $"2x1 - {promocion.Nombre}";
                        }
                    }
                }
            }
            promocionesAplicadas.Add(promocion);
        }
        private void AplicarPromocionDescuento(Promocion promocion)
        {
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["NombreProducto"].Value != null)
                {
                    string nombreProducto = row.Cells["NombreProducto"].Value.ToString();
                    string subcategoriaProducto = ObtenerSubcategoriaProducto(nombreProducto);

                    if (promocion.Subcategorias.Contains(subcategoriaProducto))
                    {
                        decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal descuentoActual = Convert.ToDecimal(row.Cells["Descuento"].Value);
                        decimal descuentoMostrar = promocion.Descuento * 100;
                        decimal nuevoDescuento = promocion.Acumulable ? descuentoActual + descuentoMostrar : descuentoMostrar;
                        row.Cells["Descuento"].Value = nuevoDescuento;
                        row.Cells["Total"].Value = precio * cantidad * (1 - (nuevoDescuento / 100));
                        row.Cells["PromocionAplicada"].Value = $"Descuento - {promocion.Nombre}";
                    }
                }
            }
            promocionesAplicadas.Add(promocion);
        }
        private void AplicarPromocionCombo(Promocion promocion)
        {
            bool todosPresentes = promocion.Subcategorias.All(sub =>
                dgvVentas.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells["NombreProducto"].Value != null &&
                         ObtenerSubcategoriaProducto(row.Cells["NombreProducto"].Value.ToString()) == sub));

            if (!todosPresentes) return;

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["NombreProducto"].Value != null)
                {
                    string nombreProducto = row.Cells["NombreProducto"].Value.ToString();
                    string subcategoriaProducto = ObtenerSubcategoriaProducto(nombreProducto);

                    if (promocion.Subcategorias.Contains(subcategoriaProducto))
                    {
                        decimal precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal descuentoActual = Convert.ToDecimal(row.Cells["Descuento"].Value);
                        decimal descuentoMostrar = promocion.Descuento * 100;
                        decimal nuevoDescuento = promocion.Acumulable ? descuentoActual + descuentoMostrar : descuentoMostrar;
                        row.Cells["Descuento"].Value = nuevoDescuento;
                        row.Cells["Total"].Value = precio * cantidad * (1 - (nuevoDescuento / 100));
                        row.Cells["PromocionAplicada"].Value = $"Combo - {promocion.Nombre}";
                    }
                }
            }
            promocionesAplicadas.Add(promocion);
        }
        private void MostrarPromocionesAplicadas()
        {
            if (promocionesAplicadas.Count > 0)
            {
                string mensaje = "Promociones aplicadas:\n" +
                    string.Join("\n", promocionesAplicadas.Select(p => $"- {p.Nombre} ({p.Tipo} - {p.Descuento * 100}%)"));
                MessageBox.Show(mensaje, "Promociones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, selecciona un producto y una cantidad.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad ingresada no es válida.");
                return;
            }

            string producto = txtProducto.Text;
            int idProducto = ObtenerIDProducto(producto);
            decimal precio = ObtenerPrecioProducto(idProducto);
            decimal descuentoProducto = ObtenerDescuentoProducto(idProducto);
            int stockDisponible = ObtenerStockProducto(idProducto);

            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"No hay suficiente stock para {producto}. Stock disponible: {stockDisponible}");
                return;
            }
            decimal precioConDescuento = precio - (precio * descuentoProducto);
            decimal totalFila = precioConDescuento * cantidad;
            if (totalFila < 0)
            {
                MessageBox.Show("Error: El total no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvVentas.Rows.Add(
            idProducto,
            producto,
            cantidad,
            Math.Round(precio, 2),
            Math.Round(descuentoProducto * 100, 2),
            "",
            Math.Round(totalFila, 2)
            );
            dgvVentas.Columns["PrecioUnitario"].DefaultCellStyle.Format = "N2";
            dgvVentas.Columns["Descuento"].DefaultCellStyle.Format = "N2";
            dgvVentas.Columns["Total"].DefaultCellStyle.Format = "N2";

            CalcularTotalPagar();

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.");
                return;
            }

            string cadenaConexion = "server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;";
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                decimal precioTotalVenta = 0;
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    if (row.Cells["IDProducto"].Value == null || row.Cells["Cantidad"].Value == null || row.Cells["PrecioUnitario"].Value == null)
                    {
                        MessageBox.Show("Hay celdas vacías en la lista de productos. Por favor, revise los datos.");
                        return;
                    }

                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    precioTotalVenta += cantidad * precioUnitario;
                }
                string insertVenta = @"INSERT INTO VentasShop (FechaVenta, PrecioTotal) OUTPUT INSERTED.IDVenta VALUES (@Fecha, @Precio)";
                int idVenta;

                using (SqlCommand comandoVenta = new SqlCommand(insertVenta, conexion))
                {
                    comandoVenta.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    comandoVenta.Parameters.AddWithValue("@Precio", precioTotalVenta);
                    idVenta = (int)comandoVenta.ExecuteScalar();
                }
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    int idProducto = Convert.ToInt32(row.Cells["IDProducto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);

                    string insertDetalle = @"INSERT INTO DetalleVenta (IDVenta, IDProducto, Cantidad, PrecioUnitario) VALUES (@Venta, @Prod, @Cant, @Precio)";

                    using (SqlCommand cmdDetalle = new SqlCommand(insertDetalle, conexion))
                    {
                        cmdDetalle.Parameters.AddWithValue("@Venta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@Prod", idProducto);
                        cmdDetalle.Parameters.AddWithValue("@Cant", cantidad);
                        cmdDetalle.Parameters.AddWithValue("@Precio", precioUnitario);
                        cmdDetalle.ExecuteNonQuery();
                    }
                    string actualizarStock = @"UPDATE Productos SET EnStock = EnStock - @Cant WHERE Codigo = @Prod";

                    using (SqlCommand cmdStock = new SqlCommand(actualizarStock, conexion))
                    {
                        cmdStock.Parameters.AddWithValue("@Cant", cantidad);
                        cmdStock.Parameters.AddWithValue("@Prod", idProducto);
                        cmdStock.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                decimal totalAPagar = CalcularTotalPagar(); ;
                FrmPago frmPago = new FrmPago();
                frmPago.TotalAPagar = totalAPagar;
                frmPago.ShowDialog();
            }
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarSucursales();
            CargarPromocionesActivas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                dgvVentas.Rows.RemoveAt(dgvVentas.SelectedRows[0].Index);
                CalcularTotalPagar();
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarVentas_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvVentas.SelectedRows[0];

                FrmCajaEntrada inputBox = new FrmCajaEntrada(
                    "Ingrese la nueva cantidad:",
                    "Ingrese el nuevo descuento:",
                    "Editar Producto",
                    fila.Cells["Cantidad"].Value.ToString(),
                    fila.Cells["Descuento"].Value.ToString()
                );

                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(inputBox.Cantidad, out int nuevaCantidad) && nuevaCantidad > 0)
                    {
                        if (decimal.TryParse(inputBox.Descuento, out decimal nuevoDescuento) && nuevoDescuento >= 0)
                        {
                            fila.Cells["Cantidad"].Value = nuevaCantidad;
                            fila.Cells["Descuento"].Value = nuevoDescuento;

                            decimal precio = Convert.ToDecimal(fila.Cells["PrecioUnitario"].Value);
                            decimal totalSinDescuento = nuevaCantidad * precio;
                            decimal totalConDescuento = totalSinDescuento - (totalSinDescuento * (nuevoDescuento / 100));

                            fila.Cells["Total"].Value = totalConDescuento;

                            CalcularTotalPagar();
                        }
                        else
                        {
                            MessageBox.Show("Descuento inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtProducto.Clear();
            txtCantidad.Clear();
            dgvVentas.Rows.Clear();
            CalcularTotalPagar();
        }

        private void txtProducto_Click(object sender, EventArgs e)
        {
            int idSucursal = ObtenerIDSucursal();
            if (idSucursal == 0)
            {
                MessageBox.Show("Por favor, selecciona una sucursal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBuscadorInventario buscador = new FrmBuscadorInventario();
            buscador.IDSucursalSeleccionada = idSucursal;

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                txtProducto.Text = buscador.ProductoSeleccionado;
                txtCantidad.Focus();
            }
        }
        private decimal CalcularTotalPagar()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                if (fila.Cells["Total"].Value != null)
                {
                    subtotal += Convert.ToDecimal(fila.Cells["Total"].Value);
                }
            }

            decimal iva = subtotal * 0.15m;
            decimal total = subtotal + iva;

            lblTotaldePago.Text = subtotal.ToString("C2");
            lblValorIva.Text = iva.ToString("C2");
            lblTotalPagar.Text = total.ToString("C2");

            return total;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string ObtenerPuntoVenta(string nombresucursal)
        {
            switch (nombresucursal)
            {
                case "S. Centro":
                    return "002"; 
                case "S. Norte":
                    return "003"; 
                default:
                    return "001"; 
            }
        }
        private string GenerarNumeroFactura(string puntoVenta, int numeroFactura)
        {
        
            string establecimiento = "001"; 
            string puntoEmision = puntoVenta.PadLeft(3, '0'); 
            string secuencial = numeroFactura.ToString("D9"); 

            return $"{establecimiento}-{puntoEmision}-{secuencial}";
        }
        private DataTable ObtenerDatosFactura(DataGridView dgv)
        {
            var dt = new DataTable();
            dt.Columns.Add("NombreProducto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("PrecioUnitario", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["NombreProducto"].Value != null)
                {
                    try
                    {
                        string nombreProducto = row.Cells["NombreProducto"].Value.ToString();
                        int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                        decimal descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                        decimal total = Convert.ToDecimal(row.Cells["Total"].Value);
                        dt.Rows.Add(nombreProducto, cantidad, precioUnitario, descuento, total);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return dt;
        }

        private int ObtenerSiguienteNumeroFactura()
        {
            int siguienteNumero = 0;
            string cadenaConexion = "server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT UltimoNumero FROM UltimoNumeroFactura WHERE ID = 1";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        siguienteNumero = Convert.ToInt32(result) + 1;
                    }
                }
                string updateQuery = "UPDATE UltimoNumeroFactura SET UltimoNumero = @siguienteNumero WHERE ID = 1";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conexion))
                {
                    updateCmd.Parameters.AddWithValue("@siguienteNumero", siguienteNumero);
                    updateCmd.ExecuteNonQuery();
                }
            }

            return siguienteNumero;
        }
        
        private void btnFactura_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvVentas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos para facturar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var culture = new CultureInfo("es-EC");
                culture.NumberFormat.CurrencySymbol = "$";
                string nombreSucursal = cmbSucursal.SelectedItem?.ToString() ?? "No seleccionada";
                string numeroFacturaCompleto = GenerarNumeroFactura(ObtenerPuntoVenta(nombreSucursal), ObtenerSiguienteNumeroFactura());
                DataTable dtFactura = ObtenerDatosFactura(dgvVentas);
                decimal subtotal = decimal.Parse(lblTotaldePago.Text, NumberStyles.Currency, culture);
                decimal iva = decimal.Parse(lblValorIva.Text, NumberStyles.Currency, culture);
                decimal totalAPagar = decimal.Parse(lblTotalPagar.Text, NumberStyles.Currency, culture);
                string direccionCliente = "";
                string cedulaCliente = "";
                string emailCliente = ""; 

                if (!string.IsNullOrEmpty(txtCliente.Text))
                {
                    string query = "SELECT Cedula, Direccion, Email FROM Clientes WHERE Nombre = @nombre"; 
                    using (SqlConnection conn = new SqlConnection("server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;"))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@nombre", txtCliente.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cedulaCliente = reader["Cedula"].ToString();
                                direccionCliente = reader["Direccion"].ToString();
                                emailCliente = reader["Email"]?.ToString() ?? "No especificado";
                            }
                        }
                    }
                }
                using (FrmPago frmPago = new FrmPago())
                {
                    frmPago.TotalAPagar = totalAPagar;
                    var result = frmPago.ShowDialog();

                    if (result == DialogResult.OK)
                    {
  
                        FrmFactura frmFactura = new FrmFactura();
                        frmFactura.CargarFactura(
                            numeroFacturaCompleto,
                            DateTime.Now.ToString("dd/MM/yyyy"),
                            txtCliente.Text,
                            nombreSucursal,
                            dtFactura,
                            subtotal,
                            iva,
                            totalAPagar,
                            frmPago.MetodoPago ?? "EFECTIVO",
                            direccionCliente,
                            cedulaCliente,
                            emailCliente 
                        );
                        frmFactura.Show();
                    }
                    else
                    {
                        MessageBox.Show("La factura no se generó porque no se completó el pago", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar factura: {ex.Message}\n\nDetalle técnico:\n{ex.StackTrace}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        
        
        private void btnAplicarPromocion2_Click(object sender, EventArgs e)
        {
            AplicarPromociones();
        }

        private void btnAdministrarPromociones_Click(object sender, EventArgs e)
        {
            FrmPromociones frm = new FrmPromociones();
            frm.ShowDialog();
            promociones.Clear();
            CargarPromociones();
        }

        private void btnTraslados_Click(object sender, EventArgs e)
        {
            FrmTraslados frmtraslados = new FrmTraslados();
            frmtraslados.ShowDialog();
        }
    }
}
