namespace PROYECTOTUTI
{
    partial class FrmAgregarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarSucursal));
            this.txtbNombreNueva = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtbxTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNuevaSucur = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtbxUbiNueva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbNombreNueva
            // 
            this.txtbNombreNueva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombreNueva.Location = new System.Drawing.Point(130, 87);
            this.txtbNombreNueva.MaxLength = 50;
            this.txtbNombreNueva.Name = "txtbNombreNueva";
            this.txtbNombreNueva.Size = new System.Drawing.Size(130, 27);
            this.txtbNombreNueva.TabIndex = 94;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(26, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 93;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtbxTelefono
            // 
            this.txtbxTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTelefono.Location = new System.Drawing.Point(130, 182);
            this.txtbxTelefono.MaxLength = 50;
            this.txtbxTelefono.Name = "txtbxTelefono";
            this.txtbxTelefono.Size = new System.Drawing.Size(130, 27);
            this.txtbxTelefono.TabIndex = 90;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(26, 185);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 20);
            this.lblTelefono.TabIndex = 88;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(203, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 42);
            this.btnCancelar.TabIndex = 87;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(14, 251);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 42);
            this.btnGuardar.TabIndex = 86;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNuevaSucur
            // 
            this.lblNuevaSucur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblNuevaSucur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaSucur.ForeColor = System.Drawing.Color.White;
            this.lblNuevaSucur.Location = new System.Drawing.Point(-2, 0);
            this.lblNuevaSucur.Name = "lblNuevaSucur";
            this.lblNuevaSucur.Size = new System.Drawing.Size(368, 54);
            this.lblNuevaSucur.TabIndex = 85;
            this.lblNuevaSucur.Text = "Agregar Nueva Sucursal";
            this.lblNuevaSucur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.ForeColor = System.Drawing.Color.Black;
            this.lblUbicacion.Location = new System.Drawing.Point(12, 138);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(82, 20);
            this.lblUbicacion.TabIndex = 84;
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // txtbxUbiNueva
            // 
            this.txtbxUbiNueva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUbiNueva.Location = new System.Drawing.Point(130, 135);
            this.txtbxUbiNueva.MaxLength = 50;
            this.txtbxUbiNueva.Name = "txtbxUbiNueva";
            this.txtbxUbiNueva.Size = new System.Drawing.Size(223, 27);
            this.txtbxUbiNueva.TabIndex = 80;
            // 
            // FrmAgregarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 310);
            this.Controls.Add(this.txtbNombreNueva);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtbxTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNuevaSucur);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtbxUbiNueva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregarSucursal";
            this.Text = "FrmAgregarSucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbNombreNueva;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtbxTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNuevaSucur;
        private System.Windows.Forms.Label lblUbicacion;
        public System.Windows.Forms.TextBox txtbxUbiNueva;
    }
}