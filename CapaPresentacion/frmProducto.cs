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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
           
            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                gCmbCategoria.Items.Add(new OpcionCombo() { valor = item.IdCategoria, text = item.Descripcion });
            }
            gCmbCategoria.DisplayMember = "Text";
            gCmbCategoria.ValueMember = "valor";
            gCmbCategoria.SelectedIndex = 0;

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


            // se obtien listado de Productos

            List<Producto> listaProducto = new CN_Producto().Listar();
            
            foreach (Producto item in listaProducto)
            {
                gDgvData.Rows.Add(new object[] {
                    "",
                    item.IdProducto,
                    item.CodigoProducto,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria, 
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.Costo,
                    item.Precio
                });
            }
        }
        private void Limpiar()
        {
            gTxtIndice.Text = "-1";
            gTxtId.Text = "0";
            gTxtCodigo.Text = "";
            gTxtNombre.Text = "";
            gTxtDescripcion.Text = "";

            gCmbCategoria.SelectedIndex = 0;

            gTxtCodigo.Select();
        }
        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto objProducto = new Producto()
            {
                IdProducto = Convert.ToInt32(gTxtId.Text),
                CodigoProducto = gTxtCodigo.Text,
                Nombre = gTxtNombre.Text,
                Descripcion = gTxtDescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)gCmbCategoria.SelectedItem).valor) }
            };

            if (objProducto.IdProducto == 0)
            {
                int idproductogenerado = new CN_Producto().Registrar(objProducto, out mensaje);


                if (idproductogenerado != 0)
                {
                    //Agregaba a DataGridView los elementos
                    gDgvData.Rows.Add(new object[] {
                        "",
                        idproductogenerado,
                        gTxtCodigo.Text,
                        gTxtNombre.Text,
                        gTxtDescripcion.Text,
                        ((OpcionCombo)gCmbCategoria.SelectedItem).valor.ToString(),
                        ((OpcionCombo)gCmbCategoria.SelectedItem).text.ToString(),
                        "0",
                        "0.00",
                        "0.00"
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
                bool resultado = new CN_Producto().Editar(objProducto, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = gDgvData.Rows[Convert.ToInt32(gTxtIndice.Text)];
                    row.Cells["Id"].Value = gTxtId.Text;
                    row.Cells["CodigoProd"].Value = gTxtCodigo.Text;
                    row.Cells["Nombre"].Value = gTxtNombre.Text;
                    row.Cells["Descripcion"].Value = gTxtDescripcion.Text;
                    row.Cells["idCategoria"].Value = ((OpcionCombo)gCmbCategoria.SelectedItem).valor;
                    row.Cells["Categoria"].Value = ((OpcionCombo)gCmbCategoria.SelectedItem).text;

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
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

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gDgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    gTxtIndice.Text = indice.ToString();
                    gTxtId.Text = gDgvData.Rows[indice].Cells["Id"].Value.ToString();
                    gTxtCodigo.Text = gDgvData.Rows[indice].Cells["CodigoProd"].Value.ToString();
                    gTxtNombre.Text = gDgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    gTxtDescripcion.Text = gDgvData.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach(OpcionCombo oc in gCmbCategoria.Items)
                    {
                        //MessageBox.Show(oc.text + " " + oc.valor);

                        int valor_idC = Convert.ToInt32(gDgvData.Rows[indice].Cells["idCategoria"].Value);
                        //MessageBox.Show(valor_idC.ToString());

                        if (Convert.ToInt32(oc.valor) == valor_idC )
                        {
                            int indice_combo = gCmbCategoria.Items.IndexOf(oc);
                            //MessageBox.Show(indice_combo.ToString());
                            gCmbCategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    //gCmbCategoria.SelectedIndex = Convert.ToInt32(gDgvData.Rows[indice].Cells["idCategoria"].Value);

                   /* foreach (OpcionCombo oc in gCmbCategoria.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(gDgvData.Rows[indice].Cells["idCategoria"].Value))
                        {
                            int indice_combo = gCmbCategoria.Items.IndexOf(oc.valor);
                            gCmbCategoria.SelectedIndex = indice_combo;
                            break;
                        }

                    } */

                }

            }
        }

        private void gBtnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gTxtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Producto?", "ZonaTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;

                    Producto objProducto = new Producto()
                    {
                        IdProducto = Convert.ToInt32(gTxtId.Text),
                    };

                    bool respuesta = new CN_Producto().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        gDgvData.Rows.RemoveAt(Convert.ToInt32(gTxtIndice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

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
            foreach (DataGridViewRow row in gDgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void gTxtIndice_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
