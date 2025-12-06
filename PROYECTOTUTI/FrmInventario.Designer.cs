namespace PROYECTOTUTI
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvContrInventario = new System.Windows.Forms.DataGridView();
            this.txtbxBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tlsControlInven = new System.Windows.Forms.ToolStrip();
            this.tlsbtnRegistrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblControlInven = new System.Windows.Forms.Label();
            this.lblSucursalNumero = new System.Windows.Forms.Label();
            this.lblSucursalUbicacion = new System.Windows.Forms.Label();
            this.lblSucursalNombre = new System.Windows.Forms.Label();
            this.cmbbxSucursales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxCate = new System.Windows.Forms.ComboBox();
            this.cmbbxSubCate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbxfiltrar = new System.Windows.Forms.GroupBox();
            this.btnborrarfiltro = new System.Windows.Forms.Button();
            this.btnaceptarfiltro = new System.Windows.Forms.Button();
            this.picOpcion = new System.Windows.Forms.PictureBox();
            this.picAgregarSucursal = new System.Windows.Forms.PictureBox();
            this.picdelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrInventario)).BeginInit();
            this.tlsControlInven.SuspendLayout();
            this.grbxfiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(660, 81);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(128, 42);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "<- Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvContrInventario
            // 
            this.dgvContrInventario.AllowUserToAddRows = false;
            this.dgvContrInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContrInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContrInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.dgvContrInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrInventario.Location = new System.Drawing.Point(12, 174);
            this.dgvContrInventario.Name = "dgvContrInventario";
            this.dgvContrInventario.ReadOnly = true;
            this.dgvContrInventario.RowHeadersWidth = 51;
            this.dgvContrInventario.RowTemplate.Height = 50;
            this.dgvContrInventario.Size = new System.Drawing.Size(776, 264);
            this.dgvContrInventario.TabIndex = 13;
            this.dgvContrInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContrInventario_CellDoubleClick);
            // 
            // txtbxBuscar
            // 
            this.txtbxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBuscar.Location = new System.Drawing.Point(85, 131);
            this.txtbxBuscar.Name = "txtbxBuscar";
            this.txtbxBuscar.Size = new System.Drawing.Size(134, 27);
            this.txtbxBuscar.TabIndex = 14;
            this.txtbxBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbxBuscar_KeyUp);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(12, 132);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(62, 23);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Buscar";
            // 
            // tlsControlInven
            // 
            this.tlsControlInven.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsControlInven.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbtnRegistrar,
            this.toolStripSeparator1,
            this.tlsbtnEditar,
            this.toolStripSeparator2,
            this.tlsbtnEliminar,
            this.toolStripSeparator3});
            this.tlsControlInven.Location = new System.Drawing.Point(0, 0);
            this.tlsControlInven.Name = "tlsControlInven";
            this.tlsControlInven.Size = new System.Drawing.Size(800, 27);
            this.tlsControlInven.TabIndex = 19;
            this.tlsControlInven.Text = "toolStrip1";
            // 
            // tlsbtnRegistrar
            // 
            this.tlsbtnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnRegistrar.Image")));
            this.tlsbtnRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnRegistrar.Name = "tlsbtnRegistrar";
            this.tlsbtnRegistrar.Size = new System.Drawing.Size(92, 24);
            this.tlsbtnRegistrar.Text = "Registrar";
            this.tlsbtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tlsbtnRegistrar.Click += new System.EventHandler(this.tlsbtnRegistrar_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tlsbtnEditar
            // 
            this.tlsbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlsbtnEditar.Image")));
            this.tlsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbtnEditar.Name = "tlsbtnEditar";
            this.tlsbtnEditar.Size = new System.Drawing.Size(72, 24);
            this.tlsbtnEditar.Text = "Editar";
            this.tlsbtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tlsbtnEditar.Click += new System.EventHandler(this.tlsbtnEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // lblControlInven
            // 
            this.lblControlInven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblControlInven.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlInven.ForeColor = System.Drawing.Color.White;
            this.lblControlInven.Location = new System.Drawing.Point(58, 35);
            this.lblControlInven.Name = "lblControlInven";
            this.lblControlInven.Size = new System.Drawing.Size(252, 40);
            this.lblControlInven.TabIndex = 20;
            this.lblControlInven.Text = "CONTROL INVENTARIO";
            this.lblControlInven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSucursalNumero
            // 
            this.lblSucursalNumero.AutoSize = true;
            this.lblSucursalNumero.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalNumero.ForeColor = System.Drawing.Color.White;
            this.lblSucursalNumero.Location = new System.Drawing.Point(278, 135);
            this.lblSucursalNumero.Name = "lblSucursalNumero";
            this.lblSucursalNumero.Size = new System.Drawing.Size(0, 23);
            this.lblSucursalNumero.TabIndex = 22;
            // 
            // lblSucursalUbicacion
            // 
            this.lblSucursalUbicacion.AutoSize = true;
            this.lblSucursalUbicacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalUbicacion.ForeColor = System.Drawing.Color.White;
            this.lblSucursalUbicacion.Location = new System.Drawing.Point(268, 114);
            this.lblSucursalUbicacion.Name = "lblSucursalUbicacion";
            this.lblSucursalUbicacion.Size = new System.Drawing.Size(0, 23);
            this.lblSucursalUbicacion.TabIndex = 23;
            // 
            // lblSucursalNombre
            // 
            this.lblSucursalNombre.AutoSize = true;
            this.lblSucursalNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalNombre.ForeColor = System.Drawing.Color.White;
            this.lblSucursalNombre.Location = new System.Drawing.Point(257, 91);
            this.lblSucursalNombre.Name = "lblSucursalNombre";
            this.lblSucursalNombre.Size = new System.Drawing.Size(0, 23);
            this.lblSucursalNombre.TabIndex = 24;
            // 
            // cmbbxSucursales
            // 
            this.cmbbxSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSucursales.FormattingEnabled = true;
            this.cmbbxSucursales.Location = new System.Drawing.Point(115, 91);
            this.cmbbxSucursales.Name = "cmbbxSucursales";
            this.cmbbxSucursales.Size = new System.Drawing.Size(104, 28);
            this.cmbbxSucursales.TabIndex = 25;
            this.cmbbxSucursales.SelectedIndexChanged += new System.EventHandler(this.tlsdrpbtnSucursales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Sucursales";
            // 
            // cmbbxCate
            // 
            this.cmbbxCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCate.FormattingEnabled = true;
            this.cmbbxCate.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Niños"});
            this.cmbbxCate.Location = new System.Drawing.Point(12, 53);
            this.cmbbxCate.Name = "cmbbxCate";
            this.cmbbxCate.Size = new System.Drawing.Size(104, 28);
            this.cmbbxCate.TabIndex = 27;
            // 
            // cmbbxSubCate
            // 
            this.cmbbxSubCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxSubCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSubCate.FormattingEnabled = true;
            this.cmbbxSubCate.Items.AddRange(new object[] {
            "Camisa",
            "Chaqueta",
            "Falda",
            "Pantalón",
            "Shorts",
            "Vestido"});
            this.cmbbxSubCate.Location = new System.Drawing.Point(138, 53);
            this.cmbbxSubCate.Name = "cmbbxSubCate";
            this.cmbbxSubCate.Size = new System.Drawing.Size(104, 28);
            this.cmbbxSubCate.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Categorías:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "SubCategorías";
            // 
            // grbxfiltrar
            // 
            this.grbxfiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxfiltrar.Controls.Add(this.btnborrarfiltro);
            this.grbxfiltrar.Controls.Add(this.btnaceptarfiltro);
            this.grbxfiltrar.Controls.Add(this.label3);
            this.grbxfiltrar.Controls.Add(this.label4);
            this.grbxfiltrar.Controls.Add(this.cmbbxSubCate);
            this.grbxfiltrar.Controls.Add(this.cmbbxCate);
            this.grbxfiltrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxfiltrar.ForeColor = System.Drawing.Color.White;
            this.grbxfiltrar.Location = new System.Drawing.Point(316, 39);
            this.grbxfiltrar.Name = "grbxfiltrar";
            this.grbxfiltrar.Size = new System.Drawing.Size(255, 129);
            this.grbxfiltrar.TabIndex = 32;
            this.grbxfiltrar.TabStop = false;
            this.grbxfiltrar.Text = "Filtrar:";
            // 
            // btnborrarfiltro
            // 
            this.btnborrarfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnborrarfiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnborrarfiltro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrarfiltro.ForeColor = System.Drawing.Color.White;
            this.btnborrarfiltro.Location = new System.Drawing.Point(138, 92);
            this.btnborrarfiltro.Name = "btnborrarfiltro";
            this.btnborrarfiltro.Size = new System.Drawing.Size(104, 32);
            this.btnborrarfiltro.TabIndex = 34;
            this.btnborrarfiltro.Text = "Borrar";
            this.btnborrarfiltro.UseVisualStyleBackColor = false;
            this.btnborrarfiltro.Click += new System.EventHandler(this.btnborrarfiltro_Click);
            // 
            // btnaceptarfiltro
            // 
            this.btnaceptarfiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptarfiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnaceptarfiltro.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptarfiltro.ForeColor = System.Drawing.Color.White;
            this.btnaceptarfiltro.Location = new System.Drawing.Point(10, 91);
            this.btnaceptarfiltro.Name = "btnaceptarfiltro";
            this.btnaceptarfiltro.Size = new System.Drawing.Size(106, 32);
            this.btnaceptarfiltro.TabIndex = 33;
            this.btnaceptarfiltro.Text = "Aceptar";
            this.btnaceptarfiltro.UseVisualStyleBackColor = false;
            this.btnaceptarfiltro.Click += new System.EventHandler(this.btnaceptarfiltro_Click);
            // 
            // picOpcion
            // 
            this.picOpcion.Image = ((System.Drawing.Image)(resources.GetObject("picOpcion.Image")));
            this.picOpcion.Location = new System.Drawing.Point(18, 34);
            this.picOpcion.Name = "picOpcion";
            this.picOpcion.Size = new System.Drawing.Size(40, 52);
            this.picOpcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOpcion.TabIndex = 21;
            this.picOpcion.TabStop = false;
            // 
            // picAgregarSucursal
            // 
            this.picAgregarSucursal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAgregarSucursal.Image = ((System.Drawing.Image)(resources.GetObject("picAgregarSucursal.Image")));
            this.picAgregarSucursal.Location = new System.Drawing.Point(223, 90);
            this.picAgregarSucursal.Name = "picAgregarSucursal";
            this.picAgregarSucursal.Size = new System.Drawing.Size(33, 31);
            this.picAgregarSucursal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAgregarSucursal.TabIndex = 33;
            this.picAgregarSucursal.TabStop = false;
            this.picAgregarSucursal.Click += new System.EventHandler(this.picAgregarSucursal_Click);
            // 
            // picdelete
            // 
            this.picdelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picdelete.Image = ((System.Drawing.Image)(resources.GetObject("picdelete.Image")));
            this.picdelete.Location = new System.Drawing.Point(223, 128);
            this.picdelete.Name = "picdelete";
            this.picdelete.Size = new System.Drawing.Size(34, 30);
            this.picdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdelete.TabIndex = 34;
            this.picdelete.TabStop = false;
            this.picdelete.Click += new System.EventHandler(this.picdelete_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picdelete);
            this.Controls.Add(this.picAgregarSucursal);
            this.Controls.Add(this.grbxfiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxSucursales);
            this.Controls.Add(this.lblSucursalNombre);
            this.Controls.Add(this.lblSucursalUbicacion);
            this.Controls.Add(this.lblSucursalNumero);
            this.Controls.Add(this.picOpcion);
            this.Controls.Add(this.lblControlInven);
            this.Controls.Add(this.tlsControlInven);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtbxBuscar);
            this.Controls.Add(this.dgvContrInventario);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrInventario)).EndInit();
            this.tlsControlInven.ResumeLayout(false);
            this.tlsControlInven.PerformLayout();
            this.grbxfiltrar.ResumeLayout(false);
            this.grbxfiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOpcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtbxBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ToolStrip tlsControlInven;
        private System.Windows.Forms.Label lblControlInven;
        private System.Windows.Forms.ToolStripButton tlsbtnRegistrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsbtnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsbtnEliminar;
        private System.Windows.Forms.PictureBox picOpcion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.DataGridView dgvContrInventario;
        private System.Windows.Forms.Label lblSucursalNumero;
        private System.Windows.Forms.Label lblSucursalUbicacion;
        private System.Windows.Forms.Label lblSucursalNombre;
        private System.Windows.Forms.ComboBox cmbbxSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbxCate;
        private System.Windows.Forms.ComboBox cmbbxSubCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbxfiltrar;
        private System.Windows.Forms.Button btnborrarfiltro;
        private System.Windows.Forms.Button btnaceptarfiltro;
        private System.Windows.Forms.PictureBox picAgregarSucursal;
        private System.Windows.Forms.PictureBox picdelete;
    }
}