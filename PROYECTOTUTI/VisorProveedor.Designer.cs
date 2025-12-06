namespace PROYECTOTUTI
{
    partial class VisorProveedor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tutiShopDataSet = new PROYECTOTUTI.TutiShopDataSet();
            this.proveedores1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedores1TableAdapter = new PROYECTOTUTI.TutiShopDataSetTableAdapters.Proveedores1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsProveedores";
            reportDataSource1.Value = this.proveedores1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.rptProveedor1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tutiShopDataSet
            // 
            this.tutiShopDataSet.DataSetName = "TutiShopDataSet";
            this.tutiShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedores1BindingSource
            // 
            this.proveedores1BindingSource.DataMember = "Proveedores1";
            this.proveedores1BindingSource.DataSource = this.tutiShopDataSet;
            // 
            // proveedores1TableAdapter
            // 
            this.proveedores1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedores1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TutiShopDataSet tutiShopDataSet;
        private System.Windows.Forms.BindingSource proveedores1BindingSource;
        private TutiShopDataSetTableAdapters.Proveedores1TableAdapter proveedores1TableAdapter;
    }
}