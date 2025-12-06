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
    public partial class FrmTraslados : Form
    {
        SqlConnection oCon = BaseDeDatos.ObtenerConexion();
        BaseDeDatos conSQL = new BaseDeDatos();
        private System.Windows.Forms.Timer timerTraslados;

        public FrmTraslados()
        {
            InitializeComponent();
            CargarSucursales();
            InicializarTimer();
        }

        private void InicializarTimer()
        {
            timerTraslados = new System.Windows.Forms.Timer();
            timerTraslados.Interval = 5000; 
            timerTraslados.Tick += TimerTraslados_Tick;
            timerTraslados.Start();
        }

        private void TimerTraslados_Tick(object sender, EventArgs e)
        {
            VerificarTrasladosCompletados();
        }

        private void CargarSucursales()
        {
            try
            {
                using (DataTable sucursales = conSQL.retornaRegistros("SELECT IdSucursal, NombreSucursal FROM IdentSucursales"))
                {
                    cmbbxOrigen.DataSource = sucursales.Copy();
                    cmbbxOrigen.DisplayMember = "NombreSucursal";
                    cmbbxOrigen.ValueMember = "IdSucursal";

                    cmbbxDestino.DataSource = sucursales.Copy();
                    cmbbxDestino.DisplayMember = "NombreSucursal";
                    cmbbxDestino.ValueMember = "IdSucursal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar sucursales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbbxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxOrigen.SelectedValue != null && cmbbxOrigen.SelectedValue is int)
            {
                int idSucursalOrigen = (int)cmbbxOrigen.SelectedValue;
                string query = $@"SELECT p.*, s.NombreSucursal 
                                FROM Productos p 
                                INNER JOIN IdentSucursales s ON p.IDSucursal = s.IdSucursal 
                                WHERE p.IDSucursal = {idSucursalOrigen} AND p.EnStock > 0";

                using (DataTable prendas = conSQL.retornaRegistros(query))
                {
                    dgvDisponibles.DataSource = prendas;
                }
            }
        }

        private void cmbbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxDestino.SelectedValue != null && cmbbxDestino.SelectedValue is int)
            {
                int idSucursalDestino = (int)cmbbxDestino.SelectedValue;
                string query = $@"SELECT p.*, s.NombreSucursal 
                                FROM Productos p 
                                INNER JOIN IdentSucursales s ON p.IDSucursal = s.IdSucursal 
                                WHERE p.IDSucursal = {idSucursalDestino}";

                using (DataTable prendasDestino = conSQL.retornaRegistros(query))
                {
                    dgvDestino.DataSource = prendasDestino;
                }
            }
        }

        private void btnTrasladar_Click(object sender, EventArgs e)
        {
            if (dgvDisponibles.SelectedRows.Count == 0 || dgvDisponibles.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("Seleccione un producto para trasladar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtbxCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow selectedRow = dgvDisponibles.SelectedRows[0];
            int idProducto = Convert.ToInt32(selectedRow.Cells["Codigo"].Value);
            string nombreProducto = selectedRow.Cells["NombreProducto"].Value?.ToString() ?? "";
            string talla = selectedRow.Cells["Talla"].Value?.ToString() ?? "";
            int stockDisponible = Convert.ToInt32(selectedRow.Cells["EnStock"].Value);

            if (string.IsNullOrWhiteSpace(talla))
            {
                MessageBox.Show("El producto seleccionado no tiene talla definida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("La cantidad seleccionada supera el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idSucursalOrigen = (int)cmbbxOrigen.SelectedValue;
            int idSucursalDestino = (int)cmbbxDestino.SelectedValue;

            Random rnd = new Random();
            int tiempoEstimadoSegundos = rnd.Next(30, 60); 
            DialogResult respuesta = MessageBox.Show(
                $"¿Confirmar traslado de {cantidad} unidad(es) de {nombreProducto} (Talla: {talla}) a {cmbbxDestino.Text}?\n\n" +
                $"El producto estará disponible para venta inmediata.\n" +
                $"Tiempo estimado de llegada física: {tiempoEstimadoSegundos} segundos.",
                "Confirmar traslado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                RegistrarTraslado(idProducto, nombreProducto, talla, cantidad, idSucursalOrigen, idSucursalDestino, tiempoEstimadoSegundos);
            }
        }

        private void RegistrarTraslado(int idProducto, string nombreProducto, string talla, int cantidad, int idSucursalOrigen, int idSucursalDestino, int tiempoEstimadoSegundos)
        {
            try
            {
                conSQL.ejecutarComando(
                    $"UPDATE Productos SET EnStock = EnStock - {cantidad} " +
                    $"WHERE Codigo = {idProducto} AND IDSucursal = {idSucursalOrigen}");

                DataTable productoDestino = conSQL.retornaRegistros(
                    $"SELECT * FROM Productos WHERE Codigo = {idProducto} AND IDSucursal = {idSucursalDestino} AND Talla = '{talla}'");

                if (productoDestino.Rows.Count == 0)
                {

                    DataTable productoOrigen = conSQL.retornaRegistros(
                        $"SELECT TOP 1 * FROM Productos WHERE Codigo = {idProducto}");

                    if (productoOrigen.Rows.Count > 0)
                    {
                        string queryInsert = @"
                        INSERT INTO Productos (
                            Codigo, NombreProducto, Talla, EnStock, PrecioUnitario, 
                            Color, Marca, Categoria, SubCategoria, Descuento, IDSucursal
                        ) VALUES (
                            @Codigo, @Nombre, @Talla, @Cantidad, @Precio,
                            @Color, @Marca, @Categoria, @SubCategoria, @Descuento, @IDSucursal
                        )";

                        using (SqlCommand cmd = new SqlCommand(queryInsert, oCon))
                        {
                            DataRow p = productoOrigen.Rows[0];
                            cmd.Parameters.AddWithValue("@Codigo", idProducto);
                            cmd.Parameters.AddWithValue("@Nombre", p["NombreProducto"]);
                            cmd.Parameters.AddWithValue("@Talla", talla);
                            cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@Precio", p["PrecioUnitario"]);
                            cmd.Parameters.AddWithValue("@Color", p["Color"]);
                            cmd.Parameters.AddWithValue("@Marca", p["Marca"]);
                            cmd.Parameters.AddWithValue("@Categoria", p["Categoria"]);
                            cmd.Parameters.AddWithValue("@SubCategoria", p["SubCategoria"]);
                            cmd.Parameters.AddWithValue("@Descuento", p["Descuento"]);
                            cmd.Parameters.AddWithValue("@IDSucursal", idSucursalDestino);

                            oCon.Open();
                            cmd.ExecuteNonQuery();
                            oCon.Close();
                        }
                    }
                }
                else
                {
                    conSQL.ejecutarComando(
                        $"UPDATE Productos SET EnStock = EnStock + {cantidad} " +
                        $"WHERE Codigo = {idProducto} AND IDSucursal = {idSucursalDestino} AND Talla = '{talla}'");
                }

                string queryTraslado = @"
                INSERT INTO Traslados (
                    ID_Prenda, Talla, Sucursal_Origen, Sucursal_Destino, 
                    Cantidad, Fecha_Solicitud, Tiempo_Estimado_Minutos, Estado, Notificado
                ) VALUES (
                    @ID_Prenda, @Talla, @Sucursal_Origen, @Sucursal_Destino, 
                    @Cantidad, GETDATE(), @Tiempo_Estimado, 'EnCamino', 0
                )";

                using (SqlCommand cmd = new SqlCommand(queryTraslado, oCon))
                {
                    cmd.Parameters.AddWithValue("@ID_Prenda", idProducto);
                    cmd.Parameters.AddWithValue("@Talla", talla);
                    cmd.Parameters.AddWithValue("@Sucursal_Origen", idSucursalOrigen);
                    cmd.Parameters.AddWithValue("@Sucursal_Destino", idSucursalDestino);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Tiempo_Estimado", tiempoEstimadoSegundos);

                    oCon.Open();
                    cmd.ExecuteNonQuery();
                    oCon.Close();
                }

                MessageBox.Show($"¡Producto disponible para venta!\n\n" +
                              $"{nombreProducto} (Talla: {talla}) ya aparece en el inventario de {cmbbxDestino.Text}\n" +
                              $"El traslado físico se completará en aproximadamente {tiempoEstimadoSegundos} segundos.",
                              "Traslado registrado",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                ActualizarListas();
                CargarTrasladosPendientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el traslado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarTrasladosCompletados()
        {
            try
            {

                conSQL.ejecutarComando(
                    @"UPDATE Traslados 
                    SET Estado = 'Completado', 
                        Fecha_Real_Llegada = GETDATE()
                    WHERE Estado = 'EnCamino' 
                    AND DATEADD(SECOND, Tiempo_Estimado_Minutos, Fecha_Solicitud) <= GETDATE()
                    AND Notificado = 0");

                DataTable trasladosNuevos = conSQL.retornaRegistros(
                    @"SELECT t.ID_Traslado, t.ID_Prenda, p.NombreProducto, t.Talla, t.Cantidad,
                             so.NombreSucursal AS Origen, sd.NombreSucursal AS Destino,
                             t.Sucursal_Destino
                      FROM Traslados t
                      INNER JOIN Productos p ON t.ID_Prenda = p.Codigo
                      INNER JOIN IdentSucursales so ON t.Sucursal_Origen = so.IdSucursal
                      INNER JOIN IdentSucursales sd ON t.Sucursal_Destino = sd.IdSucursal
                      WHERE t.Estado = 'Completado' AND t.Notificado = 0");

                foreach (DataRow row in trasladosNuevos.Rows)
                {
                    conSQL.ejecutarComando(
                        $"UPDATE Traslados SET Notificado = 1 WHERE ID_Traslado = {row["ID_Traslado"]}");
                    MessageBox.Show(
                        $"El producto {row["NombreProducto"]} (Talla: {row["Talla"]}) ha llegado físicamente a {row["Destino"]}.",
                        "Llegada confirmada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                CargarTrasladosPendientes();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al verificar traslados: {ex.Message}");
            }
        }

        private void CargarTrasladosPendientes()
        {
            try
            {
                string query = @"SELECT t.ID_Traslado, p.NombreProducto, t.Talla, so.NombreSucursal AS Origen, sd.NombreSucursal AS Destino, t.Cantidad, 
                CASE WHEN t.Estado = 'EnCamino' THEN 'En camino (' + CAST(DATEDIFF(SECOND, GETDATE(), DATEADD(SECOND, t.Tiempo_Estimado_Minutos, t.Fecha_Solicitud)) AS VARCHAR) + 's)'
                WHEN t.Estado = 'Completado' THEN 'Completado' ELSE t.Estado END AS EstadoVisual FROM Traslados t
                INNER JOIN Productos p ON t.ID_Prenda = p.Codigo
                INNER JOIN IdentSucursales so ON t.Sucursal_Origen = so.IdSucursal
                INNER JOIN IdentSucursales sd ON t.Sucursal_Destino = sd.IdSucursal
                ORDER BY t.Fecha_Solicitud DESC";

                using (DataTable traslados = conSQL.retornaRegistros(query))
                {
                    dgvTrasladosRecientes.DataSource = traslados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar traslados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListas()
        {
            cmbbxOrigen_SelectedIndexChanged(null, null);
            cmbbxDestino_SelectedIndexChanged(null, null);
        }

        private void FrmTraslados_Load(object sender, EventArgs e)
        {
            CargarTrasladosPendientes();
        }

        private void dgvTrasladosRecientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
