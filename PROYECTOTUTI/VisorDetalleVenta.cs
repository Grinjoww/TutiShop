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
    public partial class VisorDetalleVenta : Form
    {
        public VisorDetalleVenta()
        {
            InitializeComponent();
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tutiShopDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.detalleVentaTableAdapter.Fill(this.tutiShopDataSet.DetalleVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
