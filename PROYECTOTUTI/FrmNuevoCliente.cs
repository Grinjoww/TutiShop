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
    public partial class FrmNuevoCliente : Form
    {
        BaseDeDatos conSQL = new BaseDeDatos();
        int funcion;
        public FrmNuevoCliente(int t)
        {
            funcion = t;
            InitializeComponent();
        }
        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmGestionClientes frmGC = Owner as frmGestionClientes;
            try
            {
                switch (funcion)
                {
                    case 1:
                        if (txtbxID.Text.Trim() == "" || txtbxCedula.Text.Trim() == "" || txtbxNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtbxEmail.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos requeridos");
                            return;
                        }
                        string cadena = "'" + txtbxID.Text + "','" + txtbxCedula.Text + "','" + txtbxNombre.Text + "','" + txtApellido.Text + "','" + txtbxEmail.Text + "','" + txtbxDireccion.Text + "','" + txtbxCiudad.Text + "','" + txtbxPais.Text + "','" + txtbxTelefono.Text + "'";

                        conSQL.insertarDatos("Clientes", "ID,Cedula,Nombre,Apellido,Email,Direccion,Ciudad,Pais,Telefono", cadena);
                        break;

                    case 2:
                        cadena = "Cedula='" + txtbxCedula.Text + "',Nombre='" + txtbxNombre.Text + "',Apellido='" + txtApellido.Text + "',Email='" + txtbxEmail.Text + "',Direccion='" + txtbxDireccion.Text + "',Ciudad='" + txtbxCiudad.Text + "',Pais='" + txtbxPais.Text + "',Telefono='" + txtbxTelefono.Text + "'";
                        conSQL.actualizarDatos("Clientes", cadena, "ID='" + txtbxID.Text + "'");
                        break;
                }

                frmGC.dgvGestionClientes.DataSource = conSQL.retornaRegistros("select * from Clientes");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void txtbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (( e.KeyChar>=32 && e.KeyChar <= 47)|| (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show ("Por favor ingresar solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtbxCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresar solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtbxCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtbxPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}
