using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTOTUTI
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        SqlConnection oCon = BaseDeDatos.ObtenerConexion();
        public static string area;
        private void btnIrAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                oCon.Open();
                SqlCommand oComm = new SqlCommand("Select idArea, idEmpleado, Nombre, Usuario, Contrasena from InicioSesion01 where Usuario = @vusuario and Contrasena = @vcontrasena", oCon);
                oComm.Parameters.AddWithValue("vusuario", txtbxIngresarUsuario.Text);
                oComm.Parameters.AddWithValue("vcontrasena", txtbxIngresarContraseña.Text);

                SqlDataAdapter da = new SqlDataAdapter(oComm);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string usuarioNombre = dt.Rows[0]["Nombre"].ToString();
                    area = dt.Rows[0]["idArea"].ToString();
                    MessageBox.Show("Bienvenido " + usuarioNombre, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    oCon.Close();

                    Interactuar.FrmInterfazPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta");
                    txtbxIngresarContraseña.Clear();
                    txtbxIngresarContraseña.Focus();
                    oCon.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }


        private bool showpassword = false;
        private void picbxShowContra_Click(object sender, EventArgs e)
        {
            showpassword = !showpassword;
            if (showpassword)
            {
                txtbxIngresarContraseña.PasswordChar = '\0';
                picbxShowContra.Image = PROYECTOTUTI.Properties.Resources.show;
            }
            else
            {
                txtbxIngresarContraseña.PasswordChar = '*';
                picbxShowContra.Image = PROYECTOTUTI.Properties.Resources.hide;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
