using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gSwitchPss.Checked)
            {
                gTxtPass.UseSystemPasswordChar = false;
            }
            else
            {
                gTxtPass.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.UserName == gTxtUser.Text && u.Password == gTxtPass.Text).FirstOrDefault();

            if(ousuario != null)
            {
                Inicio init = new Inicio();

                init.Show();
                this.Hide();

                init.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña Incorrectos", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            gTxtPass.Text = "";
            gTxtUser.Text = "";
            this.Show();
        }
    }
}
