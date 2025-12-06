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
    public partial class FrmInterfazPrincipal : Form
    {
        private frmMDI frmdi;
        public FrmInterfazPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegisMenAnual_Click(object sender, EventArgs e)
        {
            if (frmdi == null)
            {
                frmdi = new frmMDI(this);
                frmdi.Show();
            }
            frmdi.AbrirForm(new frmVisorReportes());
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (frmdi == null)
            {
                frmdi = new frmMDI(this);
                frmdi.Show();
            }
            frmdi.AbrirForm(new FrmInventario(frmdi));
            this.Hide();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (frmdi == null)
            {
                frmdi = new frmMDI(this);
                frmdi.Show();
            }
            frmdi.AbrirForm(new frmGestionClientes(frmdi));
            this.Hide();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmMDI frmMDI = new frmMDI(this);
            frmMDI.Show();
            this.Hide();
        }

    }
}
