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


using CapaEntidad;
using CapaNegocio;
using Guna.UI2.WinForms;
using CapaPresentacion.Properties;
using System.Diagnostics.Eventing.Reader;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            gCmbEstado.Items.Add(new OpcionCombo() { valor = 1 , text = "Activo"});
            gCmbEstado.Items.Add(new OpcionCombo() { valor = 0 , text = "Inactivo"});
            gCmbEstado.DisplayMember = "Text";
            gCmbEstado.ValueMember = "valor";
            gCmbEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();

            foreach(Rol item in listaRol)
            {
                gCmbRol.Items.Add(new OpcionCombo() { valor = item.IdRol, text = item.Descripcion });
            }
            gCmbRol.DisplayMember = "Text";
            gCmbRol.ValueMember = "valor";
            gCmbRol.SelectedIndex = 0;

            foreach(DataGridViewColumn columna in gDgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    gCmbBusqueda.Items.Add(new OpcionCombo() { text = columna.HeaderText, valor = columna.Name});
                }
            }
            gCmbBusqueda.DisplayMember = "Text";
            gCmbBusqueda.ValueMember = "valor";
            gCmbBusqueda.SelectedIndex = 0;


            // se obtien listado de Usuarios

            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                gDgvData.Rows.Add(new object[] {"",item.IdUsiario,item.Nombre,item.Telefono,item.Direccion,item.Correo, item.UserName, item.Password,
                item.oRol.Descripcion, item.Estado == true ? "Activo" : "Inactivo"
            });
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsiario = Convert.ToInt32( gTxtId.Text),
                Nombre = gTxtNombre.Text,
                Telefono = gTxtTelefono.Text,
                Direccion = gTxtDireccion.Text,
                Correo = GtxtCorreo.Text,
                UserName = gTxtUserName.Text,
                Password = gTxtPass.Text,
                Estado = Convert.ToInt32(((OpcionCombo)gCmbEstado.SelectedItem).valor) == 1 ? true : false,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)gCmbRol.SelectedItem).valor) }
            };

            if(objusuario.IdUsiario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);


                if (idusuariogenerado != 0)
                {
                    //Agregaba a DataGridView los elementos
                    gDgvData.Rows.Add(new object[] {"",idusuariogenerado,gTxtNombre.Text,gTxtTelefono.Text,gTxtDireccion.Text,GtxtCorreo.Text, gTxtUserName.Text, gTxtPass.Text,
                ((OpcionCombo)gCmbRol.SelectedItem).text.ToString(), ((OpcionCombo)gCmbEstado.SelectedItem).text.ToString()
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
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = gDgvData.Rows[Convert.ToInt32(gTxtIndice.Text)];
                    row.Cells["Id"].Value = gTxtId.Text;
                    row.Cells["Nombre"].Value = gTxtNombre.Text;
                    row.Cells["Telefono"].Value =gTxtTelefono.Text;
                    row.Cells["Direccion"].Value=gTxtDireccion.Text;
                    row.Cells["Correo"].Value = GtxtCorreo.Text;
                    row.Cells["UserName"].Value = gTxtUserName.Text;
                    row.Cells["Pass"].Value = gTxtPass.Text;
                    row.Cells["idRol"].Value = ((OpcionCombo)gCmbRol.SelectedItem).text;
                    row.Cells["Estado"].Value = ((OpcionCombo)gCmbEstado.SelectedItem).text;

                    Limpiar();
                }else { 
                    MessageBox.Show(mensaje); 
                }
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
            gTxtUserName.Text = "";
            gTxtPass.Text = "";
            gTxtConfPass.Text = "";

            gCmbEstado.SelectedIndex = 0;
            gCmbRol.SelectedIndex = 0;

            gTxtNombre.Select();
        }

        private void gDgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex < 0)
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

                if(indice >= 0)
                {
                    gTxtIndice.Text = indice.ToString();
                    gTxtId.Text = gDgvData.Rows[indice].Cells["Id"].Value.ToString();
                    gTxtNombre.Text = gDgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    gTxtDireccion.Text = gDgvData.Rows[indice].Cells["Direccion"].Value.ToString();
                    gTxtTelefono.Text = gDgvData.Rows[indice].Cells["Telefono"].Value.ToString();
                    GtxtCorreo.Text = gDgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    gTxtUserName.Text = gDgvData.Rows[indice].Cells["UserName"].Value.ToString();
                    gTxtPass.Text = gDgvData.Rows[indice].Cells["Pass"].Value.ToString();
                    gTxtConfPass.Text = gDgvData.Rows[indice].Cells["Pass"].Value.ToString();
                    //gCmbRol.Text = gDgvData.Rows[indice].Cells["idRol"].Value.ToString();

                    if (gDgvData.Rows[indice].Cells["Estado"].Value.ToString() == "Activo")
                    {
                        gCmbEstado.SelectedIndex = 0;
                    }
                    else
                    {
                        gCmbEstado.SelectedIndex = 1;
                    }

                    if (gDgvData.Rows[indice].Cells["idRol"].Value.ToString() == "EMPLEADO")
                        {
                            gCmbRol.SelectedIndex = 1;
                            
                    }else
                     if (gDgvData.Rows[indice].Cells["idRol"].Value.ToString() == "Administrador")
                     {
                         gCmbRol.SelectedIndex = 0;
                           
                     } 

                                      
                }

            }
            

        }

        private void gBtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void gBtnEliminar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(gTxtId.Text) != 0) {
                if (MessageBox.Show("¿Desea eliminar el usuario?", "ZonaTech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                    string mensaje = string.Empty;

                    Usuario objusuario = new Usuario()
                    {
                        IdUsiario = Convert.ToInt32(gTxtId.Text),
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if(respuesta)
                    {
                        gDgvData.Rows.RemoveAt(Convert.ToInt32(gTxtIndice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void gBtnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)gCmbBusqueda.SelectedItem).valor.ToString();

            if(gDgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in gDgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(gTxtBusqueda.Text.Trim().ToUpper())){
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
            foreach(DataGridViewRow row in gDgvData.Rows)
            {
                row.Visible=true;
            }
        }
    }
}
