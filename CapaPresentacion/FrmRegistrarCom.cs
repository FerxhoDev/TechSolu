using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistrarCom : Form
    {
        private Usuario _usuarioact;
        public FrmRegistrarCom(Usuario objUsuario)
        {
            _usuarioact = objUsuario;
            InitializeComponent();
        }

        private void FrmRegistrarCom_Load(object sender, EventArgs e)
        {
            cmbDocumento.Items.Add(new OpcionCombo() { valor = "Recibo", text = "Recibo" });
            cmbDocumento.Items.Add(new OpcionCombo() { valor = "Factura", text = "Factura" });
            cmbDocumento.DisplayMember = "text";
            cmbDocumento.ValueMember = "valor";
            cmbDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyy");

            txtIdPr.Text = "0";
            txtidProd.Text = "0";
        }

        private void gBtnBuscarPr_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if(result == DialogResult.OK)
                {
                    txtIdPr.Text = modal._Proveedor.idProveedor.ToString();
                    txtNombrePr.Text = modal._Proveedor.Nombre.ToString();
                    txtTelefonoPr.Text = modal._Proveedor.Telefono.ToString();
                }
                else
                {
                    txtNombrePr.Select();
                }
            }
        }

        private void gBtnBuscarProd_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidProd.Text = modal._Producto.IdProducto.ToString();
                    txtCodProd.Text = modal._Producto.CodigoProducto.ToString();
                    txtProd.Text = modal._Producto.Nombre.ToString();
                    txtCodProd.Select();
                }
                else
                {
                    txtCodProd.Select();
                }
            }
        }

        private void txtCodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter) { 
                Producto oProducto = new CN_Producto().Listar().Where(p => p.CodigoProducto == txtCodProd.Text).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodProd.BackColor = Color.Honeydew;
                    txtidProd.Text = oProducto.IdProducto.ToString();
                    txtProd.Text = oProducto.Nombre;
                    txtCosto.Select();
                }
            }
            else
            {
                txtCodProd.BackColor = Color.MistyRose;
                txtidProd.Text = "0";
                txtProd.Text = "";
            }
        }

        private void gBtnAddtoCar_Click(object sender, EventArgs e)
        {
            decimal costo = 0;
            decimal precio = 0;
            bool producto_existe = false;

            if(int.Parse(txtidProd.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "SoluTech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if(!decimal.TryParse(txtCosto.Text, out costo))
            {
                MessageBox.Show("Formato de moneda incorrecta en COSTO", "SoluTech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCosto.Select();
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Formato de moneda incorrecta en PRECIO", "SoluTech", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCosto.Select();
                return;
            }

            foreach(DataGridViewRow fila in gDgvData.Rows)
            {
                if (fila.Cells["Idproducto"].Value.ToString() == txtidProd.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if(!producto_existe)
            {
                decimal subt = Convert.ToInt32(gTxtCantidad.Value.ToString());
                decimal subComp = subt * costo;
                gDgvData.Rows.Add(new object[]
                {
                    txtidProd.Text,
                    txtProd.Text,
                    costo.ToString("0.00"),
                    precio.ToString("0.00"),
                    gTxtCantidad.Value.ToString(),
                    subComp.ToString(),
                });
                calcularTotal();
                limpiarProducto();
                txtCodProd.Select();
            }

        }


        private void limpiarProducto()
        {
            txtidProd.Text = "0";
            txtCodProd.Text = "";
            txtCodProd.BackColor = Color.White;
            txtProd.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
            gTxtCantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if(gDgvData.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in gDgvData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTotalPag.Text = total.ToString("0.00");
        }

        private void gDgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var x = e.CellBounds.Left + (e.CellBounds.Width - 25) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - 25) / 2;

                e.Graphics.DrawImage(Properties.Resources.eliminar_25, new Rectangle(x, y, 25, 25));
                e.Handled = true;
            }
        }

        private void gDgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gDgvData.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    gDgvData.Rows.RemoveAt(indice);
                    calcularTotal();
                }

            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validaciones para que solo acepte números y punto
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if(txtCosto.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled=true;
                }
                else
                {
                    if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validaciones para que solo acepte números y punto
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void gBtnAddCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdPr.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un PROVEEDOR", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(gDgvData.Rows.Count < 0) 
            {
                MessageBox.Show("Debe ingresar Productos a la Lista de Compras", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("Costo", typeof(decimal));
            detalle_compra.Columns.Add("Precio", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));


            foreach(DataGridViewRow row in gDgvData.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[]
                    {
                       Convert.ToInt32(row.Cells["IdProducto"].Value),
                       row.Cells["Costo"].Value,
                       row.Cells["Precio"].Value,
                       row.Cells["Cantidad"].Value,
                       row.Cells["SubTotal"].Value
                    }    
                );

            }
            int idCorrelativo = new CN_Compra().ObtenerCorrelativo();

            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario()
                {
                    IdUsiario = _usuarioact.IdUsiario
                },
                oProveedor = new Proveedor()
                {
                    idProveedor = Convert.ToInt32( txtIdPr.Text)
                },
                TipoDocumento = ((OpcionCombo)cmbDocumento.SelectedItem).text,
                NumeroDocumento = numeroDocumento,
                MontoTotal = Convert.ToDecimal( txtTotalPag.Text),
            };
            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra,out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                }

                txtIdPr.Text = "0";
                txtNombrePr.Text = "";
                txtTelefonoPr.Text = "";
                gDgvData.Rows.Clear();
                calcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje,"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
