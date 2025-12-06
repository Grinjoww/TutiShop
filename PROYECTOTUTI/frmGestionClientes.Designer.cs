namespace PROYECTOTUTI
{
    partial class frmGestionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblFiltrar = new System.Windows.Forms.ToolStripLabel();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlslblAcciones = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnVolver = new System.Windows.Forms.ToolStripButton();
            this.dgvGestionClientes = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblFiltrar,
            this.tsbFiltrar,
            this.tsbtnFiltrar,
            this.toolStripSeparator1,
            this.tlslblAcciones,
            this.toolStripSeparator2,
            this.tlsbtnNuevo,
            this.toolStripSeparator3,
            this.tlsbtnModificar,
            this.toolStripSeparator4,
            this.tlsbtnEliminar,
            this.toolStripSeparator5,
            this.tlsbtnVolver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblFiltrar
            // 
            this.tslblFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslblFiltrar.Name = "tslblFiltrar";
            this.tslblFiltrar.Size = new System.Drawing.Size(50, 24);
            this.tslblFiltrar.Text = "Filtrar:";
            this.tslblFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(100, 27);
            this.tsbFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tsbFiltrar_KeyUp);
            this.tsbFiltrar.Click += new System.EventHandler(this.tsbFiltrar_Click);
            // 
            // tsbtnFiltrar
            // 
            this.tsbtnFiltrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFiltrar.Image")));
            this.tsbtnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFiltrar.Name = "tsbtnFiltrar";
            this.tsbtnFiltrar.Size = new System.Drawing.Size(29, 24);
            this.tsbtnFiltrar.Text = "toolStripButton1";
            this.tsbtnFiltrar.Click += new System.EventHandler(this.tsbtnFiltrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tlslblAcciones
            // 
            this.tlslblAcciones.Name = "tlslblAcciones";
            this.tlslblAcciones.Size = new System.Drawing.Size(71, 24);
            this.tlslblAcciones.Text = "Acciones:";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsbtnNuevo
            // 
            this.tlsbtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnNuevo.Image")));
            this.tlsbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnNuevo.Name = "tlsbtnNuevo";
            this.tlsbtnNuevo.Size = new System.Drawing.Size(76, 24);
            this.tlsbtnNuevo.Text = "Nuevo";
            this.tlsbtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tlsbtnNuevo.Click += new System.EventHandler(this.tlsbtnNuevo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsbtnModificar
            // 
            this.tlsbtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnModificar.Image")));
            this.tlsbtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnModificar.Name = "tlsbtnModificar";
            this.tlsbtnModificar.Size = new System.Drawing.Size(97, 24);
            this.tlsbtnModificar.Text = "Modificar";
            this.tlsbtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tlsbtnModificar.Click += new System.EventHandler(this.tlsbtnModificar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsbtnEliminar
            // 
            this.tlsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnEliminar.Image")));
            this.tlsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnEliminar.Name = "tlsbtnEliminar";
            this.tlsbtnEliminar.Size = new System.Drawing.Size(87, 24);
            this.tlsbtnEliminar.Text = "Eliminar";
            this.tlsbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tlsbtnEliminar.Click += new System.EventHandler(this.tlsbtnEliminar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsbtnVolver
            // 
            this.tlsbtnVolver.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnVolver.Image")));
            this.tlsbtnVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnVolver.Name = "tlsbtnVolver";
            this.tlsbtnVolver.Size = new System.Drawing.Size(74, 24);
            this.tlsbtnVolver.Text = "Volver";
            this.tlsbtnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tlsbtnVolver.Click += new System.EventHandler(this.tlsbtnVolver_Click);
            // 
            // dgvGestionClientes
            // 
            this.dgvGestionClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGestionClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestionClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGestionClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGestionClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGestionClientes.Location = new System.Drawing.Point(0, 30);
            this.dgvGestionClientes.Name = "dgvGestionClientes";
            this.dgvGestionClientes.ReadOnly = true;
            this.dgvGestionClientes.RowHeadersWidth = 51;
            this.dgvGestionClientes.RowTemplate.Height = 24;
            this.dgvGestionClientes.Size = new System.Drawing.Size(800, 423);
            this.dgvGestionClientes.TabIndex = 1;
            this.dgvGestionClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestionClientes_CellContentClick);
            // 
            // frmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGestionClientes);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmGestionClientes";
            this.Text = "Gestión Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGestionClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblFiltrar;
        private System.Windows.Forms.ToolStripTextBox tsbFiltrar;
        private System.Windows.Forms.ToolStripButton tsbtnFiltrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlslblAcciones;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsbtnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlsbtnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tlsbtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tlsbtnVolver;
        public System.Windows.Forms.DataGridView dgvGestionClientes;
    }
}