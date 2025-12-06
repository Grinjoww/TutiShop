using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOTUTI
{
    public partial class FrmCajaEntrada : Form
    {
        public string Cantidad { get; private set; }
        public string Descuento { get; private set; }
        public FrmCajaEntrada(string promptCantidad, string promptDescuento, string title, string defaultValueCantidad, string defaultValueDescuento)
        {
            InitializeComponent();
            this.Text = title;

            lblCantidad.Text = promptCantidad;
            txtCantidad.Text = defaultValueCantidad;

            lblDescuento.Text = promptDescuento;
            txtDescuento.Text = defaultValueDescuento;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cantidad = txtCantidad.Text;
            Descuento = txtDescuento.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
