namespace PROYECTOTUTI
{
    partial class FrmPedidosRegistrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosRegistrados));
            this.dgvHistorialPedidos = new System.Windows.Forms.DataGridView();
            this.lblPedidos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialPedidos
            // 
            this.dgvHistorialPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorialPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHistorialPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPedidos.Location = new System.Drawing.Point(37, 130);
            this.dgvHistorialPedidos.Name = "dgvHistorialPedidos";
            this.dgvHistorialPedidos.RowHeadersWidth = 51;
            this.dgvHistorialPedidos.RowTemplate.Height = 24;
            this.dgvHistorialPedidos.Size = new System.Drawing.Size(889, 394);
            this.dgvHistorialPedidos.TabIndex = 37;
            // 
            // lblPedidos
            // 
            this.lblPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(0, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(965, 64);
            this.lblPedidos.TabIndex = 36;
            this.lblPedidos.Text = "PEDIDOS REGISTRADOS";
            this.lblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPedidosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 553);
            this.Controls.Add(this.dgvHistorialPedidos);
            this.Controls.Add(this.lblPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidosRegistrados";
            this.Text = "FrmPedidosRegistrados";
            this.Load += new System.EventHandler(this.FrmPedidosRegistrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvHistorialPedidos;
        private System.Windows.Forms.Label lblPedidos;
    }
}