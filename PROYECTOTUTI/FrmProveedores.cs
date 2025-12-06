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
    public partial class FrmProveedores : Form
    {
        SqlConnection oCon = BaseDeDatos.ObtenerConexion();
        BaseDeDatos conSQL = new BaseDeDatos();
        int funcion = 1;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvProveedores.DataSource = conSQL.retornaRegistros("Select * from Proveedores1");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cadena;
            try
            {
                if (funcion == 1)
                {
                    if (txtNombre.Text.Trim() == "" || txtIdentificacion.Text.Trim() == "" || txtCelular.Text.Trim() == "" || txtDireccion.Text.Trim() == ""
                        || txtCiudad.Text.Trim() == "" || txtCorreo.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe llenar todos los campos");
                    }
                    else
                    {
                        cadena = "'" + txtNombre.Text + "','" + txtIdentificacion.Text + "','" + txtCelular.Text + "','" + txtDireccion.Text + "','" + txtCiudad.Text +
                            "','" + txtCorreo.Text + "'";

                        conSQL.insertarDatos("Proveedores1", "Nombre,Identificacion,Celular,Direccion,Ciudad,Correo", cadena);
                        MessageBox.Show("Proveedor agregado correctamente");
                        LimpiarCampos();
                    }
                }
                else if (funcion == 2)
                {
                    string idProveedor = dgvProveedores.SelectedRows[0].Cells["ID"].Value.ToString();
                    cadena = "Nombre='" + txtNombre.Text + "',Identificacion='" + txtIdentificacion.Text + "',Celular='" + txtCelular.Text + "',Direccion='" +
                        txtDireccion.Text + "',Ciudad='" + txtCiudad.Text + "',Correo='" + txtCorreo.Text + "'";
                    oCon.Open();
                    conSQL.actualizarDatos("Proveedores1", cadena, "ID='" + idProveedor + "'");
                    oCon.Close();
                    funcion = 1;
                    MessageBox.Show("Proveedor editado correctamente");
                    LimpiarCampos();
                }

                dgvProveedores.DataSource = conSQL.retornaRegistros("select * from Proveedores1");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }

        private void tlsEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                funcion = 2;

                txtNombre.Text = dgvProveedores[1, dgvProveedores.CurrentRow.Index].Value.ToString();
                txtIdentificacion.Text = dgvProveedores[2, dgvProveedores.CurrentRow.Index].Value.ToString();
                txtCelular.Text = dgvProveedores[3, dgvProveedores.CurrentRow.Index].Value.ToString();
                txtDireccion.Text = dgvProveedores[4, dgvProveedores.CurrentRow.Index].Value.ToString();
                txtCiudad.Text = dgvProveedores[5, dgvProveedores.CurrentRow.Index].Value.ToString();
                txtCorreo.Text = dgvProveedores[6, dgvProveedores.CurrentRow.Index].Value.ToString();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void tlsEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dgvProveedores.CurrentRow.Index + ", que pertenece al proveedor " + dgvProveedores[1, dgvProveedores.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Proveedores1", "ID='" + dgvProveedores[0, dgvProveedores.CurrentRow.Index].Value.ToString() + "'");
                    dgvProveedores.DataSource = conSQL.retornaRegistros("Select * from Proveedores1");
                }
            }
        }
    }    
}
