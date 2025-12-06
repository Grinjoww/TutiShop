namespace PROYECTOTUTI
{
    partial class FrmTraslados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraslados));
            this.cmbbxOrigen = new System.Windows.Forms.ComboBox();
            this.cmbbxDestino = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.dgvDisponibles = new System.Windows.Forms.DataGridView();
            this.btnTrasladar = new System.Windows.Forms.Button();
            this.dgvTrasladosRecientes = new System.Windows.Forms.DataGridView();
            this.txtbxCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvDestino = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTraslado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrasladosRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbxOrigen
            // 
            this.cmbbxOrigen.FormattingEnabled = true;
            this.cmbbxOrigen.Location = new System.Drawing.Point(12, 98);
            this.cmbbxOrigen.Name = "cmbbxOrigen";
            this.cmbbxOrigen.Size = new System.Drawing.Size(121, 24);
            this.cmbbxOrigen.TabIndex = 0;
            this.cmbbxOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbbxOrigen_SelectedIndexChanged);
            // 
            // cmbbxDestino
            // 
            this.cmbbxDestino.FormattingEnabled = true;
            this.cmbbxDestino.Location = new System.Drawing.Point(15, 277);
            this.cmbbxDestino.Name = "cmbbxDestino";
            this.cmbbxDestino.Size = new System.Drawing.Size(121, 24);
            this.cmbbxDestino.TabIndex = 1;
            this.cmbbxDestino.SelectedIndexChanged += new System.EventHandler(this.cmbbxDestino_SelectedIndexChanged);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(8, 72);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(70, 23);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.ForeColor = System.Drawing.Color.White;
            this.lblDestino.Location = new System.Drawing.Point(11, 251);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(76, 23);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino:";
            // 
            // dgvDisponibles
            // 
            this.dgvDisponibles.AllowUserToAddRows = false;
            this.dgvDisponibles.AllowUserToDeleteRows = false;
            this.dgvDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisponibles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.dgvDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponibles.Location = new System.Drawing.Point(11, 128);
            this.dgvDisponibles.Name = "dgvDisponibles";
            this.dgvDisponibles.ReadOnly = true;
            this.dgvDisponibles.RowHeadersWidth = 51;
            this.dgvDisponibles.RowTemplate.Height = 24;
            this.dgvDisponibles.Size = new System.Drawing.Size(1105, 105);
            this.dgvDisponibles.TabIndex = 4;
            // 
            // btnTrasladar
            // 
            this.btnTrasladar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrasladar.Location = new System.Drawing.Point(997, 254);
            this.btnTrasladar.Name = "btnTrasladar";
            this.btnTrasladar.Size = new System.Drawing.Size(115, 47);
            this.btnTrasladar.TabIndex = 5;
            this.btnTrasladar.Text = "Trasladar";
            this.btnTrasladar.UseVisualStyleBackColor = true;
            this.btnTrasladar.Click += new System.EventHandler(this.btnTrasladar_Click);
            // 
            // dgvTrasladosRecientes
            // 
            this.dgvTrasladosRecientes.AllowUserToAddRows = false;
            this.dgvTrasladosRecientes.AllowUserToDeleteRows = false;
            this.dgvTrasladosRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrasladosRecientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrasladosRecientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.dgvTrasladosRecientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTrasladosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrasladosRecientes.Location = new System.Drawing.Point(11, 485);
            this.dgvTrasladosRecientes.Name = "dgvTrasladosRecientes";
            this.dgvTrasladosRecientes.ReadOnly = true;
            this.dgvTrasladosRecientes.RowHeadersWidth = 51;
            this.dgvTrasladosRecientes.RowTemplate.Height = 24;
            this.dgvTrasladosRecientes.Size = new System.Drawing.Size(1105, 122);
            this.dgvTrasladosRecientes.TabIndex = 6;
            this.dgvTrasladosRecientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrasladosRecientes_CellContentClick);
            // 
            // txtbxCantidad
            // 
            this.txtbxCantidad.Location = new System.Drawing.Point(211, 279);
            this.txtbxCantidad.Name = "txtbxCantidad";
            this.txtbxCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtbxCantidad.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(208, 251);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(88, 23);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dgvDestino
            // 
            this.dgvDestino.AllowUserToAddRows = false;
            this.dgvDestino.AllowUserToDeleteRows = false;
            this.dgvDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDestino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestino.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(243)))), ((int)(((byte)(251)))));
            this.dgvDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestino.Location = new System.Drawing.Point(11, 307);
            this.dgvDestino.Name = "dgvDestino";
            this.dgvDestino.ReadOnly = true;
            this.dgvDestino.RowHeadersWidth = 51;
            this.dgvDestino.RowTemplate.Height = 24;
            this.dgvDestino.Size = new System.Drawing.Size(1101, 105);
            this.dgvDestino.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTraslado
            // 
            this.lblTraslado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTraslado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblTraslado.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraslado.ForeColor = System.Drawing.Color.White;
            this.lblTraslado.Location = new System.Drawing.Point(306, 433);
            this.lblTraslado.Name = "lblTraslado";
            this.lblTraslado.Size = new System.Drawing.Size(540, 40);
            this.lblTraslado.TabIndex = 21;
            this.lblTraslado.Text = "TRASLADOS";
            this.lblTraslado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "TRASLADAR PRODUCTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTraslados
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1125, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTraslado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDestino);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtbxCantidad);
            this.Controls.Add(this.dgvTrasladosRecientes);
            this.Controls.Add(this.btnTrasladar);
            this.Controls.Add(this.dgvDisponibles);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.cmbbxDestino);
            this.Controls.Add(this.cmbbxOrigen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTraslados";
            this.Text = "Traslados";
            this.Load += new System.EventHandler(this.FrmTraslados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrasladosRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxOrigen;
        private System.Windows.Forms.ComboBox cmbbxDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.DataGridView dgvDisponibles;
        private System.Windows.Forms.Button btnTrasladar;
        private System.Windows.Forms.DataGridView dgvTrasladosRecientes;
        private System.Windows.Forms.TextBox txtbxCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvDestino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTraslado;
        private System.Windows.Forms.Label label1;
    }
}