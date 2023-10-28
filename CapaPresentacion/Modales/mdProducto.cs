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

namespace CapaPresentacion.Modales
{
    public partial class mdProducto : Form
    {

        public Producto _Producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in gDgvData.Columns)
            {
                if (columna.Visible == true)
                {
                    gCmbBusqueda.Items.Add(new OpcionCombo() { text = columna.HeaderText, valor = columna.Name });
                }
            }
            gCmbBusqueda.DisplayMember = "Text";
            gCmbBusqueda.ValueMember = "valor";
            gCmbBusqueda.SelectedIndex = 0;

            List<Producto> listaProveedor = new CN_Producto().Listar();

            foreach (Producto item in listaProveedor)
            {
                gDgvData.Rows.Add(new object[] { item.IdProducto, item.CodigoProducto, item.Nombre, item.oCategoria.Descripcion, item.Costo, item.Precio

            });
            }
       
        }

        private void gDgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol > 0)
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(gDgvData.Rows[iRow].Cells["Id"].Value),
                    CodigoProducto = gDgvData.Rows[iRow].Cells["CodigoProd"].Value.ToString(),
                    Nombre = gDgvData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(gDgvData.Rows[iRow].Cells["Stock"].Value),
                    Costo = Convert.ToInt32(gDgvData.Rows[iRow].Cells["Costo"].Value),
                    Precio = Convert.ToInt32(gDgvData.Rows[iRow].Cells["Precio"].Value),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
