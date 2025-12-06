using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PROYECTOTUTI.FrmVentas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTOTUTI
{
    public partial class FrmEditarPromocion : Form
    {
        public Promocion Promocion { get; private set; }
        private readonly List<string> diasSemana = new List<string>
         {
        "Monday", "Tuesday", "Wednesday",
        "Thursday", "Friday", "Saturday", "Sunday"
         };
        public FrmEditarPromocion(Promocion promocion = null)
        {
            InitializeComponent();
            Promocion = promocion ?? new Promocion();
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now.AddMonths(1);
            chkSinFechaInicio.Checked = false;
            chkSinFechaFin.Checked = false;
            this.chkSinFechaInicio.CheckedChanged += chkSinFechaInicio_CheckedChanged;
            this.chkSinFechaFin.CheckedChanged += chkSinFechaFin_CheckedChanged;
            checkedListBoxDias.Items.Clear();
            foreach (var dia in diasSemana)
            {
                checkedListBoxDias.Items.Add(dia, false);
            }
            CargarDatos();
            ConfigurarControles();
        }
        private void ConfigurarControles()
        {
            toolTip.SetToolTip(txtSubcategorias, "Escriba las subcategorías separadas por comas.\nEjemplo: Vestido,Camisa,Pantalón");
            dtpFechaInicio.Enabled = !chkSinFechaInicio.Checked;
            dtpFechaFin.Enabled = !chkSinFechaFin.Checked;
        }
        private void CargarDatos()
        {
            txtNombre.Text = Promocion.Nombre;
            cmbTipo.SelectedItem = Promocion.Tipo ?? "Descuento";
            numDescuento.Value = Promocion.Descuento * 100;
            txtSubcategorias.Text = string.Join(",", Promocion.Subcategorias ?? new List<string>());
            chkActiva.Checked = Promocion.Activa;

            if (Promocion.FechaInicio.HasValue)
            {
                dtpFechaInicio.Value = Promocion.FechaInicio.Value;
                chkSinFechaInicio.Checked = false;
            }

            if (Promocion.FechaFin.HasValue)
            {
                dtpFechaFin.Value = Promocion.FechaFin.Value;
                chkSinFechaFin.Checked = false;
            }
            if (!string.IsNullOrEmpty(Promocion.DiasPromocion))
            {
                var diasSeleccionados = Promocion.DiasPromocion.Split(',');
                for (int i = 0; i < checkedListBoxDias.Items.Count; i++)
                {
                    var dia = (string)checkedListBoxDias.Items[i];
                    checkedListBoxDias.SetItemChecked(i, diasSeleccionados.Contains(dia));
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            var diasSeleccionados = new List<string>();
            for (int i = 0; i < checkedListBoxDias.Items.Count; i++)
            {
                if (checkedListBoxDias.GetItemChecked(i))
                {
                    diasSeleccionados.Add((string)checkedListBoxDias.Items[i]);
                }
            }
            Promocion.DiasPromocion = string.Join(",", diasSeleccionados);
            Promocion.Nombre = txtNombre.Text.Trim();
            Promocion.Tipo = cmbTipo.SelectedItem.ToString();
            Promocion.Subcategorias = txtSubcategorias.Text.Split(',')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            Promocion.Descuento = numDescuento.Value / 100m;
            Promocion.Activa = chkActiva.Checked;
            Promocion.FechaInicio = chkSinFechaInicio.Checked ? null : (DateTime?)dtpFechaInicio.Value;
            Promocion.FechaFin = chkSinFechaFin.Checked ? null : (DateTime?)dtpFechaFin.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("¡Debe ingresar un nombre para la promoción!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var subcategoriasIngresadas = txtSubcategorias.Text.Split(',').Select(s => s.Trim()).Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            if (subcategoriasIngresadas.Count == 0 && cmbTipo.SelectedItem.ToString() != "DiaEspecial")
            {
                MessageBox.Show("¡Debe ingresar al menos una subcategoría válida!",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!chkSinFechaInicio.Checked && !chkSinFechaFin.Checked && dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("¡La fecha de inicio no puede ser mayor que la fecha fin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbTipo.SelectedItem.ToString() == "DiaEspecial" && checkedListBoxDias.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un día para promociones especiales",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esDiaEspecial = cmbTipo.SelectedItem.ToString() == "DiaEspecial";
            checkedListBoxDias.Enabled = esDiaEspecial;
            lblDiasPromocion.Enabled = esDiaEspecial;

            if (!esDiaEspecial)
            {
                for (int i = 0; i < checkedListBoxDias.Items.Count; i++)
                {
                    checkedListBoxDias.SetItemChecked(i, false);
                }
            }
        }

        private void chkSinFechaInicio_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaInicio.Enabled = !chkSinFechaInicio.Checked;
            if (chkSinFechaInicio.Checked)
            {
                dtpFechaInicio.Value = DateTime.Now;
            }

        }

        private void chkSinFechaFin_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaFin.Enabled = !chkSinFechaFin.Checked;
            if (chkSinFechaFin.Checked)
            {
                dtpFechaFin.Value = DateTime.Now.AddMonths(1);
            }

        }
    }

}
