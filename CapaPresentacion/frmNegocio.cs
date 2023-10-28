using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        public Image ByteToImage(byte[] imageByte)
        {
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Write(imageByte, 0, imageByte.Length);

            Image image = new Bitmap(memoryStream);

            return image;
        }
        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimage = new CN_Negocio().obtenerLogo(out obtenido);

            if(obtenido)
            {
                gPtbLogo.Image = ByteToImage(byteimage);
            }

            Negocio datos = new CN_Negocio().ObtenerDatos();

            gTxtNombre.Text = datos.Nombre;
            gTxtNit.Text = datos.NIT;
            gTxtDireccion.Text = datos.Direcion;

        }

        private void gBtnCargarL_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "Files|*.jpg;*jpeg;*png";

            if(ofd.ShowDialog() == DialogResult.OK) {
                byte[] byteimagen = File.ReadAllBytes(ofd.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimagen, out mensaje);
                
                if(respuesta)
                {
                    gPtbLogo.Image = ByteToImage((byte[])byteimagen);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio objNegocio = new Negocio()
            {
                Nombre = gTxtNombre.Text,
                Direcion = gTxtDireccion.Text,
                NIT = gTxtNit.Text,
            };

            bool respuesta = new CN_Negocio().GuardarDatos(objNegocio, out mensaje);

            if(respuesta) {
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
