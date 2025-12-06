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
    public partial class FrmAgregarEmpleado : Form
    {
        BaseDeDatos conSQL = new BaseDeDatos();
        int funcion;
        public FrmAgregarEmpleado(int t)
        {
            funcion = t;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <=64) || (e.KeyChar>=91 &&  e.KeyChar <= 96) || (e.KeyChar>=123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbxCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbxPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar >= 255))
            {
                MessageBox.Show("Por favor ingrese solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                MessageBox.Show("Por favor ingrese solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }        
        }
        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            if (funcion == 1) 
            {
                txtbxIDEmpleado.Text = conSQL.GenerarNuevoIDEmpleado();
            }
            txtbxIDEmpleado.Enabled = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmGestionEmpleados frmGE = Owner as FrmGestionEmpleados;
            try
            {
                switch (funcion)
                {
                    case 1:                      
                        if (cmbxArea.Text.Trim() == "" || txtbxIDEmpleado.Text.Trim() == "" || txtbxNombreApellido.Text.Trim() == "" || dtpkContrato.Text.Trim() == "" || txtbxUsuario.Text.Trim() == "" || txtbxContraseña.Text.Trim() == "")
                        {
                            MessageBox.Show("Debe llenar todos los campos requeridos");
                            return;
                        }
                        string cadena = "'" + cmbxArea.Text + "','" + txtbxIDEmpleado.Text + "','" + txtbxNombreApellido.Text + "','" + txtbxUsuario.Text + "','" + txtbxContraseña.Text + "','" + dtpkContrato.Text + "'";

                        conSQL.insertarDatos("InicioSesion01", "idArea,idEmpleado,Nombre,Usuario,Contrasena,FechaContrato", cadena);
                        break;
                        
                    case 2:
                        cadena = "idArea= '" + cmbxArea.Text + "',idEmpleado = '" + txtbxIDEmpleado.Text + "',Nombre = '" + txtbxNombreApellido.Text + "',Usuario= '" + txtbxUsuario.Text + "',Contrasena='" + txtbxContraseña.Text + "',FechaContrato='" + dtpkContrato.Text + "'";
                        conSQL.actualizarDatos("InicioSesion01", cadena, "idEmpleado='" + txtbxIDEmpleado.Text + "'");
                        break;
                }

                frmGE.dgvGestionEmpleados.DataSource = conSQL.retornaRegistros("select * from InicioSesion01");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

       
    }
}

