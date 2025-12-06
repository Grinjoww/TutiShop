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
    public partial class frmGestionClientes : Form
    {
        private frmMDI formmdi;
        BaseDeDatos conSQL = new BaseDeDatos();
        public frmGestionClientes(frmMDI fmdi = null)
        {
            InitializeComponent();
            this.formmdi = fmdi;
        }
        private void tlsbtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnFiltrar_Click(object sender, EventArgs e)
        {
            dgvGestionClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes where ID like '%" + tsbFiltrar.Text + "%' or Cedula like '%" + tsbFiltrar.Text + "%' or Nombre like '%" + tsbFiltrar.Text + "%'");
        }

        private void tlsbtnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNC = new FrmNuevoCliente(1);
            this.AddOwnedForm(frmNC); 
            frmNC.ShowDialog();
        }

        private void tlsbtnModificar_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmC = new FrmNuevoCliente(2);
            this.AddOwnedForm(frmC);
            frmC.txtbxID.Text = dgvGestionClientes[0, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtbxCedula.Text = dgvGestionClientes[1, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtbxNombre.Text = dgvGestionClientes[2, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtApellido.Text = dgvGestionClientes[3, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtbxEmail.Text = dgvGestionClientes[4, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtbxDireccion.Text = dgvGestionClientes[5, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtbxCiudad.Text = dgvGestionClientes[6, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtbxPais.Text = dgvGestionClientes[7, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            frmC.txtbxTelefono.Text = dgvGestionClientes[8, dgvGestionClientes.CurrentRow.Index].Value.ToString();
            
            frmC.txtbxID.Enabled = false; 
            frmC.ShowDialog();
        }

        private void tlsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGestionClientes.RowCount > 0)
            {
                DialogResult opc = MessageBox.Show(this, "Se eliminará la fila " + dgvGestionClientes.CurrentRow.Index + ", que pertenece al cliente " + dgvGestionClientes[0, dgvGestionClientes.CurrentRow.Index].Value.ToString(), "Confirmación de Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opc == DialogResult.Yes)
                {
                    conSQL.eliminarDatos("Clientes", "ID='" + dgvGestionClientes[0, dgvGestionClientes.CurrentRow.Index].Value.ToString() + "'");
                    dgvGestionClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
                }
            }
        }

        private void dgvGestionClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            dgvGestionClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void tsbFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            if (tsbFiltrar.Text.Length > 4)
            {
                dgvGestionClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes where ID like '%" + tsbFiltrar.Text + "%' or Cedula like '%" + tsbFiltrar.Text + "%' or Nombre like '%" + tsbFiltrar.Text + "%'");
            }

            if (tsbFiltrar.Text.Length == 0)
                dgvGestionClientes.DataSource = conSQL.retornaRegistros("Select * from Clientes");
        }

        private void tsbFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
