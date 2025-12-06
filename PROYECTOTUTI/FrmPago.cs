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
    public partial class FrmPago : Form
    {
        public string MetodoPago { get; private set; } = "EFECTIVO";
        public decimal TotalAPagar { get; set; }
 
        public FrmPago()
        {
            InitializeComponent();
        }                   
        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            MetodoPago = "EFECTIVO";
            pnlEfectivo.Visible = true;
            pnlTarjetaCredito.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MetodoPago = "TARJETA";
            pnlEfectivo.Visible = false;
            pnlTarjetaCredito.Visible = true;
        }

        private void Aceptar_Click_1(object sender, EventArgs e)
        {
            if (pnlEfectivo.Visible && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (decimal.TryParse(textBox1.Text, out decimal efectivoRecibido))
                {
                    if (efectivoRecibido >= TotalAPagar)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return; 
                    }
                }
            }
            else if (pnlTarjetaCredito.Visible)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            MessageBox.Show("Complete los datos de pago correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPago_Load_1(object sender, EventArgs e)
        {
            lblDinero.Text = TotalAPagar.ToString("C2");
            pnlEfectivo.Visible = false;
            pnlTarjetaCredito.Visible = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal efectivoRecibido))
            {

                decimal cambio = efectivoRecibido - TotalAPagar;
                if (cambio >= 0)
                {
                    lblDarCambio.Text = cambio.ToString("C2");
                }
                else
                {
                    lblDarCambio.Text = "Fondos insuficientes";
                }
            }
            else
            {
                lblDarCambio.Text = "Ingresa un valor válido";
            }
        }
    }
}
