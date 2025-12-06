using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOTUTI
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }
        public void CargarFactura(string numeroFactura,string fecha,string cliente,string sucursal,DataTable productos,decimal subtotal, decimal iva,decimal totalAPagar,string metodoPago,string direccionCliente,string cedulaCliente, string emailCliente)
        {
            try
            {
 
                rptFactura.LocalReport.DataSources.Clear();
                rptFactura.LocalReport.DataSources.Add(new ReportDataSource("FacturaDataset", productos));
                rptFactura.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.FacturaReport.rdlc";


                numeroFactura = numeroFactura ?? "FACT-" + DateTime.Now.ToString("yyyyMMddHHmm");
                fecha = fecha ?? DateTime.Now.ToString("dd/MM/yyyy");
                cliente = cliente ?? "Consumidor final";
                sucursal = sucursal ?? "No especificada";
                metodoPago = metodoPago ?? "No especificado";
                direccionCliente = direccionCliente ?? "No especificada";
                cedulaCliente = cedulaCliente ?? "9999999999";
                emailCliente = emailCliente ?? "example.@gmail.com";

                var parameters = new List<ReportParameter>
        {
            new ReportParameter("NumeroFactura", numeroFactura),
            new ReportParameter("Fecha", fecha),
            new ReportParameter("Sucursal", sucursal),
            new ReportParameter("Cliente", cliente),
            new ReportParameter("Subtotal", subtotal.ToString("N2")),
            new ReportParameter("IVA", iva.ToString("N2")),
            new ReportParameter("TotalAPagar", totalAPagar.ToString("N2")),
            new ReportParameter("MetodoPago", metodoPago),
            new ReportParameter("DireccionCliente", direccionCliente),
            new ReportParameter("CedulaCliente", cedulaCliente),
            new ReportParameter("EmailCliente", emailCliente)
        };

                rptFactura.LocalReport.SetParameters(parameters);
                rptFactura.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar parámetros:\n{ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            this.rptFactura.RefreshReport();
        }
    }
}
