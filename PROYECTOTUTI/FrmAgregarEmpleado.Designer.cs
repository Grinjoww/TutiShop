namespace PROYECTOTUTI
{
    partial class FrmAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarEmpleado));
            this.lblFechaContrato = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNuevoEmpleado = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.txtbxNombreApellido = new System.Windows.Forms.TextBox();
            this.lblidArea = new System.Windows.Forms.Label();
            this.dtpkContrato = new System.Windows.Forms.DateTimePicker();
            this.cmbxArea = new System.Windows.Forms.ComboBox();
            this.txtbxUsuario = new System.Windows.Forms.TextBox();
            this.txtbxContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtbxIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblidEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFechaContrato
            // 
            this.lblFechaContrato.AutoSize = true;
            this.lblFechaContrato.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaContrato.ForeColor = System.Drawing.Color.Black;
            this.lblFechaContrato.Location = new System.Drawing.Point(305, 90);
            this.lblFechaContrato.Name = "lblFechaContrato";
            this.lblFechaContrato.Size = new System.Drawing.Size(92, 20);
            this.lblFechaContrato.TabIndex = 74;
            this.lblFechaContrato.Text = "F. Contrato:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(94, 231);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 70;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(403, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 42);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(123, 319);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 42);
            this.btnGuardar.TabIndex = 68;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNuevoEmpleado
            // 
            this.lblNuevoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblNuevoEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblNuevoEmpleado.Location = new System.Drawing.Point(0, -1);
            this.lblNuevoEmpleado.Name = "lblNuevoEmpleado";
            this.lblNuevoEmpleado.Size = new System.Drawing.Size(677, 54);
            this.lblNuevoEmpleado.TabIndex = 67;
            this.lblNuevoEmpleado.Text = "DATOS DEL EMPLEADO";
            this.lblNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.ForeColor = System.Drawing.Color.Black;
            this.lblNombreApellido.Location = new System.Drawing.Point(12, 184);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(150, 20);
            this.lblNombreApellido.TabIndex = 62;
            this.lblNombreApellido.Text = "Nombre y Apellidos:";
            // 
            // txtbxNombreApellido
            // 
            this.txtbxNombreApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNombreApellido.Location = new System.Drawing.Point(174, 181);
            this.txtbxNombreApellido.MaxLength = 50;
            this.txtbxNombreApellido.Name = "txtbxNombreApellido";
            this.txtbxNombreApellido.Size = new System.Drawing.Size(223, 27);
            this.txtbxNombreApellido.TabIndex = 55;
            this.txtbxNombreApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxNombre_KeyPress);
            // 
            // lblidArea
            // 
            this.lblidArea.AutoSize = true;
            this.lblidArea.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidArea.ForeColor = System.Drawing.Color.Black;
            this.lblidArea.Location = new System.Drawing.Point(91, 90);
            this.lblidArea.Name = "lblidArea";
            this.lblidArea.Size = new System.Drawing.Size(71, 20);
            this.lblidArea.TabIndex = 56;
            this.lblidArea.Text = "ID Área:";
            // 
            // dtpkContrato
            // 
            this.dtpkContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkContrato.Location = new System.Drawing.Point(403, 87);
            this.dtpkContrato.Name = "dtpkContrato";
            this.dtpkContrato.Size = new System.Drawing.Size(246, 27);
            this.dtpkContrato.TabIndex = 58;
            this.dtpkContrato.Value = new System.DateTime(2025, 2, 26, 23, 20, 45, 0);
            // 
            // cmbxArea
            // 
            this.cmbxArea.FormattingEnabled = true;
            this.cmbxArea.Items.AddRange(new object[] {
            "A0001",
            "A0002"});
            this.cmbxArea.Location = new System.Drawing.Point(174, 90);
            this.cmbxArea.Name = "cmbxArea";
            this.cmbxArea.Size = new System.Drawing.Size(91, 24);
            this.cmbxArea.TabIndex = 57;
            // 
            // txtbxUsuario
            // 
            this.txtbxUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsuario.Location = new System.Drawing.Point(174, 228);
            this.txtbxUsuario.MaxLength = 50;
            this.txtbxUsuario.Name = "txtbxUsuario";
            this.txtbxUsuario.Size = new System.Drawing.Size(130, 27);
            this.txtbxUsuario.TabIndex = 75;
            // 
            // txtbxContraseña
            // 
            this.txtbxContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxContraseña.Location = new System.Drawing.Point(174, 270);
            this.txtbxContraseña.MaxLength = 50;
            this.txtbxContraseña.Name = "txtbxContraseña";
            this.txtbxContraseña.Size = new System.Drawing.Size(130, 27);
            this.txtbxContraseña.TabIndex = 77;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Black;
            this.lblContraseña.Location = new System.Drawing.Point(73, 273);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(89, 20);
            this.lblContraseña.TabIndex = 76;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtbxIDEmpleado
            // 
            this.txtbxIDEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxIDEmpleado.Location = new System.Drawing.Point(174, 137);
            this.txtbxIDEmpleado.MaxLength = 50;
            this.txtbxIDEmpleado.Name = "txtbxIDEmpleado";
            this.txtbxIDEmpleado.Size = new System.Drawing.Size(130, 27);
            this.txtbxIDEmpleado.TabIndex = 79;
            // 
            // lblidEmpleado
            // 
            this.lblidEmpleado.AutoSize = true;
            this.lblidEmpleado.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidEmpleado.ForeColor = System.Drawing.Color.Black;
            this.lblidEmpleado.Location = new System.Drawing.Point(56, 137);
            this.lblidEmpleado.Name = "lblidEmpleado";
            this.lblidEmpleado.Size = new System.Drawing.Size(106, 20);
            this.lblidEmpleado.TabIndex = 78;
            this.lblidEmpleado.Text = "ID Empleado:";
            // 
            // FrmAgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 387);
            this.Controls.Add(this.txtbxIDEmpleado);
            this.Controls.Add(this.lblidEmpleado);
            this.Controls.Add(this.txtbxContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtbxUsuario);
            this.Controls.Add(this.cmbxArea);
            this.Controls.Add(this.dtpkContrato);
            this.Controls.Add(this.lblFechaContrato);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNuevoEmpleado);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.txtbxNombreApellido);
            this.Controls.Add(this.lblidArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAgregarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empleado";
            this.Load += new System.EventHandler(this.FrmAgregarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaContrato;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNuevoEmpleado;
        private System.Windows.Forms.Label lblNombreApellido;
        public System.Windows.Forms.TextBox txtbxNombreApellido;
        private System.Windows.Forms.Label lblidArea;
        public System.Windows.Forms.DateTimePicker dtpkContrato;
        public System.Windows.Forms.ComboBox cmbxArea;
        public System.Windows.Forms.TextBox txtbxUsuario;
        public System.Windows.Forms.TextBox txtbxContraseña;
        private System.Windows.Forms.Label lblContraseña;
        public System.Windows.Forms.TextBox txtbxIDEmpleado;
        private System.Windows.Forms.Label lblidEmpleado;
    }
}