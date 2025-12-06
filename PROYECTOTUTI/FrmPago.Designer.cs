namespace PROYECTOTUTI
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.pnlTarjetaCredito = new System.Windows.Forms.Panel();
            this.txtTarjetaC = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblDarCambio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.lblCam = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRecibe = new System.Windows.Forms.Label();
            this.pnlEfectivo = new System.Windows.Forms.Panel();
            this.Aceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblMetododepago = new System.Windows.Forms.Label();
            this.pnlTarjetaCredito.SuspendLayout();
            this.pnlEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(114, 135);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(371, 22);
            this.txtCedula.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula :";
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(109, 20);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(212, 25);
            this.lblNumeroTarjeta.TabIndex = 0;
            this.lblNumeroTarjeta.Text = "Num. De La Tarjeta :";
            // 
            // pnlTarjetaCredito
            // 
            this.pnlTarjetaCredito.Controls.Add(this.txtCedula);
            this.pnlTarjetaCredito.Controls.Add(this.label2);
            this.pnlTarjetaCredito.Controls.Add(this.txtTarjetaC);
            this.pnlTarjetaCredito.Controls.Add(this.lblNumeroTarjeta);
            this.pnlTarjetaCredito.Location = new System.Drawing.Point(39, 252);
            this.pnlTarjetaCredito.Name = "pnlTarjetaCredito";
            this.pnlTarjetaCredito.Size = new System.Drawing.Size(601, 183);
            this.pnlTarjetaCredito.TabIndex = 84;
            // 
            // txtTarjetaC
            // 
            this.txtTarjetaC.Location = new System.Drawing.Point(114, 60);
            this.txtTarjetaC.Name = "txtTarjetaC";
            this.txtTarjetaC.Size = new System.Drawing.Size(371, 22);
            this.txtTarjetaC.TabIndex = 1;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(361, 97);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(0, 25);
            this.lblCambio.TabIndex = 4;
            // 
            // lblDarCambio
            // 
            this.lblDarCambio.AutoSize = true;
            this.lblDarCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDarCambio.Location = new System.Drawing.Point(248, 97);
            this.lblDarCambio.Name = "lblDarCambio";
            this.lblDarCambio.Size = new System.Drawing.Size(30, 20);
            this.lblDarCambio.TabIndex = 3;
            this.lblDarCambio.Text = "---";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(375, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 73);
            this.button1.TabIndex = 79;
            this.button1.Text = "Tarjeta Crédito";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivo.Image = ((System.Drawing.Image)(resources.GetObject("btnEfectivo.Image")));
            this.btnEfectivo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEfectivo.Location = new System.Drawing.Point(72, 83);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(205, 73);
            this.btnEfectivo.TabIndex = 78;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // lblCam
            // 
            this.lblCam.AutoSize = true;
            this.lblCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCam.Location = new System.Drawing.Point(126, 97);
            this.lblCam.Name = "lblCam";
            this.lblCam.Size = new System.Drawing.Size(99, 25);
            this.lblCam.TabIndex = 2;
            this.lblCam.Text = "Cambio :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblRecibe
            // 
            this.lblRecibe.AutoSize = true;
            this.lblRecibe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibe.Location = new System.Drawing.Point(126, 45);
            this.lblRecibe.Name = "lblRecibe";
            this.lblRecibe.Size = new System.Drawing.Size(91, 25);
            this.lblRecibe.TabIndex = 0;
            this.lblRecibe.Text = "Recibe :";
            // 
            // pnlEfectivo
            // 
            this.pnlEfectivo.Controls.Add(this.lblCambio);
            this.pnlEfectivo.Controls.Add(this.lblDarCambio);
            this.pnlEfectivo.Controls.Add(this.lblCam);
            this.pnlEfectivo.Controls.Add(this.textBox1);
            this.pnlEfectivo.Controls.Add(this.lblRecibe);
            this.pnlEfectivo.Location = new System.Drawing.Point(42, 254);
            this.pnlEfectivo.Name = "pnlEfectivo";
            this.pnlEfectivo.Size = new System.Drawing.Size(599, 171);
            this.pnlEfectivo.TabIndex = 83;
            this.pnlEfectivo.Visible = false;
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Aceptar.Image")));
            this.Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptar.Location = new System.Drawing.Point(350, 453);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(138, 36);
            this.Aceptar.TabIndex = 82;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(508, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 36);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // lblDinero
            // 
            this.lblDinero.BackColor = System.Drawing.Color.LightGreen;
            this.lblDinero.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.ForeColor = System.Drawing.Color.White;
            this.lblDinero.Location = new System.Drawing.Point(5, 167);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(674, 72);
            this.lblDinero.TabIndex = 80;
            this.lblDinero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMetododepago
            // 
            this.lblMetododepago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblMetododepago.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetododepago.ForeColor = System.Drawing.Color.White;
            this.lblMetododepago.Location = new System.Drawing.Point(-5, -1);
            this.lblMetododepago.Name = "lblMetododepago";
            this.lblMetododepago.Size = new System.Drawing.Size(674, 72);
            this.lblMetododepago.TabIndex = 77;
            this.lblMetododepago.Text = "MÉTODO DE PAGO";
            this.lblMetododepago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.lblMetododepago);
            this.Controls.Add(this.pnlTarjetaCredito);
            this.Controls.Add(this.pnlEfectivo);
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.Load += new System.EventHandler(this.FrmPago_Load_1);
            this.pnlTarjetaCredito.ResumeLayout(false);
            this.pnlTarjetaCredito.PerformLayout();
            this.pnlEfectivo.ResumeLayout(false);
            this.pnlEfectivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.Panel pnlTarjetaCredito;
        private System.Windows.Forms.TextBox txtTarjetaC;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblDarCambio;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Label lblCam;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRecibe;
        private System.Windows.Forms.Panel pnlEfectivo;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblMetododepago;
    }
}