namespace PROYECTOTUTI
{
    partial class FrmEditarPromocion
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
            this.components = new System.ComponentModel.Container();
            this.lblDiasPromocion = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.numDescuento = new System.Windows.Forms.NumericUpDown();
            this.chkActiva = new System.Windows.Forms.CheckBox();
            this.lblActiva = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkSinFechaFin = new System.Windows.Forms.CheckBox();
            this.lblFechaF = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxDias = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSinFechaInicio = new System.Windows.Forms.CheckBox();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpFechaInicio = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtSubcategorias = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSubcategoria = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEditarProm = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDescuento)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpFechaInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDiasPromocion
            // 
            this.lblDiasPromocion.AutoSize = true;
            this.lblDiasPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasPromocion.Location = new System.Drawing.Point(477, 87);
            this.lblDiasPromocion.Name = "lblDiasPromocion";
            this.lblDiasPromocion.Size = new System.Drawing.Size(112, 18);
            this.lblDiasPromocion.TabIndex = 132;
            this.lblDiasPromocion.Text = "Día Especial :";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(245, 156);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(22, 18);
            this.lblPorcentaje.TabIndex = 130;
            this.lblPorcentaje.Text = "%";
            // 
            // numDescuento
            // 
            this.numDescuento.Location = new System.Drawing.Point(158, 156);
            this.numDescuento.Name = "numDescuento";
            this.numDescuento.Size = new System.Drawing.Size(81, 22);
            this.numDescuento.TabIndex = 129;
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiva.Location = new System.Drawing.Point(128, 251);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.Size = new System.Drawing.Size(18, 17);
            this.chkActiva.TabIndex = 128;
            this.chkActiva.UseVisualStyleBackColor = true;
            // 
            // lblActiva
            // 
            this.lblActiva.AutoSize = true;
            this.lblActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiva.Location = new System.Drawing.Point(53, 249);
            this.lblActiva.Name = "lblActiva";
            this.lblActiva.Size = new System.Drawing.Size(63, 18);
            this.lblActiva.TabIndex = 127;
            this.lblActiva.Text = "Activa :";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 49);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkSinFechaFin
            // 
            this.chkSinFechaFin.AutoSize = true;
            this.chkSinFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinFechaFin.Location = new System.Drawing.Point(77, 60);
            this.chkSinFechaFin.Name = "chkSinFechaFin";
            this.chkSinFechaFin.Size = new System.Drawing.Size(129, 22);
            this.chkSinFechaFin.TabIndex = 104;
            this.chkSinFechaFin.Text = "Sin fecha límite";
            this.chkSinFechaFin.UseVisualStyleBackColor = true;
            this.chkSinFechaFin.CheckedChanged += new System.EventHandler(this.chkSinFechaFin_CheckedChanged);
            // 
            // lblFechaF
            // 
            this.lblFechaF.AutoSize = true;
            this.lblFechaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaF.Location = new System.Drawing.Point(13, 24);
            this.lblFechaF.Name = "lblFechaF";
            this.lblFechaF.Size = new System.Drawing.Size(92, 18);
            this.lblFechaF.TabIndex = 103;
            this.lblFechaF.Text = "Fecha Fin :";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(130, 21);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaFin.TabIndex = 0;
            // 
            // checkedListBoxDias
            // 
            this.checkedListBoxDias.FormattingEnabled = true;
            this.checkedListBoxDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.checkedListBoxDias.Location = new System.Drawing.Point(480, 109);
            this.checkedListBoxDias.Name = "checkedListBoxDias";
            this.checkedListBoxDias.Size = new System.Drawing.Size(120, 123);
            this.checkedListBoxDias.TabIndex = 131;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSinFechaFin);
            this.groupBox1.Controls.Add(this.lblFechaF);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Location = new System.Drawing.Point(321, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 100);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // chkSinFechaInicio
            // 
            this.chkSinFechaInicio.AutoSize = true;
            this.chkSinFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinFechaInicio.Location = new System.Drawing.Point(77, 60);
            this.chkSinFechaInicio.Name = "chkSinFechaInicio";
            this.chkSinFechaInicio.Size = new System.Drawing.Size(129, 22);
            this.chkSinFechaInicio.TabIndex = 104;
            this.chkSinFechaInicio.Text = "Sin fecha límite";
            this.chkSinFechaInicio.UseVisualStyleBackColor = true;
            this.chkSinFechaInicio.CheckedChanged += new System.EventHandler(this.chkSinFechaInicio_CheckedChanged);
            // 
            // lblFechaI
            // 
            this.lblFechaI.AutoSize = true;
            this.lblFechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaI.Location = new System.Drawing.Point(13, 24);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(109, 18);
            this.lblFechaI.TabIndex = 103;
            this.lblFechaI.Text = "Fecha Inicio :";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(130, 21);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // grpFechaInicio
            // 
            this.grpFechaInicio.Controls.Add(this.chkSinFechaInicio);
            this.grpFechaInicio.Controls.Add(this.lblFechaI);
            this.grpFechaInicio.Controls.Add(this.dtpFechaInicio);
            this.grpFechaInicio.Location = new System.Drawing.Point(47, 291);
            this.grpFechaInicio.Name = "grpFechaInicio";
            this.grpFechaInicio.Size = new System.Drawing.Size(251, 100);
            this.grpFechaInicio.TabIndex = 124;
            this.grpFechaInicio.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Descuento",
            "Combo",
            "2x1",
            "DiaEspecial"});
            this.cmbTipo.Location = new System.Drawing.Point(135, 121);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(105, 24);
            this.cmbTipo.TabIndex = 123;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtSubcategorias
            // 
            this.txtSubcategorias.Location = new System.Drawing.Point(174, 186);
            this.txtSubcategorias.Name = "txtSubcategorias";
            this.txtSubcategorias.Size = new System.Drawing.Size(253, 22);
            this.txtSubcategorias.TabIndex = 122;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(295, 22);
            this.txtNombre.TabIndex = 121;
            // 
            // lblSubcategoria
            // 
            this.lblSubcategoria.AutoSize = true;
            this.lblSubcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcategoria.Location = new System.Drawing.Point(51, 187);
            this.lblSubcategoria.Name = "lblSubcategoria";
            this.lblSubcategoria.Size = new System.Drawing.Size(117, 18);
            this.lblSubcategoria.TabIndex = 120;
            this.lblSubcategoria.Text = "Subcategoría :";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(51, 122);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(51, 18);
            this.lblTipo.TabIndex = 119;
            this.lblTipo.Text = "Tipo :";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(51, 156);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(99, 18);
            this.lblDescuento.TabIndex = 118;
            this.lblDescuento.Text = "Descuento :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(51, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 18);
            this.lblNombre.TabIndex = 117;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblEditarProm
            // 
            this.lblEditarProm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(73)))), ((int)(((byte)(105)))));
            this.lblEditarProm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarProm.ForeColor = System.Drawing.Color.White;
            this.lblEditarProm.Location = new System.Drawing.Point(-3, -5);
            this.lblEditarProm.Name = "lblEditarProm";
            this.lblEditarProm.Size = new System.Drawing.Size(625, 69);
            this.lblEditarProm.TabIndex = 116;
            this.lblEditarProm.Text = "EDITAR PROMOCIÓN";
            this.lblEditarProm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(109, 422);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 49);
            this.btnGuardar.TabIndex = 115;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmEditarPromocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 481);
            this.Controls.Add(this.lblDiasPromocion);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.numDescuento);
            this.Controls.Add(this.chkActiva);
            this.Controls.Add(this.lblActiva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkedListBoxDias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFechaInicio);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtSubcategorias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSubcategoria);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEditarProm);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FrmEditarPromocion";
            this.Text = "Gestor de Promociones";
            ((System.ComponentModel.ISupportInitialize)(this.numDescuento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFechaInicio.ResumeLayout(false);
            this.grpFechaInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiasPromocion;
        private System.Windows.Forms.Label lblPorcentaje;
        public System.Windows.Forms.NumericUpDown numDescuento;
        private System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Label lblActiva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkSinFechaFin;
        private System.Windows.Forms.Label lblFechaF;
        public System.Windows.Forms.DateTimePicker dtpFechaFin;
        public System.Windows.Forms.CheckedListBox checkedListBoxDias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSinFechaInicio;
        private System.Windows.Forms.Label lblFechaI;
        public System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox grpFechaInicio;
        private System.Windows.Forms.ComboBox cmbTipo;
        public System.Windows.Forms.TextBox txtSubcategorias;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSubcategoria;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEditarProm;
        private System.Windows.Forms.Button btnGuardar;
    }
}