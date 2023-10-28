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
    public partial class mdProveedor : Form
    {
        public Proveedor _Proveedor { get; set; }
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mdProveedor_Load(object sender, EventArgs e)
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


            // se obtien listado de Proveedores

            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedor)
            {
                gDgvData.Rows.Add(new object[] { item.idProveedor, item.Nombre, item.Telefono,

            });
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

        private void gDgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if(iRow >= 0 && iCol > 0)
            {
                _Proveedor = new Proveedor()
                {
                    idProveedor = Convert.ToInt32(gDgvData.Rows[iRow].Cells["id"].Value.ToString()),
                    Nombre = gDgvData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    Telefono = gDgvData.Rows[iRow].Cells["Telefono"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
