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
    public partial class VisorVentas : Form
    {
        public VisorVentas()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tutiShopDataSet.VentasShop' Puede moverla o quitarla según sea necesario.
            this.ventasShopTableAdapter.Fill(this.tutiShopDataSet.VentasShop);

            this.reportViewer1.RefreshReport();
        }
    }
}
