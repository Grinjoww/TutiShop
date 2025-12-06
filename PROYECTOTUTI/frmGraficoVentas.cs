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
    public partial class frmGraficoVentas : Form
    {
        public frmGraficoVentas()
        {
            InitializeComponent();
        }

        private void frmGraficoVentas_Load(object sender, EventArgs e)
        {
            BaseDeDatos oCon = new BaseDeDatos();
            DataTable dt;
            dt = oCon.retornaRegistros("Select * from DetalleVenta");
            rvwGraficoVentas.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.rptGraficoVentas.rdlc";
            rvwGraficoVentas.LocalReport.DataSources.Clear();
            rvwGraficoVentas.LocalReport.DataSources.Add(new ReportDataSource("DsGraficoVentas", dt));
            this.rvwGraficoVentas.RefreshReport();
        }
    }
}
