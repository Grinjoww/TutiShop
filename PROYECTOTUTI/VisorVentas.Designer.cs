namespace PROYECTOTUTI
{
    partial class VisorVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventasShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutiShopDataSet = new PROYECTOTUTI.TutiShopDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ventasShopTableAdapter = new PROYECTOTUTI.TutiShopDataSetTableAdapters.VentasShopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasShopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasShopBindingSource
            // 
            this.ventasShopBindingSource.DataMember = "VentasShop";
            this.ventasShopBindingSource.DataSource = this.tutiShopDataSet;
            // 
            // tutiShopDataSet
            // 
            this.tutiShopDataSet.DataSetName = "TutiShopDataSet";
            this.tutiShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsVentas";
            reportDataSource2.Value = this.ventasShopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.rptVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ventasShopTableAdapter
            // 
            this.ventasShopTableAdapter.ClearBeforeFill = true;
            // 
            // VisorVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VisorVentas";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasShopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TutiShopDataSet tutiShopDataSet;
        private System.Windows.Forms.BindingSource ventasShopBindingSource;
        private TutiShopDataSetTableAdapters.VentasShopTableAdapter ventasShopTableAdapter;
    }
}