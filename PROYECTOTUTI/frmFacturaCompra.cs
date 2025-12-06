using Microsoft.Reporting.WinForms;
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
    public partial class frmFacturaCompra : Form
    {
        public frmFacturaCompra()
        {
            InitializeComponent();
        }
        public void GenerarFacturaProv(string numeroFactura, string fecha, string proveedor, DataTable productos, decimal subtotal, decimal iva, decimal totalAPagar)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DsFacturaCompra", productos));
            reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.rptFacturaCompra.rdlc";

            reportViewer1.LocalReport.SetParameters(new ReportParameter("NumFactura", numeroFactura));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Fecha", fecha));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Proveedor", proveedor));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Subtotal", subtotal.ToString("C2")));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("IVA", iva.ToString("C2")));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Total", totalAPagar.ToString("C2")));

            reportViewer1.RefreshReport();
        }
        private void frmFacturaCompra_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
