using CapaEntidad;
using Guna.UI2.WinForms;
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
    public partial class frmCompras : Form
    {

        private Usuario _usuarioact;
        private static Guna2GradientButton MenuActiv = null;
        private static Form FormularioActivo = null;
        public frmCompras(Usuario objUsuario)
        {
            _usuarioact = objUsuario;
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(Guna2GradientButton menu, Form formulario)
        {
            if (MenuActiv != null)
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

        private void gBtnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new FrmRegistrarCom(_usuarioact));
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario((Guna2GradientButton)sender, new frmDetalleCompra());
        }
    }
}
