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
using static PROYECTOTUTI.FrmVentas;

namespace PROYECTOTUTI
{
    public partial class FrmPromociones : Form
    {
        private List<Promocion> promociones;
        private List<Promocion> todasLasPromociones = new List<Promocion>();
        private string connectionString = "server=DESKTOP-95KD8UJ\\SQLEXPRESS02; database=TutiShop; INTEGRATED SECURITY=true;";

        public FrmPromociones()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarPromociones();
        }
        private void ConfigurarGrid()
        {
            dgvPromociones.AutoGenerateColumns = false;
            dgvPromociones.Columns.Clear();
            DataGridViewCheckBoxColumn colActiva = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Activa",
                DataPropertyName = "Activa",
                Width = 50
            };
            dgvPromociones.Columns.Add(colActiva);
            dgvPromociones.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre", Width = 150 });
            dgvPromociones.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipo", DataPropertyName = "Tipo", Width = 80 });
            dgvPromociones.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descuento (%)", DataPropertyName = "Descuento", Width = 80 });
            dgvPromociones.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vigencia", Width = 120 });
            dgvPromociones.CellFormatting += dgvPromociones_CellFormatting;
        }

        private void dgvPromociones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPromociones.Columns[e.ColumnIndex].Name == "Vigencia" && e.RowIndex >= 0)
            {
                var promocion = (Promocion)dgvPromociones.Rows[e.RowIndex].DataBoundItem;
                e.Value = promocion.FechaInicio == null && promocion.FechaFin == null
                    ? "Siempre"
                    : $"{promocion.FechaInicio?.ToShortDateString()} - {promocion.FechaFin?.ToShortDateString()}";
            }
        }

        private void FiltrarPromociones(string textoBusqueda)
        {
            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                dgvPromociones.DataSource = promociones;
                return;
            }
            var promocionesFiltradas = promociones.Where(p =>
                p.Nombre.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0 ||
                p.Tipo.IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();

            dgvPromociones.DataSource = promocionesFiltradas;
        }
        private void CargarPromociones()
        {
            todasLasPromociones.Clear();
            string query = "SELECT * FROM Promociones";

            using (SqlConnection oCon = new SqlConnection(connectionString))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        todasLasPromociones.Add(new Promocion
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString(),
                            Subcategorias = reader["Subcategorias"].ToString().Split(',').ToList(),
                            Tipo = reader["Tipo"].ToString(),
                            Descuento = Convert.ToDecimal(reader["Descuento"]),
                            Activa = Convert.ToBoolean(reader["Activa"]),
                            FechaInicio = reader["FechaInicio"] == DBNull.Value ? null : (DateTime?)reader["FechaInicio"],
                            FechaFin = reader["FechaFin"] == DBNull.Value ? null : (DateTime?)reader["FechaFin"]
                        });
                    }
                }
            }
            dgvPromociones.DataSource = todasLasPromociones;
        }

        private void GuardarPromocion(Promocion promocion)
        {
            string query = @"INSERT INTO Promociones (Nombre, Subcategorias, Tipo, Descuento, Activa, FechaInicio, FechaFin) 
                             VALUES (@Nombre, @Subcategorias, @Tipo, @Descuento, @Activa, @FechaInicio, @FechaFin)";

            using (SqlConnection oCon = new SqlConnection(connectionString))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                cmd.Parameters.AddWithValue("@Nombre", promocion.Nombre);
                cmd.Parameters.AddWithValue("@Subcategorias", string.Join(",", promocion.Subcategorias));
                cmd.Parameters.AddWithValue("@Tipo", promocion.Tipo);
                cmd.Parameters.AddWithValue("@Descuento", promocion.Descuento);
                cmd.Parameters.AddWithValue("@Activa", promocion.Activa);
                cmd.Parameters.AddWithValue("@FechaInicio", promocion.FechaInicio ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaFin", promocion.FechaFin ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        private void ActualizarPromocion(Promocion promocion)
        {
            string query = @"UPDATE Promociones SET 
                            Nombre = @Nombre, 
                            Subcategorias = @Subcategorias, 
                            Tipo = @Tipo, 
                            Descuento = @Descuento, 
                            Activa = @Activa, 
                            FechaInicio = @FechaInicio, 
                            FechaFin = @FechaFin 
                            WHERE Id = @Id";

            using (SqlConnection oCon = new SqlConnection(connectionString))
            {
                oCon.Open();
                SqlCommand cmd = new SqlCommand(query, oCon);
                cmd.Parameters.AddWithValue("@Id", promocion.Id);
                cmd.Parameters.AddWithValue("@Nombre", promocion.Nombre);
                cmd.Parameters.AddWithValue("@Subcategorias", string.Join(",", promocion.Subcategorias));
                cmd.Parameters.AddWithValue("@Tipo", promocion.Tipo);
                cmd.Parameters.AddWithValue("@Descuento", promocion.Descuento);
                cmd.Parameters.AddWithValue("@Activa", promocion.Activa);
                cmd.Parameters.AddWithValue("@FechaInicio", promocion.FechaInicio ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@FechaFin", promocion.FechaFin ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEditarPromocion frm = new FrmEditarPromocion();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                GuardarPromocion(frm.Promocion);
                CargarPromociones();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPromociones.SelectedRows.Count == 0) return;

            var promocion = (Promocion)dgvPromociones.SelectedRows[0].DataBoundItem;
            FrmEditarPromocion frm = new FrmEditarPromocion(promocion);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                ActualizarPromocion(frm.Promocion);
                CargarPromociones();
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvPromociones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una promoción primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Promocion promocionSeleccionada = (Promocion)dgvPromociones.SelectedRows[0].DataBoundItem;
            DialogResult respuesta = MessageBox.Show(
                $"¿Desactivar la promoción '{promocionSeleccionada.Nombre}'?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Promociones SET Activa = 0 WHERE Id = @Id";

                    using (SqlConnection oCon = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, oCon))
                    {
                        oCon.Open();
                        cmd.Parameters.AddWithValue("@Id", promocionSeleccionada.Id);
                        cmd.ExecuteNonQuery();
                    }
                    CargarPromociones();
                    MessageBox.Show("Promoción desactivada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al desactivar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarPromociones(txtBuscar.Text.Trim());
        }
    }
}
