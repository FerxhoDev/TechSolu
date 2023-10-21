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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void gTxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // se obtien listado de Categorias

            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                gDgvData.Rows.Add(new object[] {"",item.IdCategoria, item.Descripcion
            });
            }
        }

        private void gBtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categoria objCategoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(gTxtId.Text),
                Descripcion = gTxtDescrip.Text,

            };

            if (objCategoria.IdCategoria == 0)
            {
                int idcategoriagenerado = new CN_Categoria().Registrar(objCategoria, out mensaje);


                if (idcategoriagenerado != 0)
                {
                    //Agregaba a DataGridView los elementos
                    gDgvData.Rows.Add(new object[] {"",idcategoriagenerado,gTxtDescrip.Text
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
                bool resultado = new CN_Categoria().Editar(objCategoria, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = gDgvData.Rows[Convert.ToInt32(gTxtIndice.Text)];
                    row.Cells["Id"].Value = gTxtId.Text;
                    row.Cells["Descripcion"].Value = gTxtDescrip.Text;

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }



            }
        }
        private void Limpiar()
        {
            gTxtIndice.Text = "-1";
            gTxtId.Text = "0";
            gTxtDescrip.Text = "";


            gTxtDescrip.Select();
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
                    gTxtDescrip.Text = gDgvData.Rows[indice].Cells["Descripcion"].Value.ToString();
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
                if (MessageBox.Show("¿Desea eliminar la Categoria?", "ZonaTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;

                    Categoria objcategoria = new Categoria()
                    {
                        IdCategoria = Convert.ToInt32(gTxtId.Text),
                    };

                    bool respuesta = new CN_Categoria().Eliminar(objcategoria, out mensaje);

                    if (respuesta)
                    {
                        gDgvData.Rows.RemoveAt(Convert.ToInt32(gTxtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Limpiar() ;
            }
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            //string columnaFiltro = ((OpcionCombo)gCmbBusqueda.SelectedItem).valor.ToString();

            if (gDgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    if (row.Cells["Descripcion"].Value.ToString().Trim().ToUpper().Contains(gTxtBusqueda.Text.Trim().ToUpper()))
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
    }
}
