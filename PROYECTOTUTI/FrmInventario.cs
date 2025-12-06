using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTOTUTI
{
    public partial class FrmInventario : Form
    {
        
        private frmMDI formmdi;
        BaseDeDatos conSQL = new BaseDeDatos();
        private string sucursalSeleccionada = "";

        public FrmInventario(frmMDI formmdi = null)
        {
            InitializeComponent();
            this.formmdi = formmdi;
            CargarSucursales2();
        }

        private void CargarSucursales2()
        {
            DataTable sucursales = conSQL.retornaRegistros("SELECT IdSucursal, NombreSucursal, Ubicacion, NumeroContacto FROM IdentSucursales WHERE NombreSucursal != 'Todas'");
            var listaSucursales = new List<dynamic>();
            foreach (DataRow row in sucursales.Rows)
            {
                listaSucursales.Add(new
                {
                    ID = row["IdSucursal"],
                    Nombre = row["NombreSucursal"].ToString(),
                    Direccion = row["Ubicacion"].ToString(),
                    Telefono = row["NumeroContacto"].ToString()
                });
            }

            cmbbxSucursales.DataSource = listaSucursales;
            cmbbxSucursales.DisplayMember = "Nombre";
            cmbbxSucursales.ValueMember = "ID";

            cmbbxSucursales.SelectedIndex = -1;
        }
    
        private void MostrarDatosSucursal(int Sucursal)
        {
            try
            {
                DataTable datosSucursal = conSQL.retornaRegistros($"SELECT * FROM Productos WHERE IDSucursal = {Sucursal}");

                if (datosSucursal.Rows.Count > 0)
                {
                    dgvContrInventario.DataSource = datosSucursal;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
        }
        private void tlsdrpbtnSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbbxSucursales.SelectedValue != null && int.TryParse(cmbbxSucursales.SelectedValue.ToString(), out int idSucursalSeleccionada))
                {
                    DataTable sucursalInfo = conSQL.retornaRegistros($"SELECT NombreSucursal, Ubicacion, NumeroContacto FROM IdentSucursales WHERE IDSucursal = {idSucursalSeleccionada}");

                    if (sucursalInfo.Rows.Count > 0)
                    {
                        lblSucursalNombre.Text = sucursalInfo.Rows[0]["NombreSucursal"].ToString();
                        lblSucursalUbicacion.Text = sucursalInfo.Rows[0]["Ubicacion"].ToString();
                        lblSucursalNumero.Text = sucursalInfo.Rows[0]["NumeroContacto"].ToString();
                        sucursalSeleccionada = sucursalInfo.Rows[0]["NombreSucursal"].ToString();
                    }

                    MostrarDatosSucursal(idSucursalSeleccionada);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sucursalSeleccionada))
            {
                MessageBox.Show("Seleccione una sucursal antes de cargar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void ActualizarTabla()
        {
            if (!string.IsNullOrEmpty(sucursalSeleccionada))
            {
                dgvContrInventario.DataSource = conSQL.retornaRegistros($@" SELECT p.* FROM Productos p INNER JOIN IdentSucursales s ON p.IDSucursal = s.IDSucursal WHERE s.NombreSucursal = '{sucursalSeleccionada}'");
                dgvContrInventario.Refresh();
            }
        }


        private void tlsbtnRegistrar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sucursalSeleccionada))
            {
                MessageBox.Show("Seleccione una sucursal antes de registrar un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmAgregarProduc frmNC = new FrmAgregarProduc(1, sucursalSeleccionada);
            this.AddOwnedForm(frmNC);
            frmNC.ShowDialog();
            ActualizarTabla();
        }

        private void tlsbtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContrInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmAgregarProduc frmC = new FrmAgregarProduc(2, sucursalSeleccionada);
            this.AddOwnedForm(frmC);
            int codigoProducto = Convert.ToInt32(dgvContrInventario[0, dgvContrInventario.CurrentRow.Index].Value);
            frmC.txtbxCodigo.Text = codigoProducto.ToString();

            frmC.txtbxCodigo.Text = dgvContrInventario[0, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.txtbxProducto.Text = dgvContrInventario[1, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.cmbxTalla.Text = dgvContrInventario[2, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.txtbxStock.Text = dgvContrInventario[3, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.txtPU.Text = dgvContrInventario[4, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.cmbxColor.Text = dgvContrInventario[5, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.cmbxMarca.Text = dgvContrInventario[6, dgvContrInventario.CurrentRow.Index].Value.ToString();                    
            frmC.cmbCategoria.Text = dgvContrInventario[7, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.cmbSubCategoria.Text = dgvContrInventario[8, dgvContrInventario.CurrentRow.Index].Value.ToString();
            frmC.txtbxDescuento.Text = dgvContrInventario[9, dgvContrInventario.CurrentRow.Index].Value.ToString();


            frmC.cmbbxSucursal.SelectedValue = dgvContrInventario[10, dgvContrInventario.CurrentRow.Index].Value;



            DataTable dtImagenes = conSQL.retornaRegistros("SELECT TOP 1 Imagen FROM ImagenesProducto WHERE CodigoProducto = @CodigoProducto",
           new SqlParameter("@CodigoProducto", codigoProducto));

            if (dtImagenes.Rows.Count > 0 && dtImagenes.Rows[0]["Imagen"] != DBNull.Value)
            {
                byte[] imgData = (byte[])dtImagenes.Rows[0]["Imagen"];
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    frmC.picImagen.Image = Image.FromStream(ms);
                }
            }
            else
            {
                frmC.picImagen.Image = null; 
            }

            frmC.btnSelectImg.Enabled = false;
            frmC.txtbxCodigo.Enabled = false;           
            frmC.ShowDialog();
            ActualizarTabla();
        }

        private void tlsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContrInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvContrInventario.SelectedRows[0].Cells["Codigo"].Value == null ||
                string.IsNullOrEmpty(dgvContrInventario.SelectedRows[0].Cells["Codigo"].Value.ToString()))
            {
                MessageBox.Show("El código del producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(dgvContrInventario.SelectedRows[0].Cells["Codigo"].Value.ToString(), out int codigoEntero))
            {
                MessageBox.Show("El código del producto no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvContrInventario.SelectedRows[0].Cells["IDSucursal"].Value == null ||
                !int.TryParse(dgvContrInventario.SelectedRows[0].Cells["IDSucursal"].Value.ToString(), out int idSucursal))
            {
                MessageBox.Show("El ID de la sucursal no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = dgvContrInventario.SelectedRows[0].Cells["NombreProducto"].Value.ToString();

            DialogResult opc = MessageBox.Show(
                $"Se eliminará el producto {nombre} (Código: {codigoEntero}) de la sucursal actual. ¿Desea continuar?",
                "Confirmación de Borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (opc == DialogResult.Yes)
            {
                conSQL.eliminarDatos2("Productos", $"Codigo='{codigoEntero}'", idSucursal);
                ActualizarTabla(); 
            }

        }
        private void BuscarProductos(string terminoBusqueda, int idSucursal)
        {
            try
            {
                string consulta = $@"SELECT * FROM Productos WHERE (NombreProducto LIKE '%{terminoBusqueda}%' 
                OR Codigo LIKE '%{terminoBusqueda}%') AND IDSucursal = {idSucursal}";
                DataTable resultados = conSQL.retornaRegistros(consulta);
                dgvContrInventario.DataSource = resultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }      

        private void txtbxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string terminoBusqueda = txtbxBuscar.Text;

            if (cmbbxSucursales.SelectedValue != null)
            {
                int idSucursalSeleccionada = (int)cmbbxSucursales.SelectedValue;

                BuscarProductos(terminoBusqueda, idSucursalSeleccionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una sucursal antes de realizar la búsqueda.");
            }
        }


        private void dgvContrInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int codigoProducto = Convert.ToInt32(dgvContrInventario[0, e.RowIndex].Value);
                FrmInfoProducto frmC = new FrmInfoProducto(codigoProducto);            
                frmC.txtbxCodigo.Text = dgvContrInventario[0, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.txtbxProducto.Text = dgvContrInventario[1, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.cmbxTalla.Text = dgvContrInventario[2, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.cmbxColor.Text = dgvContrInventario[5, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.cmbxMarca.Text = dgvContrInventario[6, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.txtPU.Text = dgvContrInventario[4, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.cmbCategoria.Text = dgvContrInventario[7, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.cmbSubCategoria.Text = dgvContrInventario[8, dgvContrInventario.CurrentRow.Index].Value.ToString();
                frmC.txtbxDescuento.Text = dgvContrInventario[9, dgvContrInventario.CurrentRow.Index].Value.ToString();

                frmC.txtbxCodigo.Enabled = false;
                frmC.txtbxProducto.Enabled = false;
                frmC.cmbxTalla.Enabled = false;
                frmC.cmbxColor.Enabled = false;
                frmC.cmbxMarca.Enabled = false;
                frmC.txtPU.Enabled = false;  
                frmC.cmbCategoria.Enabled = false;
                frmC.cmbSubCategoria.Enabled=false;
                frmC.txtbxDescuento.Enabled = false;
                
                frmC.ShowDialog();
            }
        }

        private void FiltrarDatosSQL()
        {
            string categoriaSeleccionada = cmbbxCate.SelectedItem?.ToString();
            string subCategoriaSeleccionada = cmbbxSubCate.SelectedItem?.ToString();
            int? sucursalSeleccionada = cmbbxSucursales.SelectedValue as int?;

            string query = "SELECT * FROM Productos WHERE 1=1";

            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                query += " AND Categoria = @categoria";
            }

            if (!string.IsNullOrEmpty(subCategoriaSeleccionada))
            {
                query += " AND SubCategoria = @subcategoria";
            }

            if (sucursalSeleccionada.HasValue)
            {
                query += " AND idsucursal = @idsucursal";
            }

            using (SqlConnection conn = new SqlConnection("server= DESKTOP-95KD8UJ\\SQLEXPRESS02 ; database = TutiShop ; INTEGRATED SECURITY = true;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(categoriaSeleccionada))
                {
                    cmd.Parameters.AddWithValue("@categoria", categoriaSeleccionada);
                }

                if (!string.IsNullOrEmpty(subCategoriaSeleccionada))
                {
                    cmd.Parameters.AddWithValue("@subcategoria", subCategoriaSeleccionada);
                }

                if (sucursalSeleccionada.HasValue)
                {
                    cmd.Parameters.AddWithValue("@idsucursal", sucursalSeleccionada.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvContrInventario.DataSource = dt;
            }
        }
        private void LimpiarFiltros()
        {
            cmbbxCate.SelectedIndex = -1;
            cmbbxSubCate.SelectedIndex = -1;
            ActualizarTabla();
        }


        private void btnaceptarfiltro_Click(object sender, EventArgs e)
        {
            FiltrarDatosSQL();
        }

        private void btnborrarfiltro_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void picAgregarSucursal_Click(object sender, EventArgs e)
        {
            FrmAgregarSucursal frmAgregarSucursal = new FrmAgregarSucursal();
            frmAgregarSucursal.ShowDialog();
            CargarSucursales2();
        }

        private void picdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbbxSucursales.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una sucursal para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var item = cmbbxSucursales.SelectedItem;
                int idSucursal = (int)item.GetType().GetProperty("ID").GetValue(item);
                string nombreSucursal = item.GetType().GetProperty("Nombre").GetValue(item).ToString();

                DataTable productos = conSQL.retornaRegistros($"SELECT * FROM Productos WHERE IDSucursal = {idSucursal}");
                if (productos.Rows.Count > 0)
                {
                    MessageBox.Show($"No se puede eliminar la sucursal '{nombreSucursal}' porque tiene productos asociados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show($"¿Está seguro de eliminar la sucursal '{nombreSucursal}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    bool eliminacionExitosa = conSQL.eliminarDatos("IdentSucursales", $"IdSucursal = {idSucursal}");

                    if (eliminacionExitosa)
                    {
                        MessageBox.Show("La sucursal se eliminó correctamente.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la sucursal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CargarSucursales2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la sucursal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
