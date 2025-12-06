namespace PROYECTOTUTI
{
    partial class frmGraficoVentas
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
            this.rvwGraficoVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwGraficoVentas
            // 
            this.rvwGraficoVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwGraficoVentas.Location = new System.Drawing.Point(0, 0);
            this.rvwGraficoVentas.Name = "rvwGraficoVentas";
            this.rvwGraficoVentas.ServerReport.BearerToken = null;
            this.rvwGraficoVentas.Size = new System.Drawing.Size(800, 450);
            this.rvwGraficoVentas.TabIndex = 0;
            // 
            // frmGraficoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvwGraficoVentas);
            this.Name = "frmGraficoVentas";
            this.Text = "frmGraficoVentas";
            this.Load += new System.EventHandler(this.frmGraficoVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwGraficoVentas;
    }
}