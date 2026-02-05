using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOTUTI
{
    public partial class FrmInfoProducto : Form
    {
        private List<Image> imagenesProducto = new List<Image>();
        private int indiceImagenActual = 0;
        public FrmInfoProducto(int codigoProducto)
        {
            InitializeComponent();
            
            CargarImagenesProducto(codigoProducto); 
        }

        private void CargarImagenesProducto(int codigoProducto)
        {
            BaseDeDatos conSQL = new BaseDeDatos();
            string consulta = "SELECT Imagen FROM ImagenesProducto WHERE CodigoProducto = @CodigoProducto";
            DataTable dtImagenes = conSQL.retornaRegistros(consulta, new SqlParameter("@CodigoProducto", codigoProducto));
            foreach (DataRow row in dtImagenes.Rows)
            {
                byte[] imgData = (byte[])row["Imagen"];
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    imagenesProducto.Add(Image.FromStream(ms));
                }
            }

            if (imagenesProducto.Count > 0)
            {
                MostrarImagenActual();
            }        
        }

        private void MostrarImagenActual()
        {
            picImagen.Image = imagenesProducto[indiceImagenActual];
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual > 0)
            {
                indiceImagenActual--;
                picImagen.Image = imagenesProducto[indiceImagenActual];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceImagenActual < imagenesProducto.Count - 1)
            {
                indiceImagenActual++;
                picImagen.Image = imagenesProducto[indiceImagenActual];
            }
        }
 

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
