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
    public partial class FrmAgregarSucursal : Form
    {
        SqlConnection oCon = BaseDeDatos.ObtenerConexion();
        FrmInventario Cargar = new FrmInventario();
        public FrmAgregarSucursal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombreNueva.Text.Trim();
            string ubicacion = txtbxUbiNueva.Text.Trim();
            string telefono = txtbxTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(ubicacion) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
            try
            {
                oCon.Open();
                string cadena = "INSERT INTO IdentSucursales (NombreSucursal, Ubicacion, NumeroContacto) VALUES (@nombre, @ubicacion, @telefono)";
                SqlCommand cmd = new SqlCommand(cadena, oCon);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucursal agregada correctamente.");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la sucursal: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
