using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in gDgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    gCmbBusqueda.Items.Add(new OpcionCombo() { text = columna.HeaderText, valor = columna.Name });
                }
            }
            gCmbBusqueda.DisplayMember = "Text";
            gCmbBusqueda.ValueMember = "valor";
            gCmbBusqueda.SelectedIndex = 0;


            // se obtien listado de Usuarios

            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedor)
            {
                gDgvData.Rows.Add(new object[] { "",item.idProveedor, item.Nombre, item.Telefono, item.Direccion, item.Correo

            });
            }

        }

        private void Limpiar()
        {
            gTxtIndice.Text = "-1";
            gTxtId.Text = "0";
            gTxtNombre.Text = "";
            gTxtDireccion.Text = "";
            gTxtTelefono.Text = "";
            GtxtCorreo.Text = "";

            gTxtNombre.Select();
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor objProveedor = new Proveedor()
            {
                idProveedor = Convert.ToInt32(gTxtId.Text),
                Nombre = gTxtNombre.Text,
                Telefono = gTxtTelefono.Text,
                Direccion = gTxtDireccion.Text,
                Correo = GtxtCorreo.Text,
            };

            if (objProveedor.idProveedor == 0)
            {
                int idProveedorgenerado = new CN_Proveedor().Registrar(objProveedor, out mensaje);


                if (idProveedorgenerado != 0)
                {
                    //Agregaba a DataGridView los elementos
                    gDgvData.Rows.Add(new object[] {"",idProveedorgenerado,gTxtNombre.Text,gTxtTelefono.Text,gTxtDireccion.Text,GtxtCorreo.Text
                });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Proveedor().Editar(objProveedor, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = gDgvData.Rows[Convert.ToInt32(gTxtIndice.Text)];
                    row.Cells["Id"].Value = gTxtId.Text;
                    row.Cells["Nombre"].Value = gTxtNombre.Text;
                    row.Cells["Telefono"].Value = gTxtTelefono.Text;
                    row.Cells["Direccion"].Value = gTxtDireccion.Text;
                    row.Cells["Correo"].Value = GtxtCorreo.Text;

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void gBtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gTxtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Proveedor?", "ZonaTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;

                    Proveedor objProveedor = new Proveedor()
                    {
                        idProveedor = Convert.ToInt32(gTxtId.Text),
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(objProveedor, out mensaje);

                    if (respuesta)
                    {
                        gDgvData.Rows.RemoveAt(Convert.ToInt32(gTxtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Limpiar();

            }
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)gCmbBusqueda.SelectedItem).valor.ToString();

            if (gDgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(gTxtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void gBtnLimpiarBusc_Click(object sender, EventArgs e)
        {
            gTxtBusqueda.Text = "";
            gCmbBusqueda.SelectedIndex = 0;
            foreach (DataGridViewRow row in gDgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gDgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    gTxtIndice.Text = indice.ToString();
                    gTxtId.Text = gDgvData.Rows[indice].Cells["Id"].Value.ToString();
                    gTxtNombre.Text = gDgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    gTxtDireccion.Text = gDgvData.Rows[indice].Cells["Direccion"].Value.ToString();
                    gTxtTelefono.Text = gDgvData.Rows[indice].Cells["Telefono"].Value.ToString();
                    GtxtCorreo.Text = gDgvData.Rows[indice].Cells["Correo"].Value.ToString();

                }

            }
        }

        private void gDgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var x = e.CellBounds.Left + (e.CellBounds.Width - 20) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - 20) / 2;

                e.Graphics.DrawImage(Properties.Resources.ojo_20, new Rectangle(x, y, 20, 20));
                e.Handled = true;
            }
        }
    }
}
