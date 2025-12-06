namespace PROYECTOTUTI
{
    partial class FrmAgregarProduc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProduc));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.txtbxProducto = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtbxStock = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtPU = new System.Windows.Forms.TextBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.lblNuevoProduct = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbxTalla = new System.Windows.Forms.ComboBox();
            this.cmbxColor = new System.Windows.Forms.ComboBox();
            this.cmbxMarca = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.lblSubcategoria = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtbxDescuento = new System.Windows.Forms.TextBox();
            this.cmbbxSucursal = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(307, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código:";
            // 
            // txtbxCodigo
            // 
            this.txtbxCodigo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCodigo.Location = new System.Drawing.Point(389, 57);
            this.txtbxCodigo.MaxLength = 5;
            this.txtbxCodigo.Name = "txtbxCodigo";
            this.txtbxCodigo.Size = new System.Drawing.Size(72, 30);
            this.txtbxCodigo.TabIndex = 16;
            // 
            // txtbxProducto
            // 
            this.txtbxProducto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxProducto.Location = new System.Drawing.Point(389, 103);
            this.txtbxProducto.MaxLength = 20;
            this.txtbxProducto.Name = "txtbxProducto";
            this.txtbxProducto.Size = new System.Drawing.Size(143, 30);
            this.txtbxProducto.TabIndex = 17;
            this.txtbxProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxProducto_KeyPress);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(305, 359);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(77, 20);
            this.lblStock.TabIndex = 21;
            this.lblStock.Text = "En Stock:";
            // 
            // txtbxStock
            // 
            this.txtbxStock.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxStock.Location = new System.Drawing.Point(389, 354);
            this.txtbxStock.MaxLength = 5;
            this.txtbxStock.Name = "txtbxStock";
            this.txtbxStock.Size = new System.Drawing.Size(143, 30);
            this.txtbxStock.TabIndex = 22;
            this.txtbxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCantidad_KeyPress);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(307, 308);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(58, 20);
            this.lblPrecioUnitario.TabIndex = 23;
            this.lblPrecioUnitario.Text = "Precio:";
            // 
            // txtPU
            // 
            this.txtPU.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPU.Location = new System.Drawing.Point(389, 303);
            this.txtPU.MaxLength = 5;
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(143, 30);
            this.txtPU.TabIndex = 21;
            this.txtPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPU_KeyPress);
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImg.Location = new System.Drawing.Point(56, 261);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(114, 51);
            this.btnSelectImg.TabIndex = 26;
            this.btnSelectImg.Text = "Selecionar Imagen";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // picImagen
            // 
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagen.Location = new System.Drawing.Point(20, 60);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(192, 185);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 27;
            this.picImagen.TabStop = false;
            // 
            // lblNuevoProduct
            // 
            this.lblNuevoProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblNuevoProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoProduct.ForeColor = System.Drawing.Color.White;
            this.lblNuevoProduct.Location = new System.Drawing.Point(-3, -4);
            this.lblNuevoProduct.Name = "lblNuevoProduct";
            this.lblNuevoProduct.Size = new System.Drawing.Size(561, 45);
            this.lblNuevoProduct.TabIndex = 28;
            this.lblNuevoProduct.Text = "DATOS DEL PRODUCTO";
            this.lblNuevoProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(106, 514);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 46);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(292, 514);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 46);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalla.ForeColor = System.Drawing.Color.Black;
            this.lblTalla.Location = new System.Drawing.Point(305, 158);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(49, 20);
            this.lblTalla.TabIndex = 32;
            this.lblTalla.Text = "Talla:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.Black;
            this.lblColor.Location = new System.Drawing.Point(307, 207);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 20);
            this.lblColor.TabIndex = 34;
            this.lblColor.Text = "Color:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(307, 259);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 20);
            this.lblMarca.TabIndex = 36;
            this.lblMarca.Text = "Marca:";
            // 
            // cmbxTalla
            // 
            this.cmbxTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTalla.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTalla.FormattingEnabled = true;
            this.cmbxTalla.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL",
            ""});
            this.cmbxTalla.Location = new System.Drawing.Point(389, 153);
            this.cmbxTalla.Name = "cmbxTalla";
            this.cmbxTalla.Size = new System.Drawing.Size(143, 31);
            this.cmbxTalla.TabIndex = 18;
            // 
            // cmbxColor
            // 
            this.cmbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxColor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxColor.FormattingEnabled = true;
            this.cmbxColor.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Celeste",
            "Morado",
            "Naranja",
            "Negro",
            "Rojo",
            "Rosado",
            "Verde"});
            this.cmbxColor.Location = new System.Drawing.Point(389, 202);
            this.cmbxColor.Name = "cmbxColor";
            this.cmbxColor.Size = new System.Drawing.Size(143, 31);
            this.cmbxColor.Sorted = true;
            this.cmbxColor.TabIndex = 19;
            // 
            // cmbxMarca
            // 
            this.cmbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMarca.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMarca.FormattingEnabled = true;
            this.cmbxMarca.Items.AddRange(new object[] {
            "Adidas",
            "Balenciaga",
            "Calvin Klein",
            "Gucci",
            "H&M",
            "La Coste",
            "Lee",
            "Louis Vuitton",
            "Nike",
            "Prada",
            "Puma",
            "Reebok",
            "Zara"});
            this.cmbxMarca.Location = new System.Drawing.Point(389, 254);
            this.cmbxMarca.Name = "cmbxMarca";
            this.cmbxMarca.Size = new System.Drawing.Size(143, 31);
            this.cmbxMarca.Sorted = true;
            this.cmbxMarca.TabIndex = 20;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Niños"});
            this.cmbCategoria.Location = new System.Drawing.Point(137, 354);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(143, 31);
            this.cmbCategoria.Sorted = true;
            this.cmbCategoria.TabIndex = 23;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(55, 359);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 20);
            this.lblCategoria.TabIndex = 38;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Black;
            this.lblProducto.Location = new System.Drawing.Point(307, 108);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(68, 20);
            this.lblProducto.TabIndex = 19;
            this.lblProducto.Text = "Nombre:";
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategoria.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Items.AddRange(new object[] {
            "Camisa",
            "Chaqueta",
            "Falda",
            "Pantalón",
            "Shorts",
            "Vestido"});
            this.cmbSubCategoria.Location = new System.Drawing.Point(137, 407);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(143, 31);
            this.cmbSubCategoria.Sorted = true;
            this.cmbSubCategoria.TabIndex = 39;
            // 
            // lblSubcategoria
            // 
            this.lblSubcategoria.AutoSize = true;
            this.lblSubcategoria.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategoria.ForeColor = System.Drawing.Color.Black;
            this.lblSubcategoria.Location = new System.Drawing.Point(28, 412);
            this.lblSubcategoria.Name = "lblSubcategoria";
            this.lblSubcategoria.Size = new System.Drawing.Size(103, 20);
            this.lblSubcategoria.TabIndex = 40;
            this.lblSubcategoria.Text = "SubCategoría:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.Black;
            this.lblDescuento.Location = new System.Drawing.Point(305, 413);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(83, 20);
            this.lblDescuento.TabIndex = 41;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtbxDescuento
            // 
            this.txtbxDescuento.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDescuento.Location = new System.Drawing.Point(389, 408);
            this.txtbxDescuento.MaxLength = 5;
            this.txtbxDescuento.Name = "txtbxDescuento";
            this.txtbxDescuento.Size = new System.Drawing.Size(143, 30);
            this.txtbxDescuento.TabIndex = 42;
            // 
            // cmbbxSucursal
            // 
            this.cmbbxSucursal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSucursal.FormattingEnabled = true;
            this.cmbbxSucursal.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbbxSucursal.Location = new System.Drawing.Point(137, 466);
            this.cmbbxSucursal.Name = "cmbbxSucursal";
            this.cmbbxSucursal.Size = new System.Drawing.Size(143, 31);
            this.cmbbxSucursal.Sorted = true;
            this.cmbbxSucursal.TabIndex = 43;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ForeColor = System.Drawing.Color.Black;
            this.lblSucursal.Location = new System.Drawing.Point(55, 471);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(73, 20);
            this.lblSucursal.TabIndex = 44;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // FrmAgregarProduc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(556, 572);
            this.Controls.Add(this.cmbbxSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.txtbxDescuento);
            this.Controls.Add(this.cmbSubCategoria);
            this.Controls.Add(this.lblSubcategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbxMarca);
            this.Controls.Add(this.cmbxColor);
            this.Controls.Add(this.cmbxTalla);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNuevoProduct);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.txtPU);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtbxStock);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtbxProducto);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtbxCodigo);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarProduc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.FrmAgregarProduc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblNuevoProduct;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblMarca;
        public System.Windows.Forms.TextBox txtbxProducto;
        public System.Windows.Forms.TextBox txtbxStock;
        public System.Windows.Forms.TextBox txtPU;
        public System.Windows.Forms.ComboBox cmbxTalla;
        public System.Windows.Forms.ComboBox cmbxColor;
        public System.Windows.Forms.ComboBox cmbxMarca;
        public System.Windows.Forms.TextBox txtbxCodigo;
        public System.Windows.Forms.PictureBox picImagen;
        public System.Windows.Forms.Button btnSelectImg;
        public System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProducto;
        public System.Windows.Forms.ComboBox cmbSubCategoria;
        private System.Windows.Forms.Label lblSubcategoria;
        private System.Windows.Forms.Label lblDescuento;
        public System.Windows.Forms.TextBox txtbxDescuento;
        public System.Windows.Forms.ComboBox cmbbxSucursal;
        public System.Windows.Forms.Label lblSucursal;
    }
}