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
    public partial class frmVisorReportes : Form
    {
        public frmVisorReportes()
        {
            InitializeComponent();
        }

        private void VisorReporte_Load(object sender, EventArgs e)
        {
            BaseDeDatos conSQL = new BaseDeDatos();
            DataTable dt;
            dt = conSQL.retornaRegistros("Select * from Clientes");
            rvwReportes.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.rptClientes.rdlc"; 
            rvwReportes.LocalReport.DataSources.Clear();
            rvwReportes.LocalReport.DataSources.Add(new ReportDataSource("dsClientesbd",dt));
            this.rvwReportes.RefreshReport();
        }
    }
}
