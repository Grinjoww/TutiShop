using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOTUTI
{
    public partial class FrmAgregarProduc : Form
    {
        private List<Image> imagenes = new List<Image>();
        SqlConnection oCon = BaseDeDatos.ObtenerConexion();
        BaseDeDatos conSQL = new BaseDeDatos();
        int funcion;
        public FrmAgregarProduc(int t, string sucursalSeleccionada)
        {
            funcion = t;
            InitializeComponent();
        }
        public FrmAgregarProduc(int t) /////////////////////////////////
        {
            funcion = t;
            InitializeComponent();
        }

        private void FrmAgregarProduc_Load(object sender, EventArgs e)
        {
            CargarSucursales();
        }
        public void CargarSucursales()
        {
            DataTable sucursales = conSQL.retornaRegistros("SELECT IdSucursal, NombreSucursal FROM IdentSucursales");
            var listaSucursales = new List<dynamic>();
            foreach (DataRow row in sucursales.Rows)
            {
                listaSucursales.Add(new
                {
                    ID = row["IdSucursal"],
                    Nombre = row["NombreSucursal"].ToString()
                });
            }
          
            cmbbxSucursal.DataSource = listaSucursales;
            cmbbxSucursal.DisplayMember = "Nombre";
            cmbbxSucursal.ValueMember = "ID";

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen |*.jpg;*.jpeg;*.png;";
            openFileDialog.Multiselect = true; 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    imagenes.Add(Image.FromFile(file));
                }
                picImagen.Image = imagenes[0]; 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInventario frmInventario = Owner as FrmInventario;
                switch (funcion)
                {
                    case 1:
                        try
                        {
                            if (txtbxCodigo.Text.Trim() == "" || txtbxProducto.Text.Trim() == "" || cmbxTalla.Text.Trim() == "" ||
                                txtbxStock.Text.Trim() == "" || txtPU.Text.Trim() == "" || cmbxColor.Text.Trim() == "" ||
                                cmbxMarca.Text.Trim() == "" || cmbCategoria.Text.Trim() == "" || cmbSubCategoria.Text.Trim() == "" || txtbxDescuento.Text.Trim() == "")
                            {
                                MessageBox.Show("Debe llenar todos los campos requeridos");
                                return;
                            }

                            if (imagenes.Count == 0)
                            {
                                MessageBox.Show("Debe seleccionar al menos una imagen antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (cmbbxSucursal.SelectedValue == null)
                            {
                                MessageBox.Show("Seleccione una sucursal antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            oCon.Open();
                            int codigo = int.Parse(txtbxCodigo.Text);
                            string nombreProducto = txtbxProducto.Text;
                            string talla = cmbxTalla.Text;
                            int cantidad = int.Parse(txtbxStock.Text);
                            float precioUnitario = float.Parse(txtPU.Text);
                            string color = cmbxColor.Text;
                            string marca = cmbxMarca.Text;
                            string categoria = cmbCategoria.Text;
                            string SubCategoria = cmbSubCategoria.Text;
                            float Descuento = float.Parse(txtbxDescuento.Text);
                            int IDSucursal = int.Parse(cmbbxSucursal.SelectedValue.ToString());

                            if (IDSucursal == 4) // ID de la sucursal "Todas"
                            {
                                DataTable sucursales = conSQL.retornaRegistros("SELECT IdSucursal FROM IdentSucursales WHERE NombreSucursal != 'Todas'");
                                foreach (DataRow row in sucursales.Rows)
                                {
                                    int idSucursalActual = Convert.ToInt32(row["IdSucursal"]);
                                    string mensaje = conSQL.InsertarProducto(codigo, nombreProducto, talla, cantidad, precioUnitario, color, marca, categoria, SubCategoria, Descuento, idSucursalActual, imagenes);
                                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                string mensaje = conSQL.InsertarProducto(codigo, nombreProducto, talla, cantidad, precioUnitario, color, marca, categoria, SubCategoria, Descuento, IDSucursal, imagenes);
                                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Error: Verifique que los campos numéricos tengan valores válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            oCon.Close();
                        }
                        break;

                    case 2:
                        try
                        {
                            CargarSucursales();
                            if (txtbxProducto.Text.Trim() == "" || txtbxStock.Text.Trim() == "" || txtPU.Text.Trim() == "" || txtbxDescuento.Text.Trim() == "")
                            {
                                MessageBox.Show("Debe llenar todos los campos requeridos");
                                return;
                            }
                            if (cmbbxSucursal.SelectedValue == null)
                            {
                                MessageBox.Show("Por favor, seleccione una sucursal válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            int Codigo = int.Parse(txtbxCodigo.Text);
                            string NombreProducto = txtbxProducto.Text;
                            string Talla = cmbxTalla.Text;
                            int Cantidad = int.Parse(txtbxStock.Text);
                            float PrecioUnitario = float.Parse(txtPU.Text);
                            string Color = cmbxColor.Text;
                            string Marca = cmbxMarca.Text;
                            string Categoria = cmbCategoria.Text;
                            string SubCategoria = cmbSubCategoria.Text;
                            float Descuento = float.Parse(txtbxDescuento.Text);
                            int idSucursal = int.Parse(cmbbxSucursal.SelectedValue.ToString());

                            if (idSucursal == 4)
                            {
                                // Obtener todas las sucursales (excluyendo "Todas")
                                DataTable sucursales = conSQL.retornaRegistros("SELECT IdSucursal FROM IdentSucursales WHERE IdSucursal != 4");

                                // Actualizar el producto en cada sucursal
                                foreach (DataRow row in sucursales.Rows)
                                {
                                    int idSucursalActual = Convert.ToInt32(row["IdSucursal"]);
                                    string mensaje = conSQL.ActualizarProducto(Codigo, NombreProducto, Talla, Cantidad, PrecioUnitario, Color, Marca, Categoria, SubCategoria, Descuento, idSucursalActual);
                                    MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                // Actualizar el producto en la sucursal seleccionada
                                string mensaje = conSQL.ActualizarProducto(Codigo, NombreProducto, Talla, Cantidad, PrecioUnitario, Color,Marca, Categoria, SubCategoria, Descuento, idSucursal);
                                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Error: Verifique que los campos numéricos tengan valores válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            oCon.Close();
                        }
                        break;
                }
                if (frmInventario != null)/////////////////////////////////
                {
                    frmInventario.ActualizarTabla();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void txtbxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresar solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtbxProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresar solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
    }
}
