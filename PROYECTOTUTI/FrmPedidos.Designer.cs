namespace PROYECTOTUTI
{
    partial class FrmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarFact = new System.Windows.Forms.Button();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblTextoTotal = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.btnNuevProd = new System.Windows.Forms.Button();
            this.btnNuevProv = new System.Windows.Forms.Button();
            this.txtNuevaCant = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNuevaCant = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tlsRegistrar = new System.Windows.Forms.ToolStripButton();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tlsVerPedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsAgregar = new System.Windows.Forms.ToolStripButton();
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(21, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(417, 56);
            this.btnGuardar.TabIndex = 101;
            this.btnGuardar.Text = "Guardar datos modificados";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 100;
            this.label1.Text = "Total compra: ";
            // 
            // btnGenerarFact
            // 
            this.btnGenerarFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerarFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnGenerarFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarFact.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarFact.Image")));
            this.btnGenerarFact.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarFact.Location = new System.Drawing.Point(320, 464);
            this.btnGenerarFact.Name = "btnGenerarFact";
            this.btnGenerarFact.Size = new System.Drawing.Size(118, 86);
            this.btnGenerarFact.TabIndex = 99;
            this.btnGenerarFact.Text = "Generar Factura";
            this.btnGenerarFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerarFact.UseVisualStyleBackColor = false;
            this.btnGenerarFact.Click += new System.EventHandler(this.btnGenerarFact_Click);
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(299, 352);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(0, 22);
            this.lblTotalCompra.TabIndex = 98;
            // 
            // lblTextoTotal
            // 
            this.lblTextoTotal.AutoSize = true;
            this.lblTextoTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTextoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoTotal.Location = new System.Drawing.Point(313, 352);
            this.lblTextoTotal.Name = "lblTextoTotal";
            this.lblTextoTotal.Size = new System.Drawing.Size(0, 22);
            this.lblTextoTotal.TabIndex = 97;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(129, 278);
            this.txtPrecioUnitario.MaxLength = 50;
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(309, 34);
            this.txtPrecioUnitario.TabIndex = 95;
            this.txtPrecioUnitario.TextChanged += new System.EventHandler(this.txtPrecioUnitario_TextChanged);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(17, 268);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(83, 44);
            this.lblPrecioUnitario.TabIndex = 94;
            this.lblPrecioUnitario.Text = "Precio \r\nunitario:";
            // 
            // btnNuevProd
            // 
            this.btnNuevProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnNuevProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevProd.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevProd.Image")));
            this.btnNuevProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevProd.Location = new System.Drawing.Point(21, 464);
            this.btnNuevProd.Name = "btnNuevProd";
            this.btnNuevProd.Size = new System.Drawing.Size(104, 86);
            this.btnNuevProd.TabIndex = 93;
            this.btnNuevProd.Text = "Nuevo Producto";
            this.btnNuevProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevProd.UseVisualStyleBackColor = false;
            this.btnNuevProd.Click += new System.EventHandler(this.btnNuevProd_Click);
            // 
            // btnNuevProv
            // 
            this.btnNuevProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnNuevProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevProv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevProv.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevProv.Image")));
            this.btnNuevProv.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevProv.Location = new System.Drawing.Point(163, 464);
            this.btnNuevProv.Name = "btnNuevProv";
            this.btnNuevProv.Size = new System.Drawing.Size(118, 86);
            this.btnNuevProv.TabIndex = 92;
            this.btnNuevProv.Text = "Nuevo Proveedor";
            this.btnNuevProv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevProv.UseVisualStyleBackColor = false;
            this.btnNuevProv.Click += new System.EventHandler(this.btnNuevProv_Click);
            // 
            // txtNuevaCant
            // 
            this.txtNuevaCant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaCant.Location = new System.Drawing.Point(129, 218);
            this.txtNuevaCant.MaxLength = 5;
            this.txtNuevaCant.Name = "txtNuevaCant";
            this.txtNuevaCant.Size = new System.Drawing.Size(309, 34);
            this.txtNuevaCant.TabIndex = 33;
            this.txtNuevaCant.TextChanged += new System.EventHandler(this.txtNuevaCant_TextChanged);
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(129, 158);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(309, 36);
            this.cmbProducto.TabIndex = 32;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(129, 101);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(309, 36);
            this.cmbProveedor.TabIndex = 31;
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPedido.Location = new System.Drawing.Point(129, 50);
            this.txtNumPedido.MaxLength = 50;
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(309, 34);
            this.txtNumPedido.TabIndex = 5;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(17, 277);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(0, 22);
            this.lblCorreo.TabIndex = 4;
            // 
            // lblNuevaCant
            // 
            this.lblNuevaCant.AutoSize = true;
            this.lblNuevaCant.BackColor = System.Drawing.SystemColors.Control;
            this.lblNuevaCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCant.Location = new System.Drawing.Point(17, 208);
            this.lblNuevaCant.Name = "lblNuevaCant";
            this.lblNuevaCant.Size = new System.Drawing.Size(96, 44);
            this.lblNuevaCant.TabIndex = 3;
            this.lblNuevaCant.Text = "Nueva \r\nCantidad:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(17, 158);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(102, 22);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto: ";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(17, 111);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(108, 22);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(796, 678);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(126, 48);
            this.btnEditar.TabIndex = 103;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblPedidos
            // 
            this.lblPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPedidos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.Color.White;
            this.lblPedidos.Location = new System.Drawing.Point(0, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(1135, 88);
            this.lblPedidos.TabIndex = 96;
            this.lblPedidos.Text = "PEDIDOS";
            this.lblPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.Location = new System.Drawing.Point(17, 59);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(106, 22);
            this.lblNumPedido.TabIndex = 0;
            this.lblNumPedido.Text = "N° Pedido:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(947, 678);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 48);
            this.btnEliminar.TabIndex = 102;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(80, 70);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsRegistrar});
            this.toolStrip2.Location = new System.Drawing.Point(796, 193);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(87, 95);
            this.toolStrip2.TabIndex = 100;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tlsRegistrar
            // 
            this.tlsRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.tlsRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsRegistrar.ForeColor = System.Drawing.Color.White;
            this.tlsRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("tlsRegistrar.Image")));
            this.tlsRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsRegistrar.Name = "tlsRegistrar";
            this.tlsRegistrar.Size = new System.Drawing.Size(84, 92);
            this.tlsRegistrar.Text = "Registrar";
            this.tlsRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsRegistrar.ToolTipText = "Finaliza la compra y actualiza el stock";
            this.tlsRegistrar.Click += new System.EventHandler(this.tlsRegistrar_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(515, 324);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(579, 335);
            this.dgvPedidos.TabIndex = 97;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(80, 70);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsVerPedidos});
            this.toolStrip3.Location = new System.Drawing.Point(936, 193);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(106, 95);
            this.toolStrip3.TabIndex = 101;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tlsVerPedidos
            // 
            this.tlsVerPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.tlsVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsVerPedidos.ForeColor = System.Drawing.Color.White;
            this.tlsVerPedidos.Image = ((System.Drawing.Image)(resources.GetObject("tlsVerPedidos.Image")));
            this.tlsVerPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsVerPedidos.Name = "tlsVerPedidos";
            this.tlsVerPedidos.Size = new System.Drawing.Size(103, 92);
            this.tlsVerPedidos.Text = "Ver Pedidos";
            this.tlsVerPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsVerPedidos.Click += new System.EventHandler(this.tlsVerPedidos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(80, 70);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(648, 193);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(87, 95);
            this.toolStrip1.TabIndex = 99;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsAgregar
            // 
            this.tlsAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.tlsAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsAgregar.ForeColor = System.Drawing.Color.White;
            this.tlsAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tlsAgregar.Image")));
            this.tlsAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsAgregar.Name = "tlsAgregar";
            this.tlsAgregar.Size = new System.Drawing.Size(84, 92);
            this.tlsAgregar.Text = "Agregar";
            this.tlsAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlsAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tlsAgregar.Click += new System.EventHandler(this.tlsAgregar_Click);
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpRegistrar.Controls.Add(this.btnGuardar);
            this.grpRegistrar.Controls.Add(this.label1);
            this.grpRegistrar.Controls.Add(this.btnGenerarFact);
            this.grpRegistrar.Controls.Add(this.lblTotalCompra);
            this.grpRegistrar.Controls.Add(this.lblTextoTotal);
            this.grpRegistrar.Controls.Add(this.txtPrecioUnitario);
            this.grpRegistrar.Controls.Add(this.lblPrecioUnitario);
            this.grpRegistrar.Controls.Add(this.btnNuevProd);
            this.grpRegistrar.Controls.Add(this.btnNuevProv);
            this.grpRegistrar.Controls.Add(this.txtNuevaCant);
            this.grpRegistrar.Controls.Add(this.cmbProducto);
            this.grpRegistrar.Controls.Add(this.cmbProveedor);
            this.grpRegistrar.Controls.Add(this.txtNumPedido);
            this.grpRegistrar.Controls.Add(this.lblCorreo);
            this.grpRegistrar.Controls.Add(this.lblNuevaCant);
            this.grpRegistrar.Controls.Add(this.lblProducto);
            this.grpRegistrar.Controls.Add(this.lblProveedor);
            this.grpRegistrar.Controls.Add(this.lblNumPedido);
            this.grpRegistrar.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistrar.Location = new System.Drawing.Point(27, 178);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(467, 567);
            this.grpRegistrar.TabIndex = 98;
            this.grpRegistrar.TabStop = false;
            this.grpRegistrar.Text = "Registrar Pedidos";
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 805);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpRegistrar);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnGenerarFact;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblTextoTotal;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        public System.Windows.Forms.Button btnNuevProd;
        public System.Windows.Forms.Button btnNuevProv;
        private System.Windows.Forms.TextBox txtNuevaCant;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNuevaCant;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblProveedor;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblNumPedido;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tlsRegistrar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tlsVerPedidos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsAgregar;
        private System.Windows.Forms.GroupBox grpRegistrar;
    }
}