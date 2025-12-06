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
    public partial class FrmGestionEmpleados : Form
    {
        private frmMDI formmdi;
        BaseDeDatos conSQL = new BaseDeDatos();
        public FrmGestionEmpleados(frmMDI formmdi = null)
        {
            InitializeComponent();
            this.formmdi = formmdi;
        }
        private void tlsbtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado FrmGE = new FrmAgregarEmpleado(1);
            this.AddOwnedForm(FrmGE);
            FrmGE.ShowDialog();
        }

        private void FrmGestionEmpleados_Load(object sender, EventArgs e)
        {
            dgvGestionEmpleados.DataSource = conSQL.retornaRegistros("Select * from InicioSesion01");
        }

        
        private void tlsbtnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void tsbFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (tsbFiltrar.Text.Length > 4)
            {
                dgvGestionEmpleados.DataSource = conSQL.retornaRegistros("Select * from InicioSesion01 where Nombre like '%" + tsbFiltrar.Text + "%' or idEmpleado like '%" + tsbFiltrar.Text + "%'");
            }

            if (tsbFiltrar.Text.Length == 0)
                dgvGestionEmpleados.DataSource = conSQL.retornaRegistros("Select * from InicioSesion01");
        }    

        private void tlsbtnModificar_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frmNE = new FrmAgregarEmpleado(2);
            this.AddOwnedForm(frmNE);
            frmNE.cmbxArea.Text = dgvGestionEmpleados[0, dgvGestionEmpleados.CurrentRow.Index].Value.ToString();
            frmNE.txtbxIDEmpleado.Text = dgvGestionEmpleados[1, dgvGestionEmpleados.CurrentRow.Index].Value.ToString();
            frmNE.txtbxNombreApellido.Text = dgvGestionEmpleados[2, dgvGestionEmpleados.CurrentRow.Index].Value.ToString();
            frmNE.txtbxUsuario.Text = dgvGestionEmpleados[3, dgvGestionEmpleados.CurrentRow.Index].Value.ToString();
            frmNE.txtbxContraseña.Text = dgvGestionEmpleados[4, dgvGestionEmpleados.CurrentRow.Index].Value.ToString();
            frmNE.dtpkContrato.Value = Convert.ToDateTime(dgvGestionEmpleados[5, dgvGestionEmpleados.CurrentRow.Index].Value);
               

            frmNE.txtbxIDEmpleado.Enabled = false;
            frmNE.ShowDialog();
  
        }

        private void tsbtnFiltrar_Click(object sender, EventArgs e)
        {
            dgvGestionEmpleados.DataSource = conSQL.retornaRegistros("Select * from InicioSesion01 where Nombre like '%" + tsbFiltrar.Text + "%' or idEmpleado like '%" + tsbFiltrar.Text + "%' or idArea like '%" + tsbFiltrar.Text + "%'");
        }

        private void tlsbtnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvGestionEmpleados.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dgvGestionEmpleados.CurrentRow.Index + " que pertenece al Empleado " + dgvGestionEmpleados[2, dgvGestionEmpleados.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("InicioSesion01", "Nombre='" + dgvGestionEmpleados[2, dgvGestionEmpleados.CurrentRow.Index].Value.ToString() + "'");
                    dgvGestionEmpleados.DataSource = conSQL.retornaRegistros("Select * from InicioSesion01");
                }
            }
        }

        private void dgvGestionEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
