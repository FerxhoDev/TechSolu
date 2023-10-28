using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtBusqueda.Text);

            if (oCompra.IdCompra != 0)
            {
                txtFecha.Text = oCompra.FechaRegistro;
                txtTipoDoc.Text = oCompra.TipoDocumento;
                txtUsuario.Text = oCompra.oUsuario.Nombre;
                txtNomProv.Text = oCompra.oProveedor.Nombre;
                txtTelefProv.Text = oCompra.oProveedor.Telefono;

                gDgvData.Rows.Clear();

                foreach(Detalle_Compra dc in oCompra.oDetalleComrpa)
                {
                    gDgvData.Rows.Add(new object[] { dc.oProducto.Nombre, dc.Costo, dc.Cantidad, dc.MontoTotal });

                }

                txtMontoTotal.Text = oCompra.MontoTotal.ToString("0.00");
            }
        }
    }
}
