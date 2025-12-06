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
    public partial class VisorProveedor : Form
    {
        public VisorProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tutiShopDataSet.Proveedores1' Puede moverla o quitarla según sea necesario.
            this.proveedores1TableAdapter.Fill(this.tutiShopDataSet.Proveedores1);

            this.reportViewer1.RefreshReport();
        }
    }
}
