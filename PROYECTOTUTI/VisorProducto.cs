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
    public partial class VisorProducto : Form
    {
        public VisorProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tutiShopDataSet.DetalleVenta' Puede moverla o quitarla según sea necesario.
            this.detalleVentaTableAdapter.Fill(this.tutiShopDataSet.DetalleVenta);
            // TODO: esta línea de código carga datos en la tabla 'tutiShopDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.tutiShopDataSet.Productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
