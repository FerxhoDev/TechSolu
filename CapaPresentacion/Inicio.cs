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
using Guna.UI.WinForms;
using Guna.UI2.WinForms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuariolog;
        private static Form FormularioActivo = null;
        //private static GunaGradientButton MenuActiv = null;

        private static Guna2GradientButton MenuActiv = null;

        public Inicio(Usuario objusuario)
        {
            usuariolog = objusuario;
            InitializeComponent();
            string primerNombre = objusuario.Nombre.Split(' ')[0];
            lblName.Text = "Hola " + primerNombre + "!";

            

            List<String> menus = new List<string>();
            menus.Add("gBtnDash");
            menus.Add("gBtnUsuario");
            menus.Add("gBtnAjust");
            menus.Add("gBtnVentas");
            menus.Add("gBtnCompras");
            menus.Add("gBtnClientes");
            menus.Add("gBtnProveedores");
            menus.Add("gBtnReportes");

            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuariolog.IdUsiario);


            foreach (string menu in menus)
            {
                // Comprueba si el menú está en ListaPermisos
                if (ListaPermisos.Any(permiso => permiso.NombreMenu == menu))
                {
                    // Aquí puedes activar el menú
                    // Por ejemplo, si estás trabajando con controles de Windows Forms:
                    // gBtnDash.Enabled = true;}

                    Control[] botones = this.Controls.Find(menu, true);

                    if (botones.Length > 0)
                    {
                        Control boton = botones[0];
                        if (boton is Guna.UI2.WinForms.Guna2GradientButton)
                        {
                            ((Guna.UI2.WinForms.Guna2GradientButton)boton).Visible = true;
                        }
                    }
                }
                if(ListaPermisos.Count > 6)
                {
                    lblAdmin.Visible = true;
                }
                else
                {
                    lblAdmin.Visible = false;
                }
            }

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            

        }
      

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormulario(Guna2GradientButton menu, Form formulario)
        {
            if(MenuActiv != null)
            {
                MenuActiv.FillColor = Color.FromArgb(1, 18, 57, 88);
                MenuActiv.FillColor2 = Color.FromArgb(1, 18, 57, 88);
            }

            menu.FillColor = Color.Beige;
            menu.FillColor2 = Color.FromArgb(1, 18, 57, 88);

            MenuActiv = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //formulario.BackColor = Color.Red;

            pContainer.Controls.Add(formulario);
            formulario.Show();
        }

        private void gBtnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmUsuarios());
        }

        private void bGtnAjust_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton) sender, new frmAjustes());
        }

        private void gBtnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmVentas());
        }

        private void gBtnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmCompras(usuariolog));
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmClientes());
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmProveedores());
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmReportes());
        }

        private void gBtnDash_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmDash());
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
