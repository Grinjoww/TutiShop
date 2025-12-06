namespace PROYECTOTUTI
{
    partial class VisorProducto
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
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutiShopDataSet = new PROYECTOTUTI.TutiShopDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsTutiShop = new PROYECTOTUTI.dsTutiShop();
            this.tbClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new PROYECTOTUTI.TutiShopDataSetTableAdapters.ProductosTableAdapter();
            this.fKDetalleVeIDPro7A3223E8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaTableAdapter = new PROYECTOTUTI.TutiShopDataSetTableAdapters.DetalleVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTutiShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetalleVeIDPro7A3223E8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.tutiShopDataSet;
            // 
            // tutiShopDataSet
            // 
            this.tutiShopDataSet.DataSetName = "TutiShopDataSet";
            this.tutiShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsProductos";
            reportDataSource1.Value = this.productosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.rptProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsTutiShop
            // 
            this.dsTutiShop.DataSetName = "dsTutiShop";
            this.dsTutiShop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClientesBindingSource
            // 
            this.tbClientesBindingSource.DataMember = "tbClientes";
            this.tbClientesBindingSource.DataSource = this.dsTutiShop;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // fKDetalleVeIDPro7A3223E8BindingSource
            // 
            this.fKDetalleVeIDPro7A3223E8BindingSource.DataMember = "FK__DetalleVe__IDPro__7A3223E8";
            this.fKDetalleVeIDPro7A3223E8BindingSource.DataSource = this.productosBindingSource;
            // 
            // detalleVentaTableAdapter
            // 
            this.detalleVentaTableAdapter.ClearBeforeFill = true;
            // 
            // VisorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VisorProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTutiShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDetalleVeIDPro7A3223E8BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsTutiShop dsTutiShop;
        private System.Windows.Forms.BindingSource tbClientesBindingSource;
        private TutiShopDataSet tutiShopDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private TutiShopDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource fKDetalleVeIDPro7A3223E8BindingSource;
        private TutiShopDataSetTableAdapters.DetalleVentaTableAdapter detalleVentaTableAdapter;
    }
}