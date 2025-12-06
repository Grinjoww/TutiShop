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
    public partial class frmMDI : Form
    {
        private Form frmAbierto;
        private FrmInterfazPrincipal frmBoton;
      
        public frmMDI(FrmInterfazPrincipal frmBoton)
        {
            InitializeComponent();
            this.frmBoton = frmBoton;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInterfazPrincipal frmInterfaz = new FrmInterfazPrincipal();
            frmInterfaz.Show();
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionClientes frm = new frmGestionClientes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.MdiParent = this;
            frmInventario.Show();
            
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            //Administrador
            if (FrmInicio.area == "A0001")
            {
                maestroDeDatosToolStripMenuItem.Enabled = true;
            }

            //Empleado
            else if (FrmInicio.area == "A0002")
            {
                maestroDeDatosToolStripMenuItem.Enabled = true;

                empleadosToolStripMenuItem1.Enabled = false;
                empleadosToolStripMenuItem1.Visible = false;

                proveedoresToolStripMenuItem.Enabled = false;
                proveedoresToolStripMenuItem.Visible = false;

                pedidosToolStripMenuItem.Enabled = false;
                pedidosToolStripMenuItem.Visible = false;
            }

        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGestionEmpleados frmGestionEmpleados = new FrmGestionEmpleados();
            frmGestionEmpleados.MdiParent = this;
            frmGestionEmpleados.Show();
            
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVisorReportes frm = new frmVisorReportes();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorProducto frm = new VisorProducto();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorEmpleados frm = new VisorEmpleados();
            frm.MdiParent = this;
            frm.Show();
           
        }
        public void AbrirForm (Form form)
        {
            if (frmAbierto != null)
            {
                frmAbierto.Close();
            }
            frmAbierto = form;
            form.MdiParent = this;
            form.Show();
           
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frmVenta = new FrmVentas();
            frmVenta.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProv = new FrmProveedores();
            frmProv.MdiParent = this;
            frmProv.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.MdiParent = this;
            frmPedidos.Show();
        }

        private void estadísticosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisorProveedor frmProv = new VisorProveedor();
            frmProv.MdiParent = this;
            frmProv.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisorVentas frm = new VisorVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void detalleVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisorDetalleVenta frm = new VisorDetalleVenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasMensualesPorCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGraficoVentas frm = new frmGraficoVentas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
