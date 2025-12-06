namespace PROYECTOTUTI
{
    partial class VisorEmpleados
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
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutiShopDataSet = new PROYECTOTUTI.TutiShopDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.empleadosTableAdapter = new PROYECTOTUTI.TutiShopDataSetTableAdapters.EmpleadosTableAdapter();
            this.empleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inicioSesion01BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inicioSesion01TableAdapter = new PROYECTOTUTI.TutiShopDataSetTableAdapters.InicioSesion01TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioSesion01BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.tutiShopDataSet;
            // 
            // tutiShopDataSet
            // 
            this.tutiShopDataSet.DataSetName = "TutiShopDataSet";
            this.tutiShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsEmpleados";
            reportDataSource1.Value = this.inicioSesion01BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTOTUTI.rptEmpleados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosBindingSource1
            // 
            this.empleadosBindingSource1.DataMember = "Empleados";
            this.empleadosBindingSource1.DataSource = this.tutiShopDataSet;
            // 
            // inicioSesion01BindingSource
            // 
            this.inicioSesion01BindingSource.DataMember = "InicioSesion01";
            this.inicioSesion01BindingSource.DataSource = this.tutiShopDataSet;
            // 
            // inicioSesion01TableAdapter
            // 
            this.inicioSesion01TableAdapter.ClearBeforeFill = true;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutiShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inicioSesion01BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TutiShopDataSet tutiShopDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private TutiShopDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource1;
        private System.Windows.Forms.BindingSource inicioSesion01BindingSource;
        private TutiShopDataSetTableAdapters.InicioSesion01TableAdapter inicioSesion01TableAdapter;
    }
}